 
 
namespace NofaTextEditor
{
    partial class NoteEditor
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
        /// 
      
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteEditor));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.HTMLEditor = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CutButton = new System.Windows.Forms.ToolStripButton();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.PasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.AlignRight = new System.Windows.Forms.ToolStripButton();
            this.AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.Justify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.InsertOrderedList = new System.Windows.Forms.ToolStripButton();
            this.InsertUnorderedList = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.HTMLEditor);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(928, 493);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(928, 518);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // HTMLEditor
            // 
            this.HTMLEditor.AllowNavigation = false;
            this.HTMLEditor.AllowWebBrowserDrop = false;
            this.HTMLEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTMLEditor.IsWebBrowserContextMenuEnabled = false;
            this.HTMLEditor.Location = new System.Drawing.Point(0, 0);
            this.HTMLEditor.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.HTMLEditor.MinimumSize = new System.Drawing.Size(20, 20);
            this.HTMLEditor.Name = "HTMLEditor";
            this.HTMLEditor.ScriptErrorsSuppressed = true;
            this.HTMLEditor.Size = new System.Drawing.Size(928, 493);
            this.HTMLEditor.TabIndex = 1;
            this.HTMLEditor.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.toolStripSeparator1,
            this.BoldButton,
            this.ItalicButton,
            this.UnderlineButton,
            this.toolStripSeparator2,
            this.CutButton,
            this.CopyButton,
            this.PasteButton,
            this.toolStripSeparator3,
            this.AlignLeft,
            this.AlignRight,
            this.AlignCenter,
            this.Justify,
            this.toolStripSeparator4,
            this.InsertOrderedList,
            this.InsertUnorderedList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(928, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "toolStripButton3";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BoldButton
            // 
            this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
            this.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(23, 22);
            this.BoldButton.Text = "toolStripButton1";
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicButton.Image")));
            this.ItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(23, 22);
            this.ItalicButton.Text = "toolStripButton2";
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineButton.Image")));
            this.UnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(23, 22);
            this.UnderlineButton.Text = "toolStripButton3";
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CutButton
            // 
            this.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutButton.Image = ((System.Drawing.Image)(resources.GetObject("CutButton.Image")));
            this.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(23, 22);
            this.CutButton.Text = "toolStripButton4";
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 22);
            this.CopyButton.Text = "toolStripButton3";
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteButton.Image")));
            this.PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 22);
            this.PasteButton.Text = "toolStripButton3";
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // AlignLeft
            // 
            this.AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("AlignLeft.Image")));
            this.AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignLeft.Name = "AlignLeft";
            this.AlignLeft.Size = new System.Drawing.Size(23, 22);
            this.AlignLeft.Text = "toolStripButton3";
            this.AlignLeft.Click += new System.EventHandler(this.AlignLeft_Click);
            // 
            // AlignRight
            // 
            this.AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("AlignRight.Image")));
            this.AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignRight.Name = "AlignRight";
            this.AlignRight.Size = new System.Drawing.Size(23, 22);
            this.AlignRight.Text = "toolStripButton3";
            this.AlignRight.Click += new System.EventHandler(this.AlignRight_Click);
            // 
            // AlignCenter
            // 
            this.AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("AlignCenter.Image")));
            this.AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignCenter.Name = "AlignCenter";
            this.AlignCenter.Size = new System.Drawing.Size(23, 22);
            this.AlignCenter.Text = "toolStripButton3";
            this.AlignCenter.Click += new System.EventHandler(this.AlignCenter_Click);
            // 
            // Justify
            // 
            this.Justify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Justify.Image = ((System.Drawing.Image)(resources.GetObject("Justify.Image")));
            this.Justify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Justify.Name = "Justify";
            this.Justify.Size = new System.Drawing.Size(23, 22);
            this.Justify.Text = "toolStripButton3";
            this.Justify.Click += new System.EventHandler(this.Justify_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // InsertOrderedList
            // 
            this.InsertOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertOrderedList.Image = ((System.Drawing.Image)(resources.GetObject("InsertOrderedList.Image")));
            this.InsertOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertOrderedList.Name = "InsertOrderedList";
            this.InsertOrderedList.Size = new System.Drawing.Size(23, 22);
            this.InsertOrderedList.Text = "toolStripButton3";
            this.InsertOrderedList.Click += new System.EventHandler(this.InsertOrderedList_Click);
            // 
            // InsertUnorderedList
            // 
            this.InsertUnorderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertUnorderedList.Image = ((System.Drawing.Image)(resources.GetObject("InsertUnorderedList.Image")));
            this.InsertUnorderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertUnorderedList.Name = "InsertUnorderedList";
            this.InsertUnorderedList.Size = new System.Drawing.Size(23, 22);
            this.InsertUnorderedList.Text = "toolStripButton3";
            this.InsertUnorderedList.Click += new System.EventHandler(this.InsertUnorderedList_Click);
            // 
            // NoteEditor
            // 
            this.ClientSize = new System.Drawing.Size(928, 518);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "NoteEditor";
            this.Text = "Edit note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.WebBrowser HTMLEditor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BoldButton;
        private System.Windows.Forms.ToolStripButton ItalicButton;
        private System.Windows.Forms.ToolStripButton UnderlineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CutButton;
        private System.Windows.Forms.ToolStripButton CopyButton;
        private System.Windows.Forms.ToolStripButton PasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton AlignLeft;
        private System.Windows.Forms.ToolStripButton AlignRight;
        private System.Windows.Forms.ToolStripButton AlignCenter;
        private System.Windows.Forms.ToolStripButton Justify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton InsertOrderedList;
        private System.Windows.Forms.ToolStripButton InsertUnorderedList;




    }
}

