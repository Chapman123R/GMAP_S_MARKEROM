using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowCity_Click(object sender, EventArgs e)
        {
            gMap.DragButton = MouseButtons.Left;      //����������� �����
            gMap.MapProvider = GMapProviders.GoogleMap;

            double lat = Convert.ToDouble(txtLat1.Text); //������
            double lng = Convert.ToDouble(txtLng1.Text);  //�������

            gMap.Position = new PointLatLng(lat, lng); // ������������� ������� �� ����� ��������� ���������� �������� ������ � �������
            gMap.MinZoom = 5; //�����������
            gMap.MaxZoom = 100;
            gMap.Zoom = 10; //�������
            gMap.MapScaleInfoEnabled = true; // ��������� ���������� � ������� �����


            //��� ������� ������
            PointLatLng pointMoscow = new PointLatLng(lat, lng); // ������������� ���������� ������
            Bitmap makrImgMoscow = (Bitmap)Image.FromFile("markers/flag1.png"); // ��������� ����������� ������� ������
            GMapMarker mrMoscow = new GMarkerGoogle(pointMoscow, makrImgMoscow);
            mrMoscow.ToolTipText = "(Moscow)";


            //��������� ��������� ������ �� �����
            GMapOverlay markers = new GMapOverlay("Moscow");
            markers.Markers.Add(mrMoscow);

            //����� �� �����
            gMap.Overlays.Add(markers);


            lat = Convert.ToDouble(txtLat2.Text); // �������� �������� ������ �� ������� ���������� ���� � ����������� ��� � ��� double
            lng = Convert.ToDouble(txtLng2.Text); // �������� �������� ������� �� ������� ���������� ���� � ����������� ��� � ��� double
            PointLatLng pointTula = new PointLatLng(lat, lng); // ������������� ���������� ����
            Bitmap makrImgTula = (Bitmap)Image.FromFile("markers/shrek.png"); // ��������� ����������� ������� ����
            GMapMarker mrTula = new GMarkerGoogle(pointTula, makrImgTula);
            mrTula.ToolTipText = "(Tula)";


            //��������� ��������� ������ �� �����
            markers = new GMapOverlay("Tula");
            markers.Markers.Add(mrTula);

            //����� �� �����
            gMap.Overlays.Add(markers);



        }
    }
}