namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gMap = new GMap.NET.WindowsForms.GMapControl();
            panel1 = new Panel();
            label4 = new Label();
            txtLng2 = new TextBox();
            txtLat2 = new TextBox();
            btnShowCity = new Button();
            txtLng1 = new TextBox();
            txtLat1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gMap
            // 
            gMap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gMap.Bearing = 0F;
            gMap.CanDragMap = true;
            gMap.EmptyTileColor = Color.Navy;
            gMap.GrayScaleMode = false;
            gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMap.LevelsKeepInMemory = 5;
            gMap.Location = new Point(5, 8);
            gMap.MarkersEnabled = true;
            gMap.MaxZoom = 2;
            gMap.MinZoom = 2;
            gMap.MouseWheelZoomEnabled = true;
            gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMap.Name = "gMap";
            gMap.NegativeMode = false;
            gMap.PolygonsEnabled = true;
            gMap.RetryLoadTile = 0;
            gMap.RoutesEnabled = true;
            gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMap.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMap.ShowTileGridLines = false;
            gMap.Size = new Size(531, 433);
            gMap.TabIndex = 0;
            gMap.Zoom = 0D;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtLng2);
            panel1.Controls.Add(txtLat2);
            panel1.Controls.Add(btnShowCity);
            panel1.Controls.Add(txtLng1);
            panel1.Controls.Add(txtLat1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(542, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 433);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 92);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Тула";
            // 
            // txtLng2
            // 
            txtLng2.Location = new Point(166, 92);
            txtLng2.Name = "txtLng2";
            txtLng2.Size = new Size(66, 23);
            txtLng2.TabIndex = 7;
            txtLng2.Text = "37,61587";
            // 
            // txtLat2
            // 
            txtLat2.Location = new Point(84, 92);
            txtLat2.Name = "txtLat2";
            txtLat2.Size = new Size(66, 23);
            txtLat2.TabIndex = 6;
            txtLat2.Text = "54,19383";
            // 
            // btnShowCity
            // 
            btnShowCity.Location = new Point(86, 153);
            btnShowCity.Name = "btnShowCity";
            btnShowCity.Size = new Size(158, 40);
            btnShowCity.TabIndex = 5;
            btnShowCity.Text = "Показать";
            btnShowCity.UseVisualStyleBackColor = true;
            btnShowCity.Click += btnShowCity_Click;
            // 
            // txtLng1
            // 
            txtLng1.Location = new Point(166, 51);
            txtLng1.Name = "txtLng1";
            txtLng1.Size = new Size(66, 23);
            txtLng1.TabIndex = 4;
            txtLng1.Text = "37,611662";
            // 
            // txtLat1
            // 
            txtLat1.Location = new Point(84, 51);
            txtLat1.Name = "txtLat1";
            txtLat1.Size = new Size(66, 23);
            txtLat1.TabIndex = 3;
            txtLat1.Text = "55,747417";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 18);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Долгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 18);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 52);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Moscow";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(gMap);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnShowCity;
        private TextBox txtLng1;
        private TextBox txtLat1;
        private Label label4;
        private TextBox txtLng2;
        private TextBox txtLat2;
    }
}