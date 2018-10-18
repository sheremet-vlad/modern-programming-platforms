namespace WinFormsFileSorter
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
            this.buttonFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelLoadFile = new System.Windows.Forms.Label();
            this.labelSortName = new System.Windows.Forms.Label();
            this.textBoxSortName = new System.Windows.Forms.TextBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFile.Location = new System.Drawing.Point(120, 132);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(103, 27);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "Choose file";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.Location = new System.Drawing.Point(12, 132);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(102, 27);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelLoadFile
            // 
            this.labelLoadFile.AutoSize = true;
            this.labelLoadFile.Location = new System.Drawing.Point(14, 107);
            this.labelLoadFile.Name = "labelLoadFile";
            this.labelLoadFile.Size = new System.Drawing.Size(0, 13);
            this.labelLoadFile.TabIndex = 2;
            // 
            // labelSortName
            // 
            this.labelSortName.AutoSize = true;
            this.labelSortName.Location = new System.Drawing.Point(12, 35);
            this.labelSortName.Name = "labelSortName";
            this.labelSortName.Size = new System.Drawing.Size(82, 13);
            this.labelSortName.TabIndex = 3;
            this.labelSortName.Text = "Result file name";
            // 
            // textBoxSortName
            // 
            this.textBoxSortName.Location = new System.Drawing.Point(15, 51);
            this.textBoxSortName.Name = "textBoxSortName";
            this.textBoxSortName.Size = new System.Drawing.Size(208, 20);
            this.textBoxSortName.TabIndex = 6;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptions.Location = new System.Drawing.Point(93, 9);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(57, 17);
            this.labelOptions.TabIndex = 7;
            this.labelOptions.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 171);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.textBoxSortName);
            this.Controls.Add(this.labelSortName);
            this.Controls.Add(this.labelLoadFile);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonFile);
            this.Name = "Form1";
            this.Text = "Text Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelLoadFile;
        private System.Windows.Forms.Label labelSortName;
        private System.Windows.Forms.TextBox textBoxSortName;
        private System.Windows.Forms.Label labelOptions;
    }
}


