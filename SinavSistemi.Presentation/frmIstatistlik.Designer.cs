namespace SinavSistemi.Presentation
{
    partial class frmIstatistlik
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIstatistlik));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.btn_GenelIstatistik = new MetroFramework.Controls.MetroButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_İstatistikGetir = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Sinavlar = new System.Windows.Forms.ComboBox();
            this.chrt_sinav = new DevExpress.XtraCharts.ChartControl();
            this.tbn_Cikis = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_sinav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbn_Cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_GenelIstatistik
            // 
            this.btn_GenelIstatistik.Location = new System.Drawing.Point(22, 283);
            this.btn_GenelIstatistik.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GenelIstatistik.Name = "btn_GenelIstatistik";
            this.btn_GenelIstatistik.Size = new System.Drawing.Size(117, 57);
            this.btn_GenelIstatistik.TabIndex = 12;
            this.btn_GenelIstatistik.Text = "Genel İstatistik Getir";
            this.btn_GenelIstatistik.UseSelectable = true;
            this.btn_GenelIstatistik.Click += new System.EventHandler(this.btn_GenelIstatistik_Click_1);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(187, 242);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "sinav_Istatistik";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(393, 197);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // btn_İstatistikGetir
            // 
            this.btn_İstatistikGetir.Location = new System.Drawing.Point(22, 92);
            this.btn_İstatistikGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_İstatistikGetir.Name = "btn_İstatistikGetir";
            this.btn_İstatistikGetir.Size = new System.Drawing.Size(117, 46);
            this.btn_İstatistikGetir.TabIndex = 10;
            this.btn_İstatistikGetir.Text = "İstatistik Getir";
            this.btn_İstatistikGetir.UseSelectable = true;
            this.btn_İstatistikGetir.Click += new System.EventHandler(this.btn_İstatistikGetir_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sınav Numarası :";
            // 
            // cmb_Sinavlar
            // 
            this.cmb_Sinavlar.FormattingEnabled = true;
            this.cmb_Sinavlar.Location = new System.Drawing.Point(22, 50);
            this.cmb_Sinavlar.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Sinavlar.Name = "cmb_Sinavlar";
            this.cmb_Sinavlar.Size = new System.Drawing.Size(114, 21);
            this.cmb_Sinavlar.TabIndex = 8;
            // 
            // chrt_sinav
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chrt_sinav.Diagram = xyDiagram2;
            this.chrt_sinav.Legend.Name = "Default Legend";
            this.chrt_sinav.Location = new System.Drawing.Point(187, 8);
            this.chrt_sinav.Name = "chrt_sinav";
            series4.Name = "chrt_Sinav";
            this.chrt_sinav.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chrt_sinav.Size = new System.Drawing.Size(393, 200);
            this.chrt_sinav.TabIndex = 7;
            // 
            // tbn_Cikis
            // 
            this.tbn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.tbn_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("tbn_Cikis.Image")));
            this.tbn_Cikis.ImageActive = null;
            this.tbn_Cikis.Location = new System.Drawing.Point(688, -2);
            this.tbn_Cikis.Name = "tbn_Cikis";
            this.tbn_Cikis.Size = new System.Drawing.Size(56, 42);
            this.tbn_Cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tbn_Cikis.TabIndex = 13;
            this.tbn_Cikis.TabStop = false;
            this.tbn_Cikis.Zoom = 10;
            this.tbn_Cikis.Click += new System.EventHandler(this.tbn_Cikis_Click);
            // 
            // frmIstatistlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(741, 470);
            this.Controls.Add(this.tbn_Cikis);
            this.Controls.Add(this.btn_GenelIstatistik);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_İstatistikGetir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Sinavlar);
            this.Controls.Add(this.chrt_sinav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIstatistlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIstatistlik";
            this.Load += new System.EventHandler(this.frmIstatistlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_sinav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbn_Cikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private MetroFramework.Controls.MetroButton btn_GenelIstatistik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton btn_İstatistikGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Sinavlar;
        private DevExpress.XtraCharts.ChartControl chrt_sinav;
        private ns1.BunifuImageButton tbn_Cikis;
    }
}