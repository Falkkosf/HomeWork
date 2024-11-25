namespace rāsu_kombinētājs
{
    partial class Main
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
            this.button_ApplyChange = new System.Windows.Forms.Button();
            this.button_ChooseColor = new System.Windows.Forms.Button();
            this.pictureBox_ColorPreview = new System.Windows.Forms.PictureBox();
            this.panelColors = new System.Windows.Forms.Panel();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonColorApplyText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorPreview)).BeginInit();
            this.panelColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ApplyChange
            // 
            this.button_ApplyChange.Location = new System.Drawing.Point(534, 351);
            this.button_ApplyChange.Name = "button_ApplyChange";
            this.button_ApplyChange.Size = new System.Drawing.Size(169, 82);
            this.button_ApplyChange.TabIndex = 0;
            this.button_ApplyChange.Text = "Apply Color To BackGound";
            this.button_ApplyChange.UseVisualStyleBackColor = true;
            this.button_ApplyChange.Click += new System.EventHandler(this.button_ApplyChange_Click);
            // 
            // button_ChooseColor
            // 
            this.button_ChooseColor.Location = new System.Drawing.Point(155, 293);
            this.button_ChooseColor.Name = "button_ChooseColor";
            this.button_ChooseColor.Size = new System.Drawing.Size(156, 82);
            this.button_ChooseColor.TabIndex = 1;
            this.button_ChooseColor.Text = "Show Colors";
            this.button_ChooseColor.UseVisualStyleBackColor = true;
            this.button_ChooseColor.Click += new System.EventHandler(this.button_ChooseColor_Click);
            // 
            // pictureBox_ColorPreview
            // 
            this.pictureBox_ColorPreview.Location = new System.Drawing.Point(336, 293);
            this.pictureBox_ColorPreview.Name = "pictureBox_ColorPreview";
            this.pictureBox_ColorPreview.Size = new System.Drawing.Size(156, 76);
            this.pictureBox_ColorPreview.TabIndex = 2;
            this.pictureBox_ColorPreview.TabStop = false;
            this.pictureBox_ColorPreview.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelColors
            // 
            this.panelColors.Controls.Add(this.buttonBlue);
            this.panelColors.Controls.Add(this.buttonGreen);
            this.panelColors.Controls.Add(this.buttonRed);
            this.panelColors.Controls.Add(this.buttonWhite);
            this.panelColors.Controls.Add(this.buttonBlack);
            this.panelColors.Location = new System.Drawing.Point(155, 34);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(420, 223);
            this.panelColors.TabIndex = 3;
            this.panelColors.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(0, 3);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(87, 62);
            this.buttonBlack.TabIndex = 0;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(93, 3);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(87, 62);
            this.buttonWhite.TabIndex = 1;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Maroon;
            this.buttonRed.Location = new System.Drawing.Point(200, 3);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(87, 62);
            this.buttonRed.TabIndex = 2;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGreen.Location = new System.Drawing.Point(312, 3);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(87, 62);
            this.buttonGreen.TabIndex = 3;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonBlue.Location = new System.Drawing.Point(3, 83);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(87, 62);
            this.buttonBlue.TabIndex = 4;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preview Color";
            // 
            // buttonColorApplyText
            // 
            this.buttonColorApplyText.Location = new System.Drawing.Point(534, 263);
            this.buttonColorApplyText.Name = "buttonColorApplyText";
            this.buttonColorApplyText.Size = new System.Drawing.Size(169, 82);
            this.buttonColorApplyText.TabIndex = 5;
            this.buttonColorApplyText.Text = "Apply Color To Text";
            this.buttonColorApplyText.UseVisualStyleBackColor = true;
            this.buttonColorApplyText.Click += new System.EventHandler(this.buttonColorApplyText_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonColorApplyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelColors);
            this.Controls.Add(this.pictureBox_ColorPreview);
            this.Controls.Add(this.button_ChooseColor);
            this.Controls.Add(this.button_ApplyChange);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorPreview)).EndInit();
            this.panelColors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ApplyChange;
        private System.Windows.Forms.Button button_ChooseColor;
        private System.Windows.Forms.PictureBox pictureBox_ColorPreview;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonColorApplyText;
    }
}