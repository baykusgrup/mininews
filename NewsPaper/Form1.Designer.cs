namespace NewsPaper
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.milliyetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNews = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 46);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(89, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.milliyetToolStripMenuItem,
            this.sabahToolStripMenuItem,
            this.vatanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
            // 
            // milliyetToolStripMenuItem
            // 
            this.milliyetToolStripMenuItem.Name = "milliyetToolStripMenuItem";
            this.milliyetToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.milliyetToolStripMenuItem.Text = "Milliyet";
            this.milliyetToolStripMenuItem.Click += new System.EventHandler(this.milliyetToolStripMenuItem_Click);
            // 
            // sabahToolStripMenuItem
            // 
            this.sabahToolStripMenuItem.Name = "sabahToolStripMenuItem";
            this.sabahToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sabahToolStripMenuItem.Text = "Hürriyet";
            this.sabahToolStripMenuItem.Click += new System.EventHandler(this.sabahToolStripMenuItem_Click);
            // 
            // vatanToolStripMenuItem
            // 
            this.vatanToolStripMenuItem.Name = "vatanToolStripMenuItem";
            this.vatanToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vatanToolStripMenuItem.Text = "Zaman";
            this.vatanToolStripMenuItem.Click += new System.EventHandler(this.vatanToolStripMenuItem_Click);
            // 
            // lstNews
            // 
            this.lstNews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle});
            this.lstNews.FullRowSelect = true;
            this.lstNews.Location = new System.Drawing.Point(0, 52);
            this.lstNews.MultiSelect = false;
            this.lstNews.Name = "lstNews";
            this.lstNews.Size = new System.Drawing.Size(303, 196);
            this.lstNews.TabIndex = 4;
            this.lstNews.UseCompatibleStateImageBehavior = false;
            this.lstNews.View = System.Windows.Forms.View.Details;
            this.lstNews.SelectedIndexChanged += new System.EventHandler(this.lstNews_SelectedIndexChanged);
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 300;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(0, 254);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(303, 161);
            this.txtContent.TabIndex = 5;
            this.txtContent.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 415);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lstNews);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstNews;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem milliyetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatanToolStripMenuItem;
    }
}

