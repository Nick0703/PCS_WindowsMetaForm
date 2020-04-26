﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PCS_WinForm
{
    public partial class Form1 : Form
    {
        private static string pmsInstall = @"%localappdata%\Plex Media Server";
        private static string pmsDd = @"Plug-in Support\Databases\com.plexapp.plugins.library.db";
        private static string customInstall;
        private static string new_MountPath;
        private static string dbPath;
        private Thread DoWorkThread;

        public Form1()
        {
            InitializeComponent();
        }

        // Default Metadata Radio Button
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the custom path field and disable the browse button
            txtCustomMeta.Enabled = false;
            btnBrowseMeta.Enabled = false;

            // Enable the mount group box
            grpboxMount.Enabled = true;

            pmsInstall = Environment.ExpandEnvironmentVariables(pmsInstall);
            pmsDd = Environment.ExpandEnvironmentVariables(pmsDd);
            dbPath = Path.Combine(pmsInstall, pmsDd);
        }
        
        // Custom Metadata Radio Button
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Enable the browse button and the textbox
            txtCustomMeta.Enabled = true;
            btnBrowseMeta.Enabled = true;
        }

        // Custom Metadata Browse Button
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Make sure to select the root folder only! (E.g. D:\Plex Media Server)", "Attention!");
            // Show the Folder browse dialog and set the textbox
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCustomMeta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        // Custom Metadata TextBox
        private void TxtCustomMeta_TextChanged(object sender, EventArgs e)
        {
            customInstall = txtCustomMeta.Text;
            customInstall = Environment.ExpandEnvironmentVariables(customInstall);
            pmsDd = Environment.ExpandEnvironmentVariables(pmsDd);
            dbPath = Path.Combine(customInstall, pmsDd);

            // Enable the mount group box
            grpboxMount.Enabled = true;
        }

        // Custom Mount Browse Button
        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make sure to select the parent folder of the Movies and TV folders! \n(E.g. Z:, Z:\\Media or Z:\\Shared drives\\PlexCloudServers\\Media)", "Attention!");
            
            // Show the Folder browse dialog and set the textbox
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                txtMountPath.Text = folderBrowserDialog2.SelectedPath;
            }

            // Make sure that the user's path ends with '\'
            new_MountPath = txtMountPath.Text;
            if (!new_MountPath.EndsWith(@"\"))
            {
                new_MountPath += @"\";
                txtMountPath.Text = new_MountPath;
            }
        }

        // Mount Path TextBox
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Enable the Update groupbox
            grpboxUpdate.Enabled = true;
        }

        // Update DB Button
        private void BtnUpdateDB_Click(object sender, EventArgs e)
        {
            DoWorkThread = new Thread(new ThreadStart(DoWork))
            {
                IsBackground = true
            };
            DoWorkThread.Start();
        }

        private void DoWork()
        { // This void contains action that will be performed by thread
          //TODO: Background processing. To update UI from another thread use Control.Invoke(...)
            SQLiteConnection sqlite_conn = CreateConnection(dbPath);           

            if (UpdateMount(sqlite_conn, new_MountPath) != 0)
            {
                MessageBox.Show("Successfully updated the database.", "Success!");
            }
            else
            {
                MessageBox.Show("No changes made, it's probably updated already.", "Well then...");
            }
        }

        private SQLiteConnection CreateConnection(string dbPath)
        {
            string connString = string.Format("Data Source={0}", dbPath);

            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection(connString);

            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUnable to open the database\n");
                Console.ResetColor();
            }

            return sqlite_conn;
        }

        private int UpdateMount(SQLiteConnection conn, string new_path)
        {
            int queryCount;
            SQLiteCommand command = conn.CreateCommand();
            string root_path = @"P:\Shared drives\PlexCloudServers\Media\";
            string root_path_like = @"%P:\Shared drives\PlexCloudServers\Media\%";

            string url_path = @"file://P:\Shared drives\PlexCloudServers\Media\";
            string url_path_like = @"%file://P:\Shared drives\PlexCloudServers\Media\%";

            command.CommandText = "UPDATE section_locations SET root_path = replace(root_path, @root_path, @new_path) WHERE root_path LIKE @root_path_like";
            command.Parameters.Add(new SQLiteParameter("@root_path", root_path));
            command.Parameters.Add(new SQLiteParameter("@new_path", new_path));
            command.Parameters.Add(new SQLiteParameter("@root_path_like", root_path_like));
            queryCount = command.ExecuteNonQuery();

            command.CommandText = "UPDATE media_streams SET url = replace(url, @url_path, @new_path) WHERE url LIKE @url_path_like";
            command.Parameters.Add(new SQLiteParameter("@url_path", url_path));
            command.Parameters.Add(new SQLiteParameter("@new_path", new_path));
            command.Parameters.Add(new SQLiteParameter("@url_path_like", url_path_like));
            queryCount += command.ExecuteNonQuery();

            command.CommandText = "UPDATE media_parts SET file = replace(file, @root_path, @new_path) WHERE file LIKE @root_path_like";
            command.Parameters.Add(new SQLiteParameter("@root_path", root_path));
            command.Parameters.Add(new SQLiteParameter("@new_path", new_path));
            command.Parameters.Add(new SQLiteParameter("@root_path_like", root_path_like));
            queryCount += command.ExecuteNonQuery();

            return queryCount;
        }
    }
}