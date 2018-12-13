namespace RssReader
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
            this.components = new System.ComponentModel.Container();
            this.lbFeeds = new System.Windows.Forms.ListBox();
            this.wbIE = new System.Windows.Forms.WebBrowser();
            this.tbFeedURL = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFeeds
            // 
            this.lbFeeds.FormattingEnabled = true;
            this.lbFeeds.Location = new System.Drawing.Point(1, 51);
            this.lbFeeds.Name = "lbFeeds";
            this.lbFeeds.Size = new System.Drawing.Size(205, 303);
            this.lbFeeds.TabIndex = 0;
            this.lbFeeds.Click += new System.EventHandler(this.LbRSSClick);
            this.lbFeeds.DoubleClick += new System.EventHandler(this.LbRSSDoubleClick);
            // 
            // wbIE
            // 
            this.wbIE.Location = new System.Drawing.Point(212, 0);
            this.wbIE.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbIE.Name = "wbIE";
            this.wbIE.Size = new System.Drawing.Size(587, 452);
            this.wbIE.TabIndex = 1;
            // 
            // tbFeedURL
            // 
            this.tbFeedURL.Location = new System.Drawing.Point(12, 372);
            this.tbFeedURL.Name = "tbFeedURL";
            this.tbFeedURL.Size = new System.Drawing.Size(176, 20);
            this.tbFeedURL.TabIndex = 2;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(12, 415);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(41, 23);
            this.bNew.TabIndex = 3;
            this.bNew.Text = "new";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNewClick);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(59, 415);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(45, 23);
            this.bEdit.TabIndex = 4;
            this.bEdit.Text = "edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.BEditClick);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(110, 415);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(47, 23);
            this.bDelete.TabIndex = 5;
            this.bDelete.Text = "delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.BDeleteClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 26);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(164, 415);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(42, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.SaveAsHTMLToolStripMenuItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.tbFeedURL);
            this.Controls.Add(this.wbIE);
            this.Controls.Add(this.lbFeeds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFeeds;
        private System.Windows.Forms.WebBrowser wbIE;
        private System.Windows.Forms.TextBox tbFeedURL;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button bSave;
    }
}

