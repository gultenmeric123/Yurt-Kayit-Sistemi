﻿namespace YurtKayitSistemi
{
    partial class FrmGelirIstatistik
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label1 = new System.Windows.Forms.Label();
			this.LblPara = new System.Windows.Forms.Label();
			this.CmbAy = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LblAyKazanc = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(760, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kasadaki Para:";
			// 
			// LblPara
			// 
			this.LblPara.AutoSize = true;
			this.LblPara.BackColor = System.Drawing.Color.Transparent;
			this.LblPara.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPara.Location = new System.Drawing.Point(943, 18);
			this.LblPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblPara.Name = "LblPara";
			this.LblPara.Size = new System.Drawing.Size(27, 30);
			this.LblPara.TabIndex = 1;
			this.LblPara.Text = "0";
			// 
			// CmbAy
			// 
			this.CmbAy.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CmbAy.FormattingEnabled = true;
			this.CmbAy.Location = new System.Drawing.Point(309, 15);
			this.CmbAy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CmbAy.Name = "CmbAy";
			this.CmbAy.Size = new System.Drawing.Size(225, 38);
			this.CmbAy.TabIndex = 2;
			this.CmbAy.SelectedIndexChanged += new System.EventHandler(this.CmbAy_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(167, 18);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ay Seçiniz:";
			// 
			// LblAyKazanc
			// 
			this.LblAyKazanc.AutoSize = true;
			this.LblAyKazanc.BackColor = System.Drawing.Color.Transparent;
			this.LblAyKazanc.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAyKazanc.Location = new System.Drawing.Point(943, 62);
			this.LblAyKazanc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblAyKazanc.Name = "LblAyKazanc";
			this.LblAyKazanc.Size = new System.Drawing.Size(27, 30);
			this.LblAyKazanc.TabIndex = 5;
			this.LblAyKazanc.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(803, 62);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 30);
			this.label4.TabIndex = 4;
			this.label4.Text = "Seçilen Ay:";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Aylık";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(172, 256);
			this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Aylık";
			series1.Name = "Aylık";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(728, 283);
			this.chart1.TabIndex = 6;
			this.chart1.Text = "chart1";
			// 
			// FrmGelirIstatistik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Linen;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.LblAyKazanc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CmbAy);
			this.Controls.Add(this.LblPara);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmGelirIstatistik";
			this.Text = "Gelir Istatistik";
			this.Load += new System.EventHandler(this.FrmGelirIstatistik_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPara;
        private System.Windows.Forms.ComboBox CmbAy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAyKazanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}