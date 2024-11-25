namespace Programma81
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.butTurpinat = new System.Windows.Forms.Button();
            this.butParbaudit = new System.Windows.Forms.Button();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.labKoment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "3. Kuras no nosauktajām ir republikas pilsētas?";
            // 
            // butTurpinat
            // 
            this.butTurpinat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTurpinat.Location = new System.Drawing.Point(472, 320);
            this.butTurpinat.Name = "butTurpinat";
            this.butTurpinat.Size = new System.Drawing.Size(100, 30);
            this.butTurpinat.TabIndex = 10;
            this.butTurpinat.Text = "Turpināt";
            this.butTurpinat.UseVisualStyleBackColor = true;
            this.butTurpinat.Click += new System.EventHandler(this.butTurpinat_Click);
            // 
            // butParbaudit
            // 
            this.butParbaudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butParbaudit.Location = new System.Drawing.Point(366, 320);
            this.butParbaudit.Name = "butParbaudit";
            this.butParbaudit.Size = new System.Drawing.Size(100, 30);
            this.butParbaudit.TabIndex = 9;
            this.butParbaudit.Text = "Pārbaudīt";
            this.butParbaudit.UseVisualStyleBackColor = true;
            this.butParbaudit.Click += new System.EventHandler(this.butParbaudit_Click);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check1.Location = new System.Drawing.Point(47, 83);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(91, 24);
            this.check1.TabIndex = 16;
            this.check1.Text = "Jūrmala";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check2.Location = new System.Drawing.Point(47, 124);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(92, 24);
            this.check2.TabIndex = 17;
            this.check2.Text = "Madona";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check3.Location = new System.Drawing.Point(47, 167);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(87, 24);
            this.check3.TabIndex = 18;
            this.check3.Text = "Kuldīga";
            this.check3.UseVisualStyleBackColor = true;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check4.Location = new System.Drawing.Point(47, 210);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(99, 24);
            this.check4.TabIndex = 19;
            this.check4.Text = "Rēzekne";
            this.check4.UseVisualStyleBackColor = true;
            // 
            // labKoment
            // 
            this.labKoment.AutoSize = true;
            this.labKoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKoment.Location = new System.Drawing.Point(168, 323);
            this.labKoment.Name = "labKoment";
            this.labKoment.Size = new System.Drawing.Size(95, 20);
            this.labKoment.TabIndex = 20;
            this.labKoment.Text = "Komentārs";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.labKoment);
            this.Controls.Add(this.check4);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butTurpinat);
            this.Controls.Add(this.butParbaudit);
            this.Name = "Form4";
            this.Text = "Neliels testiņš";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butTurpinat;
        private System.Windows.Forms.Button butParbaudit;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.Label labKoment;
    }
}