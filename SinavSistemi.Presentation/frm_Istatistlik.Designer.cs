namespace SinavSistemi.Presentation
{
    partial class frm_Istatistlik
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.chrt_sinav = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_sinav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // chrt_sinav
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chrt_sinav.Diagram = xyDiagram1;
            this.chrt_sinav.Legend.Name = "Default Legend";
            this.chrt_sinav.Location = new System.Drawing.Point(14, 36);
            this.chrt_sinav.Name = "chrt_sinav";
            series1.Name = "chrt_Sinav";
            this.chrt_sinav.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chrt_sinav.Size = new System.Drawing.Size(462, 200);
            this.chrt_sinav.TabIndex = 0;
            // 
            // frm_Istatistlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 436);
            this.Controls.Add(this.chrt_sinav);
            this.Name = "frm_Istatistlik";
            this.Text = "frm_Istatistlik";
            this.Load += new System.EventHandler(this.frm_Istatistlik_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_sinav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chrt_sinav;
    }
}