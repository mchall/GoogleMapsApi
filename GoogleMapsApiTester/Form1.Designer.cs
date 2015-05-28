namespace GoogleMapsApiTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPolygonTest = new System.Windows.Forms.Button();
            this.btnGeocoding1 = new System.Windows.Forms.Button();
            this.btnGeocoding2 = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCenter = new System.Windows.Forms.Label();
            this.btnMarker2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLastEvent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgPolygon = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoundedGeocoding = new System.Windows.Forms.Button();
            this.btnGeocoding3 = new System.Windows.Forms.Button();
            this.txtGeocoding = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMarker1 = new System.Windows.Forms.Button();
            this.pgMarker = new System.Windows.Forms.PropertyGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbShowInfoWindow = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.pgMapOptions = new System.Windows.Forms.PropertyGrid();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMapTest = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbLimitMap = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPolygonTest
            // 
            this.btnPolygonTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPolygonTest.Location = new System.Drawing.Point(3, 210);
            this.btnPolygonTest.Name = "btnPolygonTest";
            this.btnPolygonTest.Size = new System.Drawing.Size(279, 34);
            this.btnPolygonTest.TabIndex = 1;
            this.btnPolygonTest.Text = "Polygon test";
            this.btnPolygonTest.UseVisualStyleBackColor = true;
            this.btnPolygonTest.Click += new System.EventHandler(this.PolygonTest_Click);
            // 
            // btnGeocoding1
            // 
            this.btnGeocoding1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeocoding1.Location = new System.Drawing.Point(3, 16);
            this.btnGeocoding1.Name = "btnGeocoding1";
            this.btnGeocoding1.Size = new System.Drawing.Size(279, 31);
            this.btnGeocoding1.TabIndex = 2;
            this.btnGeocoding1.Text = "Find Newlands";
            this.btnGeocoding1.UseVisualStyleBackColor = true;
            this.btnGeocoding1.Click += new System.EventHandler(this.GeocodingTest1_Click);
            // 
            // btnGeocoding2
            // 
            this.btnGeocoding2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeocoding2.Location = new System.Drawing.Point(3, 47);
            this.btnGeocoding2.Name = "btnGeocoding2";
            this.btnGeocoding2.Size = new System.Drawing.Size(279, 32);
            this.btnGeocoding2.TabIndex = 3;
            this.btnGeocoding2.Text = "Find Dean Street";
            this.btnGeocoding2.UseVisualStyleBackColor = true;
            this.btnGeocoding2.Click += new System.EventHandler(this.GeocodingTest2_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(82, 11);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(44, 13);
            this.lblZoom.TabIndex = 4;
            this.lblZoom.Text = "<zoom>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Center:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ZOOM:";
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Location = new System.Drawing.Point(466, 11);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(49, 13);
            this.lblCenter.TabIndex = 7;
            this.lblCenter.Text = "<center>";
            // 
            // btnMarker2
            // 
            this.btnMarker2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarker2.Location = new System.Drawing.Point(3, 185);
            this.btnMarker2.Name = "btnMarker2";
            this.btnMarker2.Size = new System.Drawing.Size(279, 28);
            this.btnMarker2.TabIndex = 8;
            this.btnMarker2.Text = "Custom Icon Marker";
            this.btnMarker2.UseVisualStyleBackColor = true;
            this.btnMarker2.Click += new System.EventHandler(this.MarkerTest2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLastEvent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblZoom);
            this.panel1.Controls.Add(this.lblCenter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 765);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 43);
            this.panel1.TabIndex = 9;
            // 
            // lblLastEvent
            // 
            this.lblLastEvent.AutoSize = true;
            this.lblLastEvent.Location = new System.Drawing.Point(969, 10);
            this.lblLastEvent.Name = "lblLastEvent";
            this.lblLastEvent.Size = new System.Drawing.Size(65, 13);
            this.lblLastEvent.TabIndex = 9;
            this.lblLastEvent.Text = "<last event>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(888, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Event:";
            // 
            // pgPolygon
            // 
            this.pgPolygon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgPolygon.HelpVisible = false;
            this.pgPolygon.Location = new System.Drawing.Point(3, 16);
            this.pgPolygon.Name = "pgPolygon";
            this.pgPolygon.Size = new System.Drawing.Size(279, 194);
            this.pgPolygon.TabIndex = 10;
            this.pgPolygon.ToolbarVisible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPolygonTest);
            this.groupBox1.Controls.Add(this.pgPolygon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 264);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Polygon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBoundedGeocoding);
            this.groupBox2.Controls.Add(this.btnGeocoding3);
            this.groupBox2.Controls.Add(this.txtGeocoding);
            this.groupBox2.Controls.Add(this.btnGeocoding2);
            this.groupBox2.Controls.Add(this.btnGeocoding1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 197);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geocoding";
            // 
            // btnBoundedGeocoding
            // 
            this.btnBoundedGeocoding.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoundedGeocoding.Location = new System.Drawing.Point(3, 130);
            this.btnBoundedGeocoding.Name = "btnBoundedGeocoding";
            this.btnBoundedGeocoding.Size = new System.Drawing.Size(279, 31);
            this.btnBoundedGeocoding.TabIndex = 6;
            this.btnBoundedGeocoding.Text = "Bounded Geocoding";
            this.btnBoundedGeocoding.UseVisualStyleBackColor = true;
            this.btnBoundedGeocoding.Click += new System.EventHandler(this.GeocodingTest4_Click);
            // 
            // btnGeocoding3
            // 
            this.btnGeocoding3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeocoding3.Location = new System.Drawing.Point(3, 99);
            this.btnGeocoding3.Name = "btnGeocoding3";
            this.btnGeocoding3.Size = new System.Drawing.Size(279, 31);
            this.btnGeocoding3.TabIndex = 5;
            this.btnGeocoding3.Text = "Custom Geocoding";
            this.btnGeocoding3.UseVisualStyleBackColor = true;
            this.btnGeocoding3.Click += new System.EventHandler(this.GeocodingTest3_Click);
            // 
            // txtGeocoding
            // 
            this.txtGeocoding.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGeocoding.Location = new System.Drawing.Point(3, 79);
            this.txtGeocoding.Name = "txtGeocoding";
            this.txtGeocoding.Size = new System.Drawing.Size(279, 20);
            this.txtGeocoding.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMarker2);
            this.groupBox3.Controls.Add(this.btnMarker1);
            this.groupBox3.Controls.Add(this.pgMarker);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 226);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Markers";
            // 
            // btnMarker1
            // 
            this.btnMarker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarker1.Location = new System.Drawing.Point(3, 157);
            this.btnMarker1.Name = "btnMarker1";
            this.btnMarker1.Size = new System.Drawing.Size(279, 28);
            this.btnMarker1.TabIndex = 12;
            this.btnMarker1.Text = "Marker test";
            this.btnMarker1.UseVisualStyleBackColor = true;
            this.btnMarker1.Click += new System.EventHandler(this.MarkerTest1_Click);
            // 
            // pgMarker
            // 
            this.pgMarker.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgMarker.HelpVisible = false;
            this.pgMarker.Location = new System.Drawing.Point(3, 16);
            this.pgMarker.Name = "pgMarker";
            this.pgMarker.Size = new System.Drawing.Size(279, 141);
            this.pgMarker.TabIndex = 11;
            this.pgMarker.ToolbarVisible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbShowInfoWindow);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 687);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 52);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "InfoWindow";
            // 
            // cbShowInfoWindow
            // 
            this.cbShowInfoWindow.AutoSize = true;
            this.cbShowInfoWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbShowInfoWindow.Location = new System.Drawing.Point(3, 16);
            this.cbShowInfoWindow.Name = "cbShowInfoWindow";
            this.cbShowInfoWindow.Size = new System.Drawing.Size(279, 17);
            this.cbShowInfoWindow.TabIndex = 0;
            this.cbShowInfoWindow.Text = "Show info window on map click";
            this.cbShowInfoWindow.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 765);
            this.panel2.TabIndex = 15;
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(564, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScrollBarsEnabled = false;
            this.browser.Size = new System.Drawing.Size(753, 765);
            this.browser.TabIndex = 16;
            // 
            // pgMapOptions
            // 
            this.pgMapOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgMapOptions.HelpVisible = false;
            this.pgMapOptions.Location = new System.Drawing.Point(3, 16);
            this.pgMapOptions.Name = "pgMapOptions";
            this.pgMapOptions.Size = new System.Drawing.Size(273, 194);
            this.pgMapOptions.TabIndex = 17;
            this.pgMapOptions.ToolbarVisible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMapTest);
            this.groupBox5.Controls.Add(this.pgMapOptions);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 264);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Map Options";
            // 
            // btnMapTest
            // 
            this.btnMapTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMapTest.Location = new System.Drawing.Point(3, 210);
            this.btnMapTest.Name = "btnMapTest";
            this.btnMapTest.Size = new System.Drawing.Size(273, 34);
            this.btnMapTest.TabIndex = 17;
            this.btnMapTest.Text = "Map test";
            this.btnMapTest.UseVisualStyleBackColor = true;
            this.btnMapTest.Click += new System.EventHandler(this.MapTest_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(285, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 765);
            this.panel3.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbLimitMap);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 264);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(279, 58);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Limit map region";
            // 
            // cbLimitMap
            // 
            this.cbLimitMap.AutoSize = true;
            this.cbLimitMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLimitMap.Location = new System.Drawing.Point(3, 16);
            this.cbLimitMap.Name = "cbLimitMap";
            this.cbLimitMap.Size = new System.Drawing.Size(273, 17);
            this.cbLimitMap.TabIndex = 0;
            this.cbLimitMap.Text = "Limit map to South Africa and surroundings?";
            this.cbLimitMap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 808);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPolygonTest;
        private System.Windows.Forms.Button btnGeocoding1;
        private System.Windows.Forms.Button btnGeocoding2;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.Button btnMarker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PropertyGrid pgPolygon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGeocoding3;
        private System.Windows.Forms.TextBox txtGeocoding;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PropertyGrid pgMarker;
        private System.Windows.Forms.Button btnMarker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbShowInfoWindow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.PropertyGrid pgMapOptions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnMapTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLastEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoundedGeocoding;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbLimitMap;
    }
}

