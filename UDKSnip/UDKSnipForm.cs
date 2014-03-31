/*=============================================================================================
            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
                    Version 2, December 2004

 Everyone is permitted to copy and distribute verbatim or modified
 copies of this license document, and changing it is allowed as long
 as the name is changed.

            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

  0. You just DO WHAT THE FUCK YOU WANT TO.

	NON-WARRANTY CLAUSE:
	This program is free software. It comes without any warranty, to
	the extent permitted by applicable law. You can redistribute it
	and/or modify it under the terms of the Do What The Fuck You Want
	To Public License, Version 2, as published by Sam Hocevar. See
	http://www.wtfpl.net/ for more details. 
 * =============================================================================================
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UDKSnip
{
    public partial class UDKSnipForm : Form
    {
        private bool bHasAlreadySeenMinimizeNotify;
        public UDKSnipForm()
        {
            InitializeComponent();
            LoadSnippets();
            fileSystemWatcher.Path = Settings.SnippetPath;
            this.bHasAlreadySeenMinimizeNotify = false;
            if (Settings.EnableNotifies)
            {
                enableNotifiesToolStripMenuItem.Checked = true;
                fileSystemWatcher.EnableRaisingEvents = true;
            }
            else
            {
                enableNotifiesToolStripMenuItem.Checked = false;
                fileSystemWatcher.EnableRaisingEvents = false;
            } 
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }


        private void addSnippetVFXArtistOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSnippetForm v_Form = new AddSnippetForm(this);
            v_Form.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSnippets();
        }

        public void LoadSnippets()
        {

            string[] files = Directory.GetFiles(Settings.SnippetPath, "*.snip");

            // TREEVIEW
            treeViewSnips.Nodes.Clear();
            treeViewSnips.Nodes.Add("UDK Snips", "UDK Snips", 3, 3);
            
            foreach (string file in files)
            {
                TreeViewAddFile(GetOnlySnippetName(file));
            }
            treeViewSnips.Nodes[0].Expand();
            treeViewSnips.SelectedNode = treeViewSnips.Nodes[0];

        }

        private TreeNode GenerateTreeNodeSnip(string p_Label, string p_SnipName)
        {
            TreeNode v_Node = new TreeNode(p_Label);
            v_Node.ImageIndex = 2;
            v_Node.SelectedImageIndex = 2;
            v_Node.Tag = p_SnipName;
            return v_Node;
        }
        private void TreeViewAddFile(string p_SnippetName)
        {
            char[] separator = { '.' };
            string[] names = p_SnippetName.Split(separator);
            AddTreeViewNode(names, p_SnippetName, treeViewSnips.Nodes[0]);
        }
        private string[] RemoveFirstEntry(string[] p_list)
        {
            string[] v_out = new string[p_list.Length - 1];

            for (int i = 1; i < p_list.Length; i++)
            {
                v_out[i - 1] = p_list[i];    
            }

            return v_out;
        }
        private void AddTreeViewNode(string[] hierarchy, string p_SnippetName, TreeNode p_Root)
        {
            if (hierarchy.Length > 1) // Folder
            {
                if (p_Root.Nodes.ContainsKey(hierarchy[0]))
                {

                    AddTreeViewNode(RemoveFirstEntry(hierarchy), p_SnippetName, p_Root.Nodes[hierarchy[0]]);
                }
                else
                {
                   
                    p_Root.Nodes.Add(hierarchy[0], hierarchy[0], 0, 0);
                    AddTreeViewNode(RemoveFirstEntry(hierarchy), p_SnippetName, p_Root.Nodes[hierarchy[0]]);
                }
            }
            else // Snippet 
            {
                p_Root.Nodes.Add(GenerateTreeNodeSnip(hierarchy[0], p_SnippetName));
            }
        }
        private string GetOnlySnippetName(string p_FullPath)
        {
            char[] separator = { '\\' } ;
            string[] splitted = p_FullPath.Split(separator);
            string v_FileName = splitted[splitted.Length - 1];
            return v_FileName.Substring(0, v_FileName.Length - 5);
            
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyCurrentSnip();
        }
        private void CopyCurrentSnip()
        {
            notifyIcon.ShowBalloonTip(250, "UDKSnip: Snip copied!", "Now, go to UDK and use \"Paste Here\" to paste your snip.", ToolTipIcon.Info);
            if (treeViewSnips.SelectedNode.Tag != null)
            {
                string snipName = treeViewSnips.SelectedNode.Tag as string;
                if (File.Exists(Settings.SnippetPath + snipName + ".snip"))
                {
                    StreamReader v_SnipReader = File.OpenText(Settings.SnippetPath + snipName + ".snip");
                    string snip = v_SnipReader.ReadToEnd();
                    v_SnipReader.Close();
                    Clipboard.SetText(snip);
                }
            }
        }

        private void copyCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyCurrentSnip();
        }
        private void CopyPasteFXForm_Resize(object sender, EventArgs e)
        {
            previewPanel.Refresh();
        }
        private void UDKSnipForm_Load(object sender, EventArgs e)
        {
            
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UDKSnip is Freeware!\nUDKSnip is a tool for Copy/Pasting preconfigured actors as user snippets.\nby PeeWeeK 2011", "About UDKSnip");
        }

        private void UDKSnipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if clicked on the cross or Alt+F4
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                //this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
                if (!this.bHasAlreadySeenMinimizeNotify)
                {
                    notifyIcon.ShowBalloonTip(250, "UDKSnip: I'm here!", "UDKSnip is still running, it will inform you when new snips are available.\n To open UDKSnip, click this balloon.", ToolTipIcon.Info);
                    this.bHasAlreadySeenMinimizeNotify = true;
                }
            }
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            NotifyForChanges();
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            NotifyForChanges();
        }

        private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            NotifyForChanges();
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            NotifyForChanges();
        }

        private void NotifyForChanges()
        {
            notifyIcon.ShowBalloonTip(1000, "UDKSnip: There are new snips out there!", "UDKSnip has detected that new snips are available.\n To open UDKSnip, click this balloon.", ToolTipIcon.Info);
            this.LoadSnippets();
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Visible = true;
            this.BringToFront();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openUDKSnipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.BringToFront();
        }


        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.BringToFront();
        }

        private void treeViewSnips_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag as string != null)
            {
                string snipName = e.Node.Tag as string;

                if (File.Exists(Settings.SnippetPath + snipName + ".desc"))
                {
                    StreamReader v_DescReader = File.OpenText(Settings.SnippetPath + snipName + ".desc");
                    string desc = v_DescReader.ReadToEnd();
                    v_DescReader.Close();
                    // this.textBoxDescription.Text = desc;
                    this.previewPanel.m_Title = snipName;
                    this.previewPanel.m_PreviewText = desc;
                }

                if (File.Exists(Settings.SnippetPath + snipName + ".jpg"))
                {
                    //Crée des problèmes de rename/delete
                    //this.previewPanel.m_DisplayImage = Image.FromFile(Settings.SnippetPath + snipName + ".jpg");
                    FileStream v_ImageStream = File.OpenRead(Settings.SnippetPath + snipName + ".jpg");
                    this.previewPanel.m_DisplayImage = Image.FromStream(v_ImageStream);
                    v_ImageStream.Close();
                }
                else
                {
                    this.previewPanel.m_DisplayImage = null;
                }
                previewPanel.Refresh();
            }
            else
            {
                this.previewPanel.m_Title = e.Node.Text;
                this.previewPanel.m_PreviewText = "Displaying contents of the category: " + e.Node.Text;
                this.previewPanel.m_DisplayImage = null;
                this.previewPanel.Refresh();
            }
        }

        private void setSnippetRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.SetSnippetRoot();
            Settings.SaveSettingFile();
            LoadSnippets();
        }

        private void enableNotifiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.EnableNotifies = !Settings.EnableNotifies;
            if (Settings.EnableNotifies)
            {
                enableNotifiesToolStripMenuItem.Checked = true;
                fileSystemWatcher.EnableRaisingEvents = true;
            }
            else
            {
                enableNotifiesToolStripMenuItem.Checked = false;
                fileSystemWatcher.EnableRaisingEvents = false;
            }
            Settings.SaveSettingFile();
        }

        private void editSnipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewSnips.SelectedNode.Tag != null)
            {
                AddSnippetForm v_Form = new AddSnippetForm(this, treeViewSnips.SelectedNode.Tag as string);
                this.LoadSnippets();
                v_Form.Show();
            }
            else
            {
                MessageBox.Show("Categories are not editable, please edit Snips", "Cannot edit category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSnipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewSnips.SelectedNode.Tag != null)
            {
                if (MessageBox.Show("Really delete snip: " + treeViewSnips.SelectedNode.Tag as string + " ?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string v_SnipName = treeViewSnips.SelectedNode.Tag as string;
                    LoadSnippets();
                    DeleteSnip(v_SnipName);
                    
                }

            }
            else
            {
                MessageBox.Show("Categories are not deletable, please delete individual Snips", "Cannot edit category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSnip(string p_SnipName)
        {
            File.Delete(Settings.SnippetPath + p_SnipName + ".snip");
            File.Delete(Settings.SnippetPath + p_SnipName + ".desc");
            File.Delete(Settings.SnippetPath + p_SnipName + ".jpg");
        }

        private void RenameSnip(string p_OldName, string p_NewName)
        {
            if (p_OldName.ToUpper() != p_NewName.ToUpper())
            {
                File.Copy(Settings.SnippetPath + p_OldName + ".snip", Settings.SnippetPath + p_NewName + ".snip");
                File.Copy(Settings.SnippetPath + p_OldName + ".desc", Settings.SnippetPath + p_NewName + ".desc");
                File.Copy(Settings.SnippetPath + p_OldName + ".jpg", Settings.SnippetPath + p_NewName + ".jpg");
                DeleteSnip(p_OldName);
            }
        }

        private void renameSnipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Incoming Soon!");
            
            if (treeViewSnips.SelectedNode.Tag != null)
            {
                string v_OldName = treeViewSnips.SelectedNode.Tag as string;
                
                RenameSnippetForm v_Form = new RenameSnippetForm(v_OldName);
                if (v_Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoadSnippets();
                    RenameSnip(v_OldName, v_Form.SnippetName);
                }
            }
        }
    }
}
