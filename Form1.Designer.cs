namespace AsciiArt
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
            this.picture = new System.Windows.Forms.Label();
            this.sizeSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.charPick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture.Location = new System.Drawing.Point(12, 9);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(677, 500);
            this.picture.TabIndex = 1;
            this.picture.Text = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM";
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            // 
            // sizeSlider
            // 
            this.sizeSlider.Location = new System.Drawing.Point(12, 526);
            this.sizeSlider.Maximum = 3;
            this.sizeSlider.Minimum = 1;
            this.sizeSlider.Name = "sizeSlider";
            this.sizeSlider.Size = new System.Drawing.Size(79, 45);
            this.sizeSlider.TabIndex = 2;
            this.sizeSlider.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BRUSH SIZE";
            // 
            // charPick
            // 
            this.charPick.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charPick.Location = new System.Drawing.Point(122, 526);
            this.charPick.Name = "charPick";
            this.charPick.Size = new System.Drawing.Size(40, 26);
            this.charPick.TabIndex = 4;
            this.charPick.Text = "M";
            this.charPick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.charPick.TextChanged += new System.EventHandler(this.charPick_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHARACTER";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(194, 512);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(278, 50);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "COPY TO CLIPBOARD";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(194, 568);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 26);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(287, 570);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(185, 26);
            this.fillButton.TabIndex = 5;
            this.fillButton.Text = "FILL WITH \'M\'";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(478, 512);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(211, 84);
            this.loadImageButton.TabIndex = 6;
            this.loadImageButton.Text = "LOAD IMAGE FILE";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 607);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.charPick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeSlider);
            this.Controls.Add(this.picture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label picture;
        private System.Windows.Forms.TrackBar sizeSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox charPick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button loadImageButton;
    }
}

