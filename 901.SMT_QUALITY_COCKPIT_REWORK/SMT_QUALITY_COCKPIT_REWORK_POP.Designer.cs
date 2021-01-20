﻿namespace FORM
{
    partial class SMT_QUALITY_COCKPIT_REWORK_POP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMT_QUALITY_COCKPIT_REWORK_POP));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.ConstantLine constantLine2 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.ConstantLine constantLine3 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            this.pnTop = new System.Windows.Forms.Panel();
            this.cmdPm1 = new System.Windows.Forms.Button();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridBand13 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.pnBody1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pnTop.SuspendLayout();
            this.pnBody1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cmdPm1);
            this.pnTop.Controls.Add(this.lblHeader);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1254, 76);
            this.pnTop.TabIndex = 2;
            // 
            // cmdPm1
            // 
            this.cmdPm1.BackColor = System.Drawing.Color.Transparent;
            this.cmdPm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPm1.BackgroundImage")));
            this.cmdPm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPm1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdPm1.FlatAppearance.BorderSize = 0;
            this.cmdPm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPm1.Font = new System.Drawing.Font("Calibri", 32.75F, System.Drawing.FontStyle.Bold);
            this.cmdPm1.ForeColor = System.Drawing.Color.Navy;
            this.cmdPm1.Location = new System.Drawing.Point(3, 3);
            this.cmdPm1.Name = "cmdPm1";
            this.cmdPm1.Size = new System.Drawing.Size(77, 70);
            this.cmdPm1.TabIndex = 88;
            this.cmdPm1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdPm1.UseVisualStyleBackColor = false;
            this.cmdPm1.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.LineVisible = true;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1622, 76);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "        Daily Rework";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gridBand13
            // 
            this.gridBand13.Name = "gridBand13";
            this.gridBand13.VisibleIndex = -1;
            // 
            // pnBody1
            // 
            this.pnBody1.Controls.Add(this.chartControl1);
            this.pnBody1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody1.Location = new System.Drawing.Point(0, 76);
            this.pnBody1.Name = "pnBody1";
            this.pnBody1.Size = new System.Drawing.Size(1254, 477);
            this.pnBody1.TabIndex = 3;
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControl1.AppearanceNameSerializable = "Chameleon";
            this.chartControl1.DataBindings = null;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisX.Title.Text = "Time";
            xyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            constantLine1.AxisValueSerializable = "6";
            constantLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            constantLine1.LineStyle.Thickness = 2;
            constantLine1.Name = "MAX";
            constantLine1.Title.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            constantLine2.AxisValueSerializable = "0";
            constantLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            constantLine2.LineStyle.Thickness = 2;
            constantLine2.Name = "MIN";
            constantLine2.Title.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            constantLine3.AxisValueSerializable = "3";
            constantLine3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            constantLine3.LineStyle.Thickness = 2;
            constantLine3.Name = "AVERAGE";
            constantLine3.Title.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] {
            constantLine1,
            constantLine2,
            constantLine3});
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisY.Title.Text = "Rework  (%)";
            xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl1.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.MarkerSize = new System.Drawing.Size(18, 12);
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Marquee";
            pointSeriesLabel1.TextPattern = "{V:#,0.##}%";
            series1.Label = pointSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Rework Rate";
            splineSeriesView1.Color = System.Drawing.Color.Blue;
            splineSeriesView1.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            splineSeriesView1.LineMarkerOptions.Size = 9;
            splineSeriesView1.LineStyle.Thickness = 3;
            splineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.View = splineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.View = splineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(1254, 477);
            this.chartControl1.TabIndex = 13;
            // 
            // SMT_QUALITY_COCKPIT_REWORK_POP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1254, 553);
            this.Controls.Add(this.pnBody1);
            this.Controls.Add(this.pnTop);
            this.Name = "SMT_QUALITY_COCKPIT_REWORK_POP";
            this.Text = "Rework Detail";
            this.Load += new System.EventHandler(this.SMT_QUALITY_COCKPIT_FORM1_Load);
            this.VisibleChanged += new System.EventHandler(this.SMT_QUALITY_COCKPIT_REWORK_POP_VisibleChanged);
            this.pnTop.ResumeLayout(false);
            this.pnBody1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        public System.Windows.Forms.Button cmdPm1;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand13;
        private System.Windows.Forms.Panel pnBody1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}