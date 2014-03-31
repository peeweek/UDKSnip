namespace UDKSnip
{
    partial class UDKSnipForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDKSnipForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snippetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSnippetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setSnippetRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableNotifiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewSnips = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSnipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameSnipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSnipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.previewPanel = new UDKSnip.PreviewPanel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openUDKSnipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.snippetsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // snippetsToolStripMenuItem
            // 
            this.snippetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSnippetToolStripMenuItem,
            this.copyCurrentToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.setSnippetRootToolStripMenuItem,
            this.enableNotifiesToolStripMenuItem});
            this.snippetsToolStripMenuItem.Name = "snippetsToolStripMenuItem";
            this.snippetsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.snippetsToolStripMenuItem.Text = "Snippets";
            // 
            // addSnippetToolStripMenuItem
            // 
            this.addSnippetToolStripMenuItem.Name = "addSnippetToolStripMenuItem";
            this.addSnippetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.addSnippetToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addSnippetToolStripMenuItem.Text = "Add Snippet";
            this.addSnippetToolStripMenuItem.Click += new System.EventHandler(this.addSnippetVFXArtistOnlyToolStripMenuItem_Click);
            // 
            // copyCurrentToolStripMenuItem
            // 
            this.copyCurrentToolStripMenuItem.Name = "copyCurrentToolStripMenuItem";
            this.copyCurrentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyCurrentToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.copyCurrentToolStripMenuItem.Text = "Copy Current";
            this.copyCurrentToolStripMenuItem.Click += new System.EventHandler(this.copyCurrentToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // setSnippetRootToolStripMenuItem
            // 
            this.setSnippetRootToolStripMenuItem.Name = "setSnippetRootToolStripMenuItem";
            this.setSnippetRootToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.setSnippetRootToolStripMenuItem.Text = "Set Snippet Root";
            this.setSnippetRootToolStripMenuItem.Click += new System.EventHandler(this.setSnippetRootToolStripMenuItem_Click);
            // 
            // enableNotifiesToolStripMenuItem
            // 
            this.enableNotifiesToolStripMenuItem.Name = "enableNotifiesToolStripMenuItem";
            this.enableNotifiesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.enableNotifiesToolStripMenuItem.Text = "Enable Notifies";
            this.enableNotifiesToolStripMenuItem.Click += new System.EventHandler(this.enableNotifiesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.previewPanel);
            this.splitContainer1.Size = new System.Drawing.Size(864, 346);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.treeViewSnips);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Actor Snippets (F5 to Refresh)";
            // 
            // treeViewSnips
            // 
            this.treeViewSnips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSnips.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeViewSnips.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSnips.ImageIndex = 0;
            this.treeViewSnips.ImageList = this.imageList;
            this.treeViewSnips.Location = new System.Drawing.Point(10, 21);
            this.treeViewSnips.Name = "treeViewSnips";
            this.treeViewSnips.SelectedImageIndex = 0;
            this.treeViewSnips.Size = new System.Drawing.Size(259, 310);
            this.treeViewSnips.TabIndex = 1;
            this.treeViewSnips.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSnips_AfterSelect);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSnipToolStripMenuItem,
            this.renameSnipToolStripMenuItem,
            this.deleteSnipToolStripMenuItem});
            this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(144, 70);
            // 
            // editSnipToolStripMenuItem
            // 
            this.editSnipToolStripMenuItem.Name = "editSnipToolStripMenuItem";
            this.editSnipToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editSnipToolStripMenuItem.Text = "Edit Snip";
            this.editSnipToolStripMenuItem.Click += new System.EventHandler(this.editSnipToolStripMenuItem_Click);
            // 
            // renameSnipToolStripMenuItem
            // 
            this.renameSnipToolStripMenuItem.Name = "renameSnipToolStripMenuItem";
            this.renameSnipToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.renameSnipToolStripMenuItem.Text = "Rename Snip";
            this.renameSnipToolStripMenuItem.Click += new System.EventHandler(this.renameSnipToolStripMenuItem_Click);
            // 
            // deleteSnipToolStripMenuItem
            // 
            this.deleteSnipToolStripMenuItem.Name = "deleteSnipToolStripMenuItem";
            this.deleteSnipToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deleteSnipToolStripMenuItem.Text = "Delete Snip";
            this.deleteSnipToolStripMenuItem.Click += new System.EventHandler(this.deleteSnipToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Folder");
            this.imageList.Images.SetKeyName(1, "FolderOpen");
            this.imageList.Images.SetKeyName(2, "Snip");
            this.imageList.Images.SetKeyName(3, "112_RightArrowLong_Green_16x16_72.png");
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.Location = new System.Drawing.Point(0, 0);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(579, 346);
            this.previewPanel.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "You can access";
            this.notifyIcon.BalloonTipTitle = "UDKSnip is Still Running";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "UDKSnip";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUDKSnipToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(158, 48);
            // 
            // openUDKSnipToolStripMenuItem
            // 
            this.openUDKSnipToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openUDKSnipToolStripMenuItem.Name = "openUDKSnipToolStripMenuItem";
            this.openUDKSnipToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openUDKSnipToolStripMenuItem.Text = "&Open UDKSnip";
            this.openUDKSnipToolStripMenuItem.Click += new System.EventHandler(this.openUDKSnipToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.Filter = "*.snip";
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // UDKSnipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(864, 370);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 400);
            this.Name = "UDKSnipForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDKSnip v0.9b : a collaborative Copy/Paste Bin for Unreal Development Kit.";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UDKSnipForm_FormClosing);
            this.Load += new System.EventHandler(this.UDKSnipForm_Load);
            this.Resize += new System.EventHandler(this.CopyPasteFXForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.contextMenuStripTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snippetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSnippetToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem copyCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private PreviewPanel previewPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.ToolStripMenuItem openUDKSnipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TreeView treeViewSnips;
        private System.Windows.Forms.ToolStripMenuItem setSnippetRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableNotifiesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem deleteSnipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSnipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameSnipToolStripMenuItem;
    }
}

