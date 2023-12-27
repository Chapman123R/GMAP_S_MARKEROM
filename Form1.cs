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
            gMap.DragButton = MouseButtons.Left;      //перемещение карты
            gMap.MapProvider = GMapProviders.GoogleMap;

            double lat = Convert.ToDouble(txtLat1.Text); //широта
            double lng = Convert.ToDouble(txtLng1.Text);  //долгота

            gMap.Position = new PointLatLng(lat, lng); // устанавливаем позицию на карте используя полученные значения широты и долготы
            gMap.MinZoom = 5; //минимальный
            gMap.MaxZoom = 100;
            gMap.Zoom = 10; //текущий
            gMap.MapScaleInfoEnabled = true; // выводится информация о маштабе карты


            //вид маркера Москвы
            PointLatLng pointMoscow = new PointLatLng(lat, lng); // устанавливаем координаты Москвы
            Bitmap makrImgMoscow = (Bitmap)Image.FromFile("markers/flag1.png"); // загружаем изображение маркера Москвы
            GMapMarker mrMoscow = new GMarkerGoogle(pointMoscow, makrImgMoscow);
            mrMoscow.ToolTipText = "(Moscow)";


            //добавляем созданный маркер на карту
            GMapOverlay markers = new GMapOverlay("Moscow");
            markers.Markers.Add(mrMoscow);

            //вывод на карте
            gMap.Overlays.Add(markers);


            lat = Convert.ToDouble(txtLat2.Text); // получаем значение широты из другого текстового поля и преобразуем его в тип double
            lng = Convert.ToDouble(txtLng2.Text); // получаем значение долготы из другого текстового поля и преобразуем его в тип double
            PointLatLng pointTula = new PointLatLng(lat, lng); // устанавливаем координаты Тулы
            Bitmap makrImgTula = (Bitmap)Image.FromFile("markers/shrek.png"); // загружаем изображение маркера Тулы
            GMapMarker mrTula = new GMarkerGoogle(pointTula, makrImgTula);
            mrTula.ToolTipText = "(Tula)";


            //добавляем созданный маркер на карту
            markers = new GMapOverlay("Tula");
            markers.Markers.Add(mrTula);

            //вывод на карте
            gMap.Overlays.Add(markers);



        }
    }
}