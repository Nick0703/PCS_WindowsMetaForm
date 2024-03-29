﻿using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.IO;
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
        private static bool successChange = false;

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
            MessageBox.Show("Make sure to select the parent folder of the Movies and TV folders! \n\n(E.g. Z:, Z:\\Media or Z:\\Shared drives\\PlexCloudServers\\Media)", "Attention!");
            
            // Show the Folder browse dialog and set the textbox
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                txtMountPath.Text = folderBrowserDialog2.SelectedPath;
            }

            // Make sure that the user's mount path ends with '\'
            new_MountPath = txtMountPath.Text;
            if (!new_MountPath.EndsWith(@"\") && (!new_MountPath.Contains("Click the Browse button.")))
            {
                new_MountPath += @"\";
                txtMountPath.Text = new_MountPath;
            }
        }

        // Mount Path TextBox
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!txtMountPath.Text.Contains("Click the Browse button.") || !txtMountPath.Text.Contains(@"Click the Browse button.\"))
                // Enable the Update groupbox
                grpboxUpdate.Enabled = true;
        }

        // Update DB Button
        private void BtnUpdateDB_Click(object sender, EventArgs e)
        {
            // Set the progress bar to 60%
            progressBar1.Value = 60;

            // Run the SQL update query in the background
            backgroundWorker1.RunWorkerAsync();
        }

        // Create the SQL Connection
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
                MessageBox.Show("Unable to open the database.", "Error!");
            }

            return sqlite_conn;
        }

        // Execute the SQL update query
        private int UpdateMount(SQLiteConnection conn, string new_path)
        {
            int queryCount;
            SQLiteCommand command = conn.CreateCommand();
            string root_path = @"P:\Shared drives\PlexCloudServers\Media\";
            string root_path_like = @"%P:\Shared drives\PlexCloudServers\Media\%";

            string url_path = @"file://P:\Shared drives\PlexCloudServers\Media\";
            string url_path_like = @"%file://P:\Shared drives\PlexCloudServers\Media\%";

            command.CommandText = "DROP TRIGGER fts4_metadata_titles_before_update_icu";
            queryCount = command.ExecuteNonQuery();

            command.CommandText = "DROP TRIGGER fts4_metadata_titles_after_update_icu";
            queryCount += command.ExecuteNonQuery();

            command.CommandText = "UPDATE section_locations SET root_path = replace(root_path, @root_path, @new_path) WHERE root_path LIKE @root_path_like";
            command.Parameters.Add(new SQLiteParameter("@root_path", root_path));
            command.Parameters.Add(new SQLiteParameter("@new_path", new_path));
            command.Parameters.Add(new SQLiteParameter("@root_path_like", root_path_like));
            queryCount += command.ExecuteNonQuery();

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

            command.CommandText = "CREATE TRIGGER fts4_metadata_titles_before_update_icu BEFORE UPDATE ON metadata_items BEGIN DELETE FROM fts4_metadata_titles_icu WHERE docid=old.rowid; END;";
            queryCount += command.ExecuteNonQuery();

            command.CommandText = "DCREATE TRIGGER fts4_metadata_titles_after_update_icu AFTER UPDATE ON metadata_items BEGIN INSERT INTO fts4_metadata_titles_icu(docid, title, title_sort, original_title) VALUES(new.rowid, new.title, new.title_sort, new.original_title); END;";
            queryCount += command.ExecuteNonQuery();

            return queryCount;
        }

        // Background Worker DoWork
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SQLiteConnection sqlite_conn = CreateConnection(dbPath);

            if (UpdateMount(sqlite_conn, new_MountPath) != 0)
            {
                successChange = true;
            }
            else
            {
                successChange = false;
            }
        }

        // Background Worker Completed
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            
            if (successChange)
            {
                MessageBox.Show("Successfully updated the database.", "Success!");
            } 
            else
            {
                MessageBox.Show("No changes made, it's probably updated already.", "Well then...");
            }
        }

        // Select the custom meta path (Date Fix)
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Make sure to select the root folder only! (E.g. D:\Plex Media Server)", "Attention!");
            // Show the Folder browse dialog and set the textbox
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDateCustom.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        // Default Install (Date Fix)
        private void rdDateDefault_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the custom path field and disable the browse button
            txtDateCustom.Enabled = false;
            btnDateBrowse.Enabled = false;

            btnFixDate.Enabled = true;

            pmsInstall = Environment.ExpandEnvironmentVariables(pmsInstall);
            pmsDd = Environment.ExpandEnvironmentVariables(pmsDd);
            dbPath = Path.Combine(pmsInstall, pmsDd);
        }

        // Custom Install (Date Fix)
        private void rdCustomDate_CheckedChanged(object sender, EventArgs e)
        {
            // Enable the browse button and the textbox
            txtDateCustom.Enabled = true;
            btnDateBrowse.Enabled = true;
        }

        // TextBox Install Path (Date Fix)
        private void txtDateCustom_TextChanged(object sender, EventArgs e)
        {
            customInstall = txtDateCustom.Text;
            customInstall = Environment.ExpandEnvironmentVariables(customInstall);
            pmsDd = Environment.ExpandEnvironmentVariables(pmsDd);
            dbPath = Path.Combine(customInstall, pmsDd);

            btnFixDate.Enabled = true;
        }

        // Fix the Date Button (Date Fix)
        private void btnFixDate_Click(object sender, EventArgs e)
        {
            // Set the progress bar to 60%
            progressBar2.Value = 60;

            // Run the SQL update query in the background
            backgroundWorker2.RunWorkerAsync();
        }

        // Background Worker DoWork (Date Fix)
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            SQLiteConnection sqlite_conn = CreateConnection(dbPath);

            if (FixDate(sqlite_conn) != 0)
            {
                successChange = true;
            }
            else
            {
                successChange = false;
            }
        }

        // Fix the date in the DB (Date Fix)
        private int FixDate(SQLiteConnection conn)
        {
            int queryCount;
            SQLiteCommand command = conn.CreateCommand();

            command.CommandText = "DROP TRIGGER fts4_metadata_titles_before_update_icu";
            queryCount = command.ExecuteNonQuery();

            command.CommandText = "DROP TRIGGER fts4_metadata_titles_after_update_icu";
            queryCount += command.ExecuteNonQuery();

            command.CommandText = "UPDATE metadata_items SET added_at = updated_at WHERE DATETIME(added_at) > DATETIME('now')";
            queryCount += command.ExecuteNonQuery();

            if (chkBoxCreateDate.Checked)
            {
                command.CommandText = "UPDATE metadata_items SET created_at = originally_available_at WHERE DATETIME(created_at) > DATETIME('now');";
                queryCount += command.ExecuteNonQuery();
            }

            command.CommandText = "CREATE TRIGGER fts4_metadata_titles_before_update_icu BEFORE UPDATE ON metadata_items BEGIN DELETE FROM fts4_metadata_titles_icu WHERE docid=old.rowid; END;";
            queryCount += command.ExecuteNonQuery();

            command.CommandText = "DCREATE TRIGGER fts4_metadata_titles_after_update_icu AFTER UPDATE ON metadata_items BEGIN INSERT INTO fts4_metadata_titles_icu(docid, title, title_sort, original_title) VALUES(new.rowid, new.title, new.title_sort, new.original_title); END;";
            queryCount += command.ExecuteNonQuery();

            return queryCount;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar2.Value = 100;

            if (successChange)
            {
                MessageBox.Show("Successfully fix the date issues in the database.", "Success!");
            }
            else
            {
                MessageBox.Show("No changes made, it's probably updated already.", "Well then...");
            }
        }
    }
}
