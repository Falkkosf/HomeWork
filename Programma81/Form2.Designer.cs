namespace Programma81
{
    partial class Form2
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
            this.butParbaudit = new System.Windows.Forms.Button();
            this.butTurpinat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.labKoment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butParbaudit
            // 
            this.butParbaudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butParbaudit.Location = new System.Drawing.Point(366, 319);
            this.butParbaudit.Name = "butParbaudit";
            this.butParbaudit.Size = new System.Drawing.Size(100, 30);
            this.butParbaudit.TabIndex = 2;
            this.butParbaudit.Text = "Pārbaudīt";
            this.butParbaudit.UseVisualStyleBackColor = true;
            this.butParbaudit.Click += new System.EventHandler(this.butParbaudit_Click);
            // 
            // butTurpinat
            // 
            this.butTurpinat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTurpinat.Location = new System.Drawing.Point(472, 319);
            this.butTurpinat.Name = "butTurpinat";
            this.butTurpinat.Size = new System.Drawing.Size(100, 30);
            this.butTurpinat.TabIndex = 3;
            this.butTurpinat.Text = "Turpināt";
            this.butTurpinat.UseVisualStyleBackColor = true;
            this.butTurpinat.Click += new System.EventHandler(this.butTurpinat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. Kur atrodas Gaiziņkalns?";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(47, 82);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(39, 24);
            this.radio1.TabIndex = 5;
            this.radio1.TabStop = true;
            this.radio1.Text = "A";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(47, 125);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(39, 24);
            this.radio2.TabIndex = 7;
            this.radio2.TabStop = true;
            this.radio2.Text = "B";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.Location = new System.Drawing.Point(47, 172);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(39, 24);
            this.radio3.TabIndex = 8;
            this.radio3.TabStop = true;
            this.radio3.Text = "C";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Programma81.Properties.Resources.att1;
            this.pictureBox1.Location = new System.Drawing.Point(172, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 270);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio4.Location = new System.Drawing.Point(47, 220);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(40, 24);
            this.radio4.TabIndex = 9;
            this.radio4.TabStop = true;
            this.radio4.Text = "D";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // labKoment
            // 
            this.labKoment.AutoSize = true;
            this.labKoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKoment.Location = new System.Drawing.Point(168, 323);
            this.labKoment.Name = "labKoment";
            this.labKoment.Size = new System.Drawing.Size(95, 20);
            this.labKoment.TabIndex = 10;
            this.labKoment.Text = "Komentārs";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.labKoment);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butTurpinat);
            this.Controls.Add(this.butParbaudit);
            this.Name = "Form2";
            this.Text = "Neliels tests";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butParbaudit;
        private System.Windows.Forms.Button butTurpinat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.Label labKoment;
    }
}