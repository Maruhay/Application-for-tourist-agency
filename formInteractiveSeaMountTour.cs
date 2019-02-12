using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace TouristAgency
{
    public partial class formInteractiveSeaMountTour : Form
    {
        bool SeaOrMount;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassSeaTour> SeaTour = new List<ClassSeaTour>();
        List<ClassMountainTour> MountTour = new List<ClassMountainTour>();

        public formInteractiveSeaMountTour(bool Sea)
        {
            InitializeComponent();
            SeaOrMount = Sea;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {

        }

        private void formInteractiveSeaMountTour_Load(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.Left;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.ShowCenter = false;

            if (SeaOrMount)
            {
                SeaTour.Clear();
                db.Execute<ClassSeaTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=2 AND t.status_tour='Доступен'", ref SeaTour);
                if (SeaTour.Count > 0)
                {
                    for (int i = 0; i < SeaTour.Count; i++)
                    {
                        gmap.SetPositionByKeywords(SeaTour[i].city+","+SeaTour[i].country);
                        marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat , gmap.Position.Lng),GMarkerGoogleType.green_small);
                        marker.ToolTipText = (SeaTour[i].city+"\nДата начала: "+SeaTour[i].date_start.Substring(0,10)+"\nГород отправления: "+SeaTour[i].city_departure+"\nЦена: "+SeaTour[i].price+"$");
                        marker.Tag = SeaTour[i].id_tour;
                        markers.Markers.Add(marker);
                    }
                    gmap.Overlays.Add(markers);
                }
            }
            else
            {
                MountTour.Clear();
                db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен'", ref MountTour);
                if (MountTour.Count > 0)
                {
                    for (int i = 0; i < MountTour.Count; i++)
                    {
                        gmap.SetPositionByKeywords(MountTour[i].city + "," + MountTour[i].country);
                        marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green_small);
                        marker.ToolTipText = (MountTour[i].city + "\nДата начала: " + MountTour[i].date_start.Substring(0, 10) + "\nГород отправления: " + MountTour[i].city_departure + "\nЦена: " + MountTour[i].price + "$");
                        marker.Tag = MountTour[i].id_tour;
                        markers.Markers.Add(marker);
                    }
                    gmap.Overlays.Add(markers);
                }
            }
            gmap.SetPositionByKeywords("Ираклион");
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string[] s = item.ToolTipText.Split('\n');
            if (SeaOrMount)
            {
                formImgOrSale obj = new formImgOrSale("Город " + s[0], Convert.ToInt32(item.Tag.ToString()), 1);//1 - Автобусный тур
                obj.ShowDialog();
            }
            else
            {
                formImgOrSale obj = new formImgOrSale("Город " + s[0], Convert.ToInt32(item.Tag.ToString()), 4);//4 - Горнолыжный курорт
                obj.ShowDialog();
            }
        }
    }
}
