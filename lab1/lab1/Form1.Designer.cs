namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.R0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sigma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.La = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(817, 37);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(169, 22);
            this.A.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "A = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "m = ";
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(817, 78);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(169, 22);
            this.M.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "R0 = ";
            // 
            // R0
            // 
            this.R0.Location = new System.Drawing.Point(817, 118);
            this.R0.Name = "R0";
            this.R0.Size = new System.Drawing.Size(169, 22);
            this.R0.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mx = ";
            // 
            // Mx
            // 
            this.Mx.Location = new System.Drawing.Point(817, 274);
            this.Mx.Name = "Mx";
            this.Mx.Size = new System.Drawing.Size(169, 22);
            this.Mx.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dx = ";
            // 
            // Dx
            // 
            this.Dx.Location = new System.Drawing.Point(817, 317);
            this.Dx.Name = "Dx";
            this.Dx.Size = new System.Drawing.Size(169, 22);
            this.Dx.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "sigma = ";
            // 
            // Sigma
            // 
            this.Sigma.Location = new System.Drawing.Point(817, 362);
            this.Sigma.Name = "Sigma";
            this.Sigma.Size = new System.Drawing.Size(169, 22);
            this.Sigma.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "p = ";
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(817, 407);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(169, 22);
            this.p.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "La = ";
            // 
            // La
            // 
            this.La.Location = new System.Drawing.Point(817, 450);
            this.La.Name = "La";
            this.La.Size = new System.Drawing.Size(169, 22);
            this.La.TabIndex = 14;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(774, 186);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(245, 38);
            this.start.TabIndex = 16;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ci";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(746, 529);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(771, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "2k/n =";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(817, 494);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(169, 22);
            this.check.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 528);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.check);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.La);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.p);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sigma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.R0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.M);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox R0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Dx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sigma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox La;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox check;
    }
}

