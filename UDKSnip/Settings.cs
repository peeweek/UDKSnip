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
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace UDKSnip
{
    public static class Settings
    {
        public static string SnippetPath = "";
        public static bool EnableNotifies = true;

        public static void LoadSettings()
        {
            if (File.Exists(Application.LocalUserAppDataPath + "\\UDKSnipSettings"))
            {
                StreamReader v_Reader = File.OpenText(Application.LocalUserAppDataPath + "\\UDKSnipSettings");
                // Read Path
                SnippetPath = v_Reader.ReadLine();
                // Enable Notifies
                EnableNotifies = bool.Parse(v_Reader.ReadLine());
                v_Reader.Close();
            }
            else SaveSettingFile();


        }


        public static void SetSnippetRoot()
        {
            FolderBrowserDialog v_FBDialog = new FolderBrowserDialog();
            v_FBDialog.Description = "Select Root Snip Folder";
            if (v_FBDialog.ShowDialog() == DialogResult.OK)
            {
                SnippetPath = v_FBDialog.SelectedPath + "\\";
            }
        }

        public static void SaveSettingFile()
        {
             // Default Path
            if (SnippetPath == "")
            {
                FolderBrowserDialog v_FBDialog = new FolderBrowserDialog();
                v_FBDialog.Description = "Select Root Snip Folder";
                if (v_FBDialog.ShowDialog() == DialogResult.OK)
                {
                    SnippetPath = v_FBDialog.SelectedPath + "\\";
                }
                else
                {
                    MessageBox.Show("Please provide application with a Root Snip Folder.");
                    Application.Exit();
                } 
            }
            StreamWriter v_Writer = File.CreateText(Application.LocalUserAppDataPath + "\\UDKSnipSettings");

           
            v_Writer.WriteLine(SnippetPath);
            v_Writer.WriteLine(EnableNotifies.ToString());
            v_Writer.Close();
        }
    }
}
