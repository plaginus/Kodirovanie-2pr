namespace KodirovaniePr2
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
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            amplitude = new TrackBar();
            tau1 = new TrackBar();
            tau2 = new TrackBar();
            deltaN = new TrackBar();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)amplitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tau1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tau2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deltaN).BeginInit();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.BackColor = SystemColors.ControlDark;
            plotView1.Location = new Point(0, 0);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(434, 250);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // amplitude
            // 
            amplitude.Location = new Point(0, 256);
            amplitude.Maximum = 255;
            amplitude.Name = "amplitude";
            amplitude.Size = new Size(104, 45);
            amplitude.TabIndex = 2;
            amplitude.ValueChanged += amplitude_ValueChanged;
            // 
            // tau1
            // 
            tau1.Location = new Point(110, 256);
            tau1.Maximum = 127;
            tau1.Name = "tau1";
            tau1.Size = new Size(104, 45);
            tau1.TabIndex = 3;
            tau1.ValueChanged += tau1_ValueChanged;
            // 
            // tau2
            // 
            tau2.Location = new Point(220, 256);
            tau2.Maximum = 127;
            tau2.Name = "tau2";
            tau2.Size = new Size(104, 45);
            tau2.TabIndex = 4;
            tau2.ValueChanged += tau2_ValueChanged;
            // 
            // deltaN
            // 
            deltaN.Location = new Point(330, 256);
            deltaN.Maximum = 255;
            deltaN.Name = "deltaN";
            deltaN.Size = new Size(104, 45);
            deltaN.TabIndex = 5;
            deltaN.ValueChanged += deltaN_ValueChanged;
            // 
            // plotView2
            // 
            plotView2.BackColor = SystemColors.ControlDark;
            plotView2.Location = new Point(440, 0);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(434, 250);
            plotView2.TabIndex = 6;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 286);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 7;
            label1.Text = "Амплитуда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 286);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 8;
            label2.Text = "Тау 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 286);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 9;
            label3.Text = "Тау 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 286);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Сдвиг";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 502);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(plotView2);
            Controls.Add(deltaN);
            Controls.Add(tau2);
            Controls.Add(tau1);
            Controls.Add(amplitude);
            Controls.Add(plotView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)amplitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)tau1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tau2).EndInit();
            ((System.ComponentModel.ISupportInitialize)deltaN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private TrackBar amplitude;
        private TrackBar tau1;
        private TrackBar tau2;
        private TrackBar deltaN;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
