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
using System.Text;
using System.Windows.Forms;

namespace UDKSnip
{
    public partial class RenameSnippetForm : Form
    {
        public string SnippetName;

        public RenameSnippetForm(string p_SnippetName)
        {
            InitializeComponent();
            SnippetName = p_SnippetName;
            this.textBoxSnippetName.Text = SnippetName;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SnippetName = textBoxSnippetName.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SnippetName = textBoxSnippetName.Text;
        }
    }
}
