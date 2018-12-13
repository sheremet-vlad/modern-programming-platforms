using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Xsl;
using System.IO;

namespace RssReader
{
    public partial class Form1 : Form
    {
        string flFName = "feed_list.log"; // список лент, на которые мы подписались 
        Rss rss; // текущая RSS-лента 
        SaveFileDialog sfd1 = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        void LoadFeed(string URL)
        {
            try
            {
                rss = new Rss(URL);
                wbIE.Navigate(Application.StartupPath + "\\" + rss.TransformToHTML());
            }
            catch (System.Net.WebException exc)
            {
                MessageBox.Show(exc.Message, " Нет подключения к интернету ");
            }
        }

        void UpdateFeedListFile()
        {
            string bak_file = "feed_list.bak";
            try
            {
                if (File.Exists(bak_file)) File.Delete(bak_file);
                File.Move(flFName, bak_file);
                if (File.Exists(flFName)) File.Delete(flFName);
                foreach (string item in lbFeeds.Items)
                    File.AppendAllText(flFName, item + "\n");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void LbRSSClick(object sender, EventArgs e)
        {
            tbFeedURL.Text = lbFeeds.SelectedItem.ToString();
        }

        // показать ленту 
        void LbRSSDoubleClick(object sender, EventArgs e)
        {
            tbFeedURL.Text = lbFeeds.SelectedItem.ToString();
            LoadFeed(tbFeedURL.Text);
        }

        //добавить ленту в подписку 
        void bNewClick(object sender, EventArgs e)
        {
            if (tbFeedURL.Text.Length > 0)
            {
                string newURL = tbFeedURL.Text.Trim();
                lbFeeds.Items.Add(newURL);
                File.AppendAllText(flFName, newURL + "\n");
            }
        }
        //изменить адрес ленты в подписке 
        void BEditClick(object sender, EventArgs e)
        {
            lbFeeds.Items[lbFeeds.SelectedIndex] = tbFeedURL.Text.Trim();
            UpdateFeedListFile();
        }

        //удалить ленту из подписки 
        void BDeleteClick(object sender, EventArgs e)
        {
            int idx = lbFeeds.SelectedIndex;
            lbFeeds.Items.RemoveAt(idx);
            if (idx >= lbFeeds.Items.Count) idx--;
            if (idx >= 0) lbFeeds.SetSelected(idx, true);
            UpdateFeedListFile();
        }

        // сохранить текущую ленту 
        void SaveAsHTMLToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (sfd1.ShowDialog() == DialogResult.OK)
                File.Move(Application.StartupPath + "\feed.html", sfd1.FileName);
        }


    }
}
