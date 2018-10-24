namespace PhotoEditor
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.angleField = new System.Windows.Forms.TextBox();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.scaleField = new System.Windows.Forms.TextBox();
            this.scaleToGrayButton = new System.Windows.Forms.Button();
            this.ContrastButton = new System.Windows.Forms.Button();
            this.ContrastBar = new System.Windows.Forms.TrackBar();
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.DrawCheckBox = new System.Windows.Forms.CheckBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(12, 55);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(75, 23);
            this.rotateButton.TabIndex = 2;
            this.rotateButton.Text = "rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // angleField
            // 
            this.angleField.Location = new System.Drawing.Point(106, 58);
            this.angleField.Name = "angleField";
            this.angleField.Size = new System.Drawing.Size(35, 20);
            this.angleField.TabIndex = 3;
            this.angleField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angleField_KeyPress);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Location = new System.Drawing.Point(12, 96);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(75, 23);
            this.ResizeButton.TabIndex = 4;
            this.ResizeButton.Text = "resize";
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // scaleField
            // 
            this.scaleField.Location = new System.Drawing.Point(106, 98);
            this.scaleField.Name = "scaleField";
            this.scaleField.Size = new System.Drawing.Size(35, 20);
            this.scaleField.TabIndex = 5;
            // 
            // scaleToGrayButton
            // 
            this.scaleToGrayButton.Location = new System.Drawing.Point(12, 139);
            this.scaleToGrayButton.Name = "scaleToGrayButton";
            this.scaleToGrayButton.Size = new System.Drawing.Size(75, 23);
            this.scaleToGrayButton.TabIndex = 6;
            this.scaleToGrayButton.Text = "scale to gray";
            this.scaleToGrayButton.UseVisualStyleBackColor = true;
            this.scaleToGrayButton.Click += new System.EventHandler(this.ToGrayScale_Click);
            // 
            // ContrastButton
            // 
            this.ContrastButton.Location = new System.Drawing.Point(12, 185);
            this.ContrastButton.Name = "ContrastButton";
            this.ContrastButton.Size = new System.Drawing.Size(129, 23);
            this.ContrastButton.TabIndex = 7;
            this.ContrastButton.Text = "contrast and brightness";
            this.ContrastButton.UseVisualStyleBackColor = true;
            this.ContrastButton.Click += new System.EventHandler(this.ContrastButton_Click);
            // 
            // ContrastBar
            // 
            this.ContrastBar.Location = new System.Drawing.Point(12, 237);
            this.ContrastBar.Name = "ContrastBar";
            this.ContrastBar.Size = new System.Drawing.Size(60, 45);
            this.ContrastBar.TabIndex = 8;
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(81, 237);
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(60, 45);
            this.BrightnessBar.TabIndex = 9;
            // 
            // DrawCheckBox
            // 
            this.DrawCheckBox.AutoSize = true;
            this.DrawCheckBox.Location = new System.Drawing.Point(13, 289);
            this.DrawCheckBox.Name = "DrawCheckBox";
            this.DrawCheckBox.Size = new System.Drawing.Size(49, 17);
            this.DrawCheckBox.TabIndex = 10;
            this.DrawCheckBox.Text = "draw";
            this.DrawCheckBox.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(211, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(561, 426);
            this.PictureBox1.TabIndex = 11;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.DrawCheckBox);
            this.Controls.Add(this.BrightnessBar);
            this.Controls.Add(this.ContrastBar);
            this.Controls.Add(this.ContrastButton);
            this.Controls.Add(this.scaleToGrayButton);
            this.Controls.Add(this.scaleField);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.angleField);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "rotate";
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.TextBox angleField;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.TextBox scaleField;
        private System.Windows.Forms.Button scaleToGrayButton;
        private System.Windows.Forms.Button ContrastButton;
        private System.Windows.Forms.TrackBar ContrastBar;
        private System.Windows.Forms.TrackBar BrightnessBar;
        private System.Windows.Forms.CheckBox DrawCheckBox;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}

