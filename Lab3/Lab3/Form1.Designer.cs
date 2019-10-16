namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.R0TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pi2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pi1TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(280, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(870, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "m";
            // 
            // mTextBox
            // 
            this.mTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTextBox.Location = new System.Drawing.Point(943, 243);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(116, 38);
            this.mTextBox.TabIndex = 2;
            this.mTextBox.Text = "61121";
            // 
            // aTextBox
            // 
            this.aTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aTextBox.Location = new System.Drawing.Point(943, 363);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(116, 38);
            this.aTextBox.TabIndex = 4;
            this.aTextBox.Text = "211";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(870, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "a";
            // 
            // R0TextBox
            // 
            this.R0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R0TextBox.Location = new System.Drawing.Point(943, 303);
            this.R0TextBox.Name = "R0TextBox";
            this.R0TextBox.Size = new System.Drawing.Size(116, 38);
            this.R0TextBox.TabIndex = 6;
            this.R0TextBox.Text = "319";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(870, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "R0";
            // 
            // pi2TextBox
            // 
            this.pi2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pi2TextBox.Location = new System.Drawing.Point(302, 89);
            this.pi2TextBox.Name = "pi2TextBox";
            this.pi2TextBox.Size = new System.Drawing.Size(207, 38);
            this.pi2TextBox.TabIndex = 8;
            this.pi2TextBox.Text = "0.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(230, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "π2";
            // 
            // pi1TextBox
            // 
            this.pi1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pi1TextBox.Location = new System.Drawing.Point(302, 28);
            this.pi1TextBox.Name = "pi1TextBox";
            this.pi1TextBox.Size = new System.Drawing.Size(207, 38);
            this.pi1TextBox.TabIndex = 10;
            this.pi1TextBox.Text = "0.6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(229, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "π1";
            // 
            // LLabel
            // 
            this.LLabel.AutoSize = true;
            this.LLabel.BackColor = System.Drawing.Color.Transparent;
            this.LLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LLabel.Location = new System.Drawing.Point(427, 382);
            this.LLabel.Name = "LLabel";
            this.LLabel.Size = new System.Drawing.Size(29, 31);
            this.LLabel.TabIndex = 22;
            this.LLabel.Text = "0";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.BackColor = System.Drawing.Color.Transparent;
            this.WLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WLabel.Location = new System.Drawing.Point(427, 331);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(29, 31);
            this.WLabel.TabIndex = 21;
            this.WLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(296, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wоч";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(296, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lоч";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.BackColor = System.Drawing.Color.Transparent;
            this.ALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ALabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ALabel.Location = new System.Drawing.Point(427, 277);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(29, 31);
            this.ALabel.TabIndex = 18;
            this.ALabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(303, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 485);
            this.Controls.Add(this.LLabel);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pi1TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pi2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.R0TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ЛР4 - Арабей, 651001";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox R0TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pi2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pi1TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label label6;
    }
}

