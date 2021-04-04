using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.FixedPoint
{
    public partial class MainFixedPoint : UserControl
    {

        public static int temp = 0;
        public string status;
        public Bitmap tmpMarker;
        public Bitmap newImage;


        public FixedPointEvent handler;
        private static MainForm mainInstance = MainForm.GetInstance();
        private GMapControl map = mainInstance.GetmainMap();

        public static Dictionary<GMapMarker, MarkerDetail> markers = new Dictionary<GMapMarker, MarkerDetail>();
        public static event EventHandler DeleteEvent;
        public MainFixedPoint()
        {
            handler = FixedPointEvent.Instance;
            InitializeComponent();
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            tmpMarker = (Bitmap)Image.FromFile("images/026-police station.png");

            if (rdbTactical.Checked == true)
            {
                status = rdbTactical.Text;
            }
            else if (rdbMRadar.Checked == true)
            {
                status = rdbMRadar.Text;
            }
            else if (rdbFRadar.Checked == true)
            {
                status = rdbFRadar.Text;
            }
            else if (rdbOBSPost.Checked == true)
            {
                status = rdbOBSPost.Text;
            }
            else if (rdbSpecial.Checked == true)
            {
                status = rdbSpecial.Text;
            }


            try
            {
                newImage = ResizeBitmap(tmpMarker, 30, 30);
                PointLatLng point = new PointLatLng(GlobalFixedPoint.Lat, GlobalFixedPoint.Lng);
                var marker = new GMarkerGoogle(point, newImage);
                GMapOverlay overlay = MainForm.GetInstance().GetOverlay("markersP");
                MarkerDetail detail = new MarkerDetail();

                string markerDetail = "\n"
                    + "Number : " + txtNumber.Text.ToString() + "\n"
                    + "Label : " + txtLabel.Text.ToString() + "\n"
                    + "Type : " + status + "\n"
                    + "Location : " + txtLocation.Text.ToString() + "\n"
                    + "Remark : " + txtRemark.Text.ToString();
                string Number = txtNumber.Text.ToString();
                string Label = txtLabel.Text.ToString();
                string Location = point.Lat.ToString() + ", " + point.Lng.ToString();
                string Remark = txtRemark.Text;

                detail.id = temp;
                //detail.name = txtDetail.Text + System.Environment.NewLine + "za";
                detail.name = markerDetail;


                markers.Add(marker, detail);

                marker.Tag = temp += 1;
                marker.ToolTipText = markerDetail;
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;


                FixedPointTag.tag.Add(Convert.ToInt32(marker.Tag));

                FixedPointList.Number.Add(Number);
                FixedPointList.Label.Add(Label);
                FixedPointList.Status.Add(status);
                FixedPointList.Location.Add(Location);
                FixedPointList.Remark.Add(Remark);
                FixedPointList.Tag.Add(Convert.ToInt32(marker.Tag));

                overlay.Markers.Add(marker);
                map.Overlays.Add(overlay);

                txtLocation.Text = "";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

            //var Mykey = markers.FirstOrDefault(x => x.Value.id == 0).Key;
            //MessageBox.Show(Mykey.ToString());
        }

        public Bitmap ResizeBitmap(Bitmap bmpMarker, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmpMarker, 0, 0, width, height);
            }

            return result;
        }

        private void MainFixedPoint_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            handler.onFixedPointChanged += new FixedPointChanged(Changed);
            mainInstance.RaiseDelete += MainInstance_RaiseDelete;
            mainInstance.ClearScreen += MainInstance_ClearScreen;
        }
        private void MainInstance_RaiseDelete(object sender, int e)
        {
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            txtNumber.Text = FixedPointList.Number[e];
            txtLabel.Text = FixedPointList.Label[e];

            if (FixedPointList.Status[e] == "Tactical")
            {
                rdbTactical.Checked = true;
            }
            else if (FixedPointList.Status[e] == "M-Radar")
            {
                rdbMRadar.Checked = true;
            }
            else if (FixedPointList.Status[e] == "F-Radar")
            {
                rdbFRadar.Checked = true;
            }
            else if (FixedPointList.Status[e] == "OBS Post")
            {
                rdbOBSPost.Checked = true;
            }
            else if (FixedPointList.Status[e] == "Special")
            {
                rdbSpecial.Checked = true;
            }

            txtRemark.Text = FixedPointList.Remark[e];
        }
        public void MainInstance_ClearScreen(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtLabel.Text = "";
            rdbTactical.Checked = false;
            rdbMRadar.Checked = false;
            rdbFRadar.Checked = false;
            rdbOBSPost.Checked = false;
            rdbSpecial.Checked = false;
            txtRemark.Text = "";
            btnDelete.Visible = false;
            btnEdit.Visible = false;
        }
        private void Changed(FixedPointEventArgs args)
        {
            txtLocation.Text = GlobalFixedPoint.LatLng;
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
