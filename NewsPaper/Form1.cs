using NewsPaper.Properties;
using RSS_Reader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NewsPaper
{
    public partial class Form1 : Form
    {
        XmlTextReader rssReader;
        XmlDocument rssDoc;
        XmlNode nodeRss;
        XmlNode nodeChannel;
        XmlNode nodeItem;
        ListViewItem rowNews;

        public Form1()
        {
            InitializeComponent();
        }

        string url ="";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.url == ""){

                url = "http://www.datarar.com/feed";
                pictureBox1.ImageLocation = Application.StartupPath + "\\images\\datarar.png";
                Guncelle();
            }
            else
            {

                url = Settings.Default.url;
                pictureBox1.ImageLocation = Settings.Default.urlImage;
                Guncelle();

            }
            
        }

        private void Guncelle()
        {
            lstNews.Items.Clear();
            this.Cursor = Cursors.WaitCursor;
            // Create a new XmlTextReader from the specified URL (RSS feed)
            rssReader = new XmlTextReader(url);
            rssDoc = new XmlDocument();
            // Load the XML content into a XmlDocument
            rssDoc.Load(rssReader);

            // Loop for the <rss> tag
            for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
            {
                // If it is the rss tag
                if (rssDoc.ChildNodes[i].Name == "rss")
                {
                    // <rss> tag found
                    nodeRss = rssDoc.ChildNodes[i];
                }
            }

            // Loop for the <channel> tag
            for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
            {
                // If it is the channel tag
                if (nodeRss.ChildNodes[i].Name == "channel")
                {
                    // <channel> tag found
                    nodeChannel = nodeRss.ChildNodes[i];
                }
            }

            // // Set the labels with information from inside the nodes
            //lblTitle.Text = "Title: " + nodeChannel["title"].InnerText;
            //lblLanguage.Text = "Language: " + nodeChannel["language"].InnerText;
            //  lblLink.Text = "Link: " + nodeChannel["link"].InnerText;
            //  lblDescription.Text = "Description: " + nodeChannel["description"].InnerText;

            // Loop for the <title>, <link>, <description> and all the other tags
            for (int i = 0; i < nodeChannel.ChildNodes.Count; i++)
            {
                // If it is the item tag, then it has children tags which we will add as items to the ListView
                if (nodeChannel.ChildNodes[i].Name == "item")
                {
                    nodeItem = nodeChannel.ChildNodes[i];

                    // Create a new row in the ListView containing information from inside the nodes
                    rowNews = new ListViewItem();
                    rowNews.Text = nodeItem["title"].InnerText;
                    rowNews.SubItems.Add(nodeItem["link"].InnerText);
                    lstNews.Items.Add(rowNews);
                }
            }

            this.Cursor = Cursors.Default;

        }

        private void lstNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When an items is selected //
            if (lstNews.SelectedItems.Count == 1)
            {
                // Loop through all the nodes under <channel>
                for (int i = 0; i < nodeChannel.ChildNodes.Count; i++)
                {
                    // Until you find the <item> node
                    if (nodeChannel.ChildNodes[i].Name == "item")
                    {
                        // Store the item as a node
                        nodeItem = nodeChannel.ChildNodes[i];
                        // If the <title> tag matches the current selected item
                        if (nodeItem["title"].InnerText == lstNews.SelectedItems[0].Text)
                        {
                            // It's the item we were looking for, get the description
                            txtContent.Text = nodeItem["description"].InnerText;
                            txtContent.Text = HtmlRemoval.StripTagsRegex(nodeItem["description"].InnerText).ToString();
                            txtContent.Text = HtmlRemoval.StripTagsRegexCompiled(nodeItem["description"].InnerText).ToString();
                            txtContent.Text = HtmlRemoval.StripTagsCharArray(nodeItem["description"].InnerText).ToString();
                            // We don't need to loop anymore
                            break;
                        }
                    }
                }
            }
        }


        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
             pictureBox1.ImageLocation = Application.StartupPath + "\\images\\milliyet.png";
             url = "http://www.milliyet.com.tr/D/rss/rss/RssSD.xml";
             Settings.Default.url = url;
             Settings.Default.urlImage = pictureBox1.ImageLocation;
             Settings.Default.Save();
             Guncelle();
        }

        private void sabahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\hurriyet.png";
            url = "http://rss.hurriyet.com.tr/rss.aspx?sectionId=1";
            Settings.Default.url = url;
            Settings.Default.urlImage = pictureBox1.ImageLocation;
            Settings.Default.Save();
            Guncelle();
        }

        private void vatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\zaman.png";
            url = "http://www.zaman.com.tr/sondakika.rss";
            Settings.Default.url = url;
            Settings.Default.urlImage = pictureBox1.ImageLocation;
            Settings.Default.Save();
            Guncelle();
        }

    }
}
