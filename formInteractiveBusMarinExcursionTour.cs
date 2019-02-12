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
    public partial class formInteractiveBusMarinExcursionTour : Form
    {
        ClassSetupProgram stp = new ClassSetupProgram();
        ClassDataBase db = new ClassDataBase();
        List<ClassBusTour> tour = new List<ClassBusTour>();
        List<ClassExcursionsTour> ExcTour = new List<ClassExcursionsTour>();
        List<ClassMarinTour> MarinTour = new List<ClassMarinTour>();
        int type;

        public formInteractiveBusMarinExcursionTour(int mode)
        {
            InitializeComponent();
            type = mode;
        }

        private void formInteractiveAutobusTour_Load(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.Left;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.ShowCenter = false;
            gmap.SetPositionByKeywords("Ираклион");
            switch (type)
            {
                case 1:
                    tour.Clear();
                    db.Execute<ClassBusTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=1 AND t.status_tour='Доступен'", ref tour);
                    if (tour.Count > 0)
                    {
                        for (int i = 0; i < tour.Count; i++)
                        {
                            cbWay.Items.Add(tour[i].way_tour.Replace("_", "-->"));
                        }

                    }
                    break;
                case 2:
                    MarinTour.Clear();
                    db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=3 AND t.status_tour='Доступен'", ref MarinTour);
                    if (MarinTour.Count > 0)
                    {
                        for (int i = 0; i < MarinTour.Count; i++)
                        {
                            cbWay.Items.Add(MarinTour[i].way_tour.Replace("_", "-->"));
                        }

                    }
                    break;
                case 3:
                    ExcTour.Clear();
                    db.Execute<ClassExcursionsTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.excursions_tour, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=4 AND t.status_tour='Доступен'", ref ExcTour);
                    if (ExcTour.Count > 0)
                    {
                        for (int i = 0; i < ExcTour.Count; i++)
                        {
                            cbWay.Items.Add(ExcTour[i].way_tour.Replace("_", "-->"));
                        }

                    }
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GMapOverlay routes = new GMapOverlay("routes");
            GMapOverlay markers = new GMapOverlay("marker");
            List<PointLatLng> points = new List<PointLatLng>();
            GMapMarker marker;
            gmap.Overlays.Clear();
            gmap.Zoom = 3;

            switch (type)
            {
                case 1:
                    tour.Clear();
                    db.Execute<ClassBusTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=1 AND t.status_tour='Доступен' AND t.way_tour='" + cbWay.Text.Replace("-->", "_") + "'", ref tour);
                    if (tour.Count > 0)
                    {
                        string[] s = tour[0].way_tour.Split('_');
                        int j = 0;
                        while (j < s.Length)
                        {
                            gmap.SetPositionByKeywords(s[j]);
                            points.Add(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng));
                            if (j == 0)
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green);
                                marker.ToolTipText = "Начало пути \n Город: " + s[j] + "\nДата начала: " + tour[j].date_start.Substring(0, 10) + "\nЦена: " + tour[j].price + '$';
                                markers.Markers.Add(marker);
                            }
                            else if (j == s.Length - 1)
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.red);
                                marker.ToolTipText = "Конец пути \n Город: " + s[j];
                                markers.Markers.Add(marker);
                            }
                            else
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.orange_small);
                                marker.ToolTipText = "Промежуточная остановка \n Город: " + s[j];
                                markers.Markers.Add(marker);
                            }
                            marker.Tag = tour[0].id_tour.ToString();
                            j++;
                        }
                    }
                    break;
                case 2:
                    MarinTour.Clear();
                    db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=3 AND t.status_tour='Доступен' AND t.way_tour='" + cbWay.Text.Replace("-->", "_") + "'", ref MarinTour);
                    if (MarinTour.Count > 0)
                    {
                        string[] s = MarinTour[0].way_tour.Split('_');
                        int j = 0;
                        while (j < s.Length)
                        {
                            gmap.SetPositionByKeywords(s[j]);
                            points.Add(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng));
                            if (j == 0)
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green);
                                marker.ToolTipText = "Начало пути \n Город: " + s[j] + "\nДата начала: " + MarinTour[j].date_start.Substring(0, 10) + "\nЦена: " + MarinTour[j].price + '$';
                                markers.Markers.Add(marker);
                            }
                            else if (j == s.Length - 1)
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.red);
                                marker.ToolTipText = "Конец пути \n Город: " + s[j];
                                markers.Markers.Add(marker);
                            }
                            else
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.orange_small);
                                marker.ToolTipText = "Промежуточная остановка \n Город: " + s[j];
                                markers.Markers.Add(marker);
                            }
                            marker.Tag = MarinTour[0].id_tour.ToString();
                            j++;
                        }
                    }
                    break;
                case 3:
                    ExcTour.Clear();
                    db.Execute<ClassExcursionsTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.excursions_tour, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=4 AND t.status_tour='Доступен' AND t.way_tour='"+cbWay.Text.Replace("-->","_")+"'", ref ExcTour);
                    if (ExcTour.Count > 0)
                    {
                        string[] s = ExcTour[0].way_tour.Split('_');
                        int j = 0;
                        while (j < s.Length)
                        {
                            gmap.SetPositionByKeywords(s[j]);
                            points.Add(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng));
                            if (j == 0)
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.green);
                                marker.ToolTipText = "Начало пути \n Город: " + s[j] + "\nДата начала: " + ExcTour[j].date_start.Substring(0, 10) + "\nЦена: " + ExcTour[j].price + '$';
                                markers.Markers.Add(marker);
                            }
                            else if (j == s.Length - 1)
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.red);
                                marker.ToolTipText = "Конец пути \n Город: " + s[j];
                                markers.Markers.Add(marker);
                            }
                            else
                            {
                                marker = new GMarkerGoogle(new PointLatLng(gmap.Position.Lat, gmap.Position.Lng), GMarkerGoogleType.orange_small);
                                marker.ToolTipText = "Промежуточная остановка \n Город: " + s[j];
                                markers.Markers.Add(marker);
                            }
                            marker.Tag = ExcTour[0].id_tour.ToString();
                            j++;
                        }
                    }
                    break;
            }
            GMapRoute route = new GMapRoute(points, "Way " + cbWay.SelectedText);
            route.Stroke = new Pen(Color.Red, 3);
            switch (type)
            {
                case 1:
                    route.Tag = tour[0].id_tour.ToString();
                    break;
                case 2:
                    route.Tag = MarinTour[0].id_tour.ToString();
                    break;
                case 3:
                    route.Tag = ExcTour[0].id_tour.ToString();
                    break;
            }
            routes.Routes.Add(route);
            gmap.Overlays.Add(routes);
            gmap.Overlays.Add(markers);
            gmap.SetPositionByKeywords("Ираклион");
        }


        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string[] s = item.ToolTipText.Split('\n');
            switch (type)
            {
                case 1:
                    formImgOrSale obj = new formImgOrSale(s[1].Remove(0, 7), Convert.ToInt32(item.Tag.ToString()), 0);
                    obj.ShowDialog();
                    break;
                case 2:
                    formImgOrSale obj1 = new formImgOrSale(s[1].Remove(0, 7), Convert.ToInt32(item.Tag.ToString()), 2);
                    obj1.ShowDialog();
                    break;
                case 3:
                    formImgOrSale obj3 = new formImgOrSale(s[1].Remove(0, 7), Convert.ToInt32(item.Tag.ToString()), 3);
                    obj3.ShowDialog();
                    break;
            }
        }
    }
}
