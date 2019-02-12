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
    public partial class formInteractiveConstrustor : Form
    {
        int type;
        public string way;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassCity> city = new List<ClassCity>();
        formConstructor constr;

        public formInteractiveConstrustor(int t, formConstructor c)
        {
            InitializeComponent();
            type = t;
            constr = c;
            way = "";
        }

        private void formInteractiveConstrustor_Load(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.Left;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.ShowCenter = false;
            if (type == 1) //Отдых на море
            {
                btnOK.Visible = false;
                gmap.Height = 717;
                db.Execute<ClassCity>(ref stp, "SELECT id_city, name_city FROM city WHERE sea=1", ref city);
                if (city.Count > 0)
                {
                    for (int i = 0; i < city.Count; i++)
                    {
                        gmap.SetPositionByKeywords(city[i].name);
                        marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green_small);
                        marker.ToolTipText = (city[i].name);
                        marker.Tag = 1;
                        markers.Markers.Add(marker);
                    }
                    gmap.Overlays.Add(markers);
                }
            }
            else if (type == 4) //Горнолыжный курорт
            {
                btnOK.Visible = false;
                gmap.Height = 717;
                db.Execute<ClassCity>(ref stp, "SELECT id_city, name_city FROM city WHERE sea=0", ref city);
                if (city.Count > 0)
                {
                    for (int i = 0; i < city.Count; i++)
                    {
                        gmap.SetPositionByKeywords(city[i].name);
                        marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green_small);
                        marker.ToolTipText = (city[i].name);
                        marker.Tag = 1;
                        markers.Markers.Add(marker);
                    }
                    gmap.Overlays.Add(markers);
                }
            }
            else if (type == 2) //Морской круиз
            {
                db.Execute<ClassCity>(ref stp, "SELECT id_city, name_city FROM city WHERE sea=1", ref city);
                if (city.Count > 0)
                {
                    for (int i = 0; i < city.Count; i++)
                    {
                        gmap.SetPositionByKeywords(city[i].name);
                        marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green_small);
                        marker.ToolTipText = (city[i].name);
                        marker.Tag = 1;
                        markers.Markers.Add(marker);
                    }
                    gmap.Overlays.Add(markers);
                }
            }

            gmap.SetPositionByKeywords("Никосия");
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
                formImgOrChoose obj = new formImgOrChoose(item.ToolTipText, Convert.ToInt32(item.Tag.ToString()), type, this, constr);
                obj.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (way != "")
                constr.tbWay.Text = way.Remove(0, 1);
            this.Close();
        }

        public void RefreshWay()
        {
            if (way != "")
            {
                gmap.DragButton = MouseButtons.Left;
                GMaps.Instance.Mode = AccessMode.ServerOnly;
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.ShowCenter = false;
                GMapOverlay routes = new GMapOverlay("routes");
                GMapOverlay markers = new GMapOverlay("marker");
                List<PointLatLng> points = new List<PointLatLng>();
                GMapMarker marker;
                gmap.Overlays.Clear();
                if (way[0] == '_')
                    way.Remove(0, 1);
                string[] cities = way.Split('_');
                for (int i = 0; i < city.Count; i++)
                {
                    bool doIt = false;
                    for (int j = 0; j < cities.Count(); j++)
                    {
                        if (city[i].name == cities[j])
                        {
                            doIt = true;
                            break;
                        }
                    }
                    gmap.SetPositionByKeywords(city[i].name);
                    if (doIt)
                    {
                        marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.red_small);
                        marker.Tag = 0;
                        points.Add(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng));
                    }
                    else
                    {
                        marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green_small);
                        marker.Tag = 1;
                    }
                    marker.ToolTipText = city[i].name;
                    markers.Markers.Add(marker);
                }
                GMapRoute route = new GMapRoute(points, "Way ");
                route.Stroke = new Pen(Color.Red, 3);
                routes.Routes.Add(route);
                gmap.Overlays.Add(routes);
                gmap.Overlays.Add(markers);
                gmap.SetPositionByKeywords("Никосия");
                gmap.Zoom = 3;
            }
        }
    }
}
