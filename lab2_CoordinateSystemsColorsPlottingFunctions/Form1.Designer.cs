﻿
namespace lab2_CoordinateSystemsColorsPlottingFunctions
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pixels = new System.Windows.Forms.Button();
            this.Millimeters = new System.Windows.Forms.Button();
            this.Inches = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pixels
            // 
            this.Pixels.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pixels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pixels.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pixels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pixels.Location = new System.Drawing.Point(13, 21);
            this.Pixels.Margin = new System.Windows.Forms.Padding(4);
            this.Pixels.Name = "Pixels";
            this.Pixels.Size = new System.Drawing.Size(100, 58);
            this.Pixels.TabIndex = 1;
            this.Pixels.Text = "Pixels";
            this.Pixels.UseVisualStyleBackColor = false;
            this.Pixels.Click += new System.EventHandler(this.Pixels_Click);
            // 
            // Millimeters
            // 
            this.Millimeters.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Millimeters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Millimeters.Dock = System.Windows.Forms.DockStyle.Right;
            this.Millimeters.Location = new System.Drawing.Point(113, 21);
            this.Millimeters.Margin = new System.Windows.Forms.Padding(4);
            this.Millimeters.Name = "Millimeters";
            this.Millimeters.Size = new System.Drawing.Size(100, 58);
            this.Millimeters.TabIndex = 2;
            this.Millimeters.Text = "Millimeters";
            this.Millimeters.UseVisualStyleBackColor = false;
            this.Millimeters.Click += new System.EventHandler(this.Millimeters_Click);
            // 
            // Inches
            // 
            this.Inches.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Inches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inches.Dock = System.Windows.Forms.DockStyle.Right;
            this.Inches.Location = new System.Drawing.Point(213, 21);
            this.Inches.Margin = new System.Windows.Forms.Padding(4);
            this.Inches.Name = "Inches";
            this.Inches.Size = new System.Drawing.Size(100, 58);
            this.Inches.TabIndex = 3;
            this.Inches.Text = "Inches";
            this.Inches.UseVisualStyleBackColor = false;
            this.Inches.Click += new System.EventHandler(this.Inches_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.Clear.Location = new System.Drawing.Point(313, 21);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 58);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Pixels);
            this.groupBox1.Controls.Add(this.Millimeters);
            this.groupBox1.Controls.Add(this.Inches);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Location = new System.Drawing.Point(929, 638);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 12);
            this.groupBox1.Size = new System.Drawing.Size(420, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1364, 743);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pixels;
        private System.Windows.Forms.Button Millimeters;
        private System.Windows.Forms.Button Inches;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

