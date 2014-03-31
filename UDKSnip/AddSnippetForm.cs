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
    public partial class AddSnippetForm : Form
    {
        UDKSnipForm m_MasterForm;

        public AddSnippetForm(UDKSnipForm p_MasterForm)
        {
            InitializeComponent();
            this.m_MasterForm = p_MasterForm;
        }
        public AddSnippetForm(UDKSnipForm p_MasterForm, string p_SnipName)
        {
            InitializeComponent();
            this.m_MasterForm = p_MasterForm;
            this.Text = "Edit Snippet: " + p_SnipName;

            this.textBoxName.Text = p_SnipName;
            this.textBoxName.ReadOnly = true;
            this.buttonPasteScreenshot.Enabled = false;

            StreamReader v_DescReader = File.OpenText(Settings.SnippetPath + p_SnipName + ".desc");
            this.textBoxDesc.Text = v_DescReader.ReadToEnd();
            v_DescReader.Close();
            StreamReader v_SnipReader = File.OpenText(Settings.SnippetPath + p_SnipName + ".snip");
            this.textBoxCode.Text = v_SnipReader.ReadToEnd();
            v_SnipReader.Close();

            if (File.Exists(Settings.SnippetPath + p_SnipName + ".jpg"))
            {
                this.pictureBoxScreenshot.Image = Image.FromFile(Settings.SnippetPath + p_SnipName + ".jpg");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            SaveSnippet();
            this.Close();
        }

        public void SaveSnippet()
        {
            if (textBoxName.ReadOnly) m_MasterForm.LoadSnippets();
            if (textBoxName.Text != "" && textBoxDesc.Text != "" && textBoxCode.Text != "")
            {
                // DESC
                StreamWriter v_DescWriter = File.CreateText(Settings.SnippetPath + textBoxName.Text + ".desc");
                v_DescWriter.Write(textBoxDesc.Text);
                v_DescWriter.Close();
                // IMAGE
                if (pictureBoxScreenshot.Image != null && !textBoxName.ReadOnly)
                {
                    pictureBoxScreenshot.Image.Save(Settings.SnippetPath + textBoxName.Text + ".jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                // SNIPPET
                StreamWriter v_SnipWriter = File.CreateText(Settings.SnippetPath + textBoxName.Text + ".snip");
                v_SnipWriter.Write(textBoxCode.Text);
                v_SnipWriter.Close();
            }
            else MessageBox.Show("Please fill in all Fields (you can omit screenshot though)");
        }

        private void pictureBoxScreenshot_Click(object sender, EventArgs e)
        {

        }

        private void AddSnippetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_MasterForm.LoadSnippets();
        }

        private void buttonPasteScreenshot_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image v_Paste = Clipboard.GetImage();
                pictureBoxScreenshot.Image = v_Paste;
            }
        }

        private void AddSnippetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
