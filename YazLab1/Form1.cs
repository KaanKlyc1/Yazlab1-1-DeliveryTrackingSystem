using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace YazLab1
{
    public partial class Form1 : Form
    {
        public List<PointLatLng> points;
        public Form1()
        {
            
            InitializeComponent();
           
        }
        static Bağlantı con = new Bağlantı();
        Dictionary<string, Sipariş> siparişler;
       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyDxUEZtroae7yU6vHxw9qOPuUCXpLKHV90";
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config);
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı.");
            }
            points = new List<PointLatLng>();
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = false;
            map.Position = new PointLatLng(40.7659693389566, 29.9286139011383);//CUMHURİYET PARKI
            PointLatLng baş = new PointLatLng(40.7659693389566, 29.9286139011383);
            points.Add(baş);
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 16;

            veriAl();
            
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                txtLat.Text = lat + "";
                txtLon.Text = lng + "";
            }
        }

        private async void veriAl()
        {
            try
            {
                var response = await con.client.GetAsync("Siparişler");
                siparişler = response.ResultAs<Dictionary<string, Sipariş>>();
                if(siparişler != null)
                {
                    foreach (var sipariş in siparişler)
                    {
                        if (sipariş.Value.TeslimDurum == "Teslim Edilmedi")
                        {
                            PointLatLng point = new PointLatLng(sipariş.Value.MüşteriEnlem, sipariş.Value.MüşteriBoylam);
                           
                            points.Add(point);

                        }
                    }
                    for (int i = 0; i < points.Count; i++)
                    {
                        GMapOverlay markers = new GMapOverlay("markers");
                        if (i == 0)
                        {
                            GMapMarker markerbaş = new GMarkerGoogle(points[i], GMarkerGoogleType.blue);
                            markers.Markers.Add(markerbaş);
                            map.Overlays.Add(markers);
                        }
                        else
                        {
                            GMapMarker marker = new GMarkerGoogle(points[i], GMarkerGoogleType.red);
                            markers.Markers.Add(marker);
                            map.Overlays.Add(markers);
                        }
                            
                    }

                    MapRoute route;
                    GMapRoute r;
                    GMapOverlay routes;
                    // SELECTION SORT
                    double tempdis1= 0;
                    double tempdis2= 0;
                    for(int i = 0; i< points.Count-1;i++)
                    {
                        int min = i + 1;
                        for (int j = i+1; j<points.Count;j++)
                        {
                            if (points[j] != null)
                            {
                                route = GoogleMapProvider.Instance.GetRoute(points[i], points[j], true, false, 14);
                                if (j >= i + 2)
                                {
                                    tempdis2 = route.Distance;
                                }
                                else
                                {
                                    tempdis1 = route.Distance;
                                }
                                if (tempdis2!=0 && tempdis2 < tempdis1)
                                {
                                    min = j; 
                                    tempdis1 = tempdis2;
                                }
                                
                            }
                        }
                        PointLatLng temp = points[min];
                        points[min] = points[i + 1];
                        points[i + 1] = temp;
                    }
                  

                    for (int i = 0; i < points.Count-1 ; i++)
                    {
                        if (points[i + 1] != null)
                        {
                            route = GoogleMapProvider.Instance.GetRoute(points[i], points[i + 1], true, false, 14);
                            r = new GMapRoute(route.Points, "My Route")
                            {
                                Stroke = new Pen(Color.Red, 5)
                            };

                            routes = new GMapOverlay("routes");
                            routes.Routes.Add(r);
                            map.Overlays.Add(routes);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata");
            }
            
            
        }


    }
}
