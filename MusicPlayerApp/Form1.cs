﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Create Global Variables of String Type Array to save the titles or name of the Tracks and path of the track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to SElect Songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple files
            ofd.Multiselect = true;
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames; //Save the paths of the tracks in path array
                //Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display Songs in Listbox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxSongs.SelectedIndex;

    // Ensure the selected index is valid before accessing the paths array
    if (selectedIndex >= 0 && selectedIndex < paths.Length)
    {
        axWindowsMediaPlayerMusic.URL = paths[selectedIndex];
    }
    else
    {
        // Optional: Handle the case where the index is invalid
        MessageBox.Show("Invalid song selection or no song loaded.");
    }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to Close the App
            this.Close();
        }
    }
}
//testgithub
