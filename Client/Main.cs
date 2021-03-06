﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        private string Username;
        private int endpoint;
        private NetworkStream nStream;
        private BinaryReader breader;
        private BinaryWriter bwriter;
        private Thread thread;
        private string cats;
        private Play game;
        private string temp_str_room_word = null;
        private string temp_str_room_pressed = null;
        private int temp_str_room_id = -1;

        public Main(NetworkStream nStream, String Username)
        {
            InitializeComponent();
            this.nStream = nStream;
            this.Username = Username;
            this.Text = Username;
            Name.Text = Username;
            bwriter = new BinaryWriter(nStream);
            breader = new BinaryReader(nStream);
            bwriter.Write(Username);
            endpoint = int.Parse(breader.ReadString());
            thread = new Thread(DataReader);
            thread.Start();
            Play.Enabled = false;
            Watch.Enabled = false;
        }

        private void Watch_Click(object sender, EventArgs e)
        {
            if (ListBox_ID.SelectedIndex != -1)
            {
                int room_id = int.Parse(ListBox_ID.SelectedItem.ToString());
                bwriter.Write("Watch Room;" + endpoint + ";" + room_id);
                while (temp_str_room_word == null) ;
                while (temp_str_room_pressed == null) ;
                game = new Play(temp_str_room_word, room_id, endpoint, "Watcher: " + Username, temp_str_room_pressed, bwriter);
                temp_str_room_word = temp_str_room_pressed = null;
                game.Remove_Button = false;
                game.ShowDialog();
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            if (index != -1)
            {
                ListBox_ID.SelectedIndex = index;
                ListBox_Rooms.SelectedIndex = index;
                ListBox_Categories.SelectedIndex = index;
                ListBox_Levels.SelectedIndex = index;
                ListBox_Players.SelectedIndex = index;
                Watch.Enabled = true;
                if (ListBox_Players.SelectedItem.ToString() == "2/2")
                    Play.Enabled = false;
                else
                    Play.Enabled = true;
            }
            else
            {
                Watch.Enabled = false;
                Play.Enabled = false;
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (cats.EndsWith(";"))
                cats = cats.Substring(0, cats.Length - 1); // Remove last ;
            Rules NewRules = new Rules(cats);
            NewRules.ShowDialog();
            if (NewRules.DialogResult == DialogResult.OK)
            {
                bwriter.Write("New Room;" + endpoint + ";" + NewRules.Room_name + ";" + NewRules.Category + ";" + NewRules.Level);
                while (temp_str_room_word == null) ;
                while (temp_str_room_pressed == null) ;
                while (temp_str_room_id == -1) ;
                game = new Play(temp_str_room_word, temp_str_room_id, endpoint, "Player 1: " + Username, temp_str_room_pressed, bwriter);
                temp_str_room_word = temp_str_room_pressed = null;
                temp_str_room_id = -1;
                DialogResult DR1 = game.ShowDialog();
                if (DR1 == DialogResult.Retry)
                    New_Click(sender, e);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (ListBox_ID.SelectedIndex != -1)
            {
                bwriter.Write("Join Room Confirm;" + ListBox_ID.SelectedItem.ToString() + ";" + endpoint);
                while (temp_str_room_word == null) ;
                while (temp_str_room_pressed == null) ;
                while (temp_str_room_id == -1) ;
                game = new Play(temp_str_room_word, temp_str_room_id, endpoint, "Player 2: " + Username, temp_str_room_pressed, bwriter);
                temp_str_room_word = temp_str_room_pressed = null;
                temp_str_room_id = -1;
                game.Change_Button = false;
                DialogResult DR2 = game.ShowDialog();
                if (DR2 == DialogResult.Retry)
                    New_Click(sender, e);
            }
        }

        private void DataReader()
        {
            try
            {
                while (true)
                {
                    string[] response = breader.ReadString().Split(';');
                    string type = response[0];
                    switch (type)
                    {
                        case "Category":
                            cats += response[1] + ";";
                            break;

                        case "Room":
                            ListBox_ID.Items.Add(response[1]);
                            ListBox_Rooms.Items.Add(response[2]);
                            ListBox_Categories.Items.Add(response[3]);
                            ListBox_Levels.Items.Add(response[4]);
                            ListBox_Players.Items.Add(response[5] + "/2");
                            break;

                        case "New Player":
                            DialogResult result = MessageBox.Show(response[3] + " wants to join your room", "Join Confirmation",
                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                bwriter.Write("Join Room Reply;" + response[1] + ";" + response[2]);
                                game.Change_Button = false;
                            }
                            break;

                        case "Join Room Accepted":
                            temp_str_room_word = response[1];
                            temp_str_room_pressed = response[2];
                            temp_str_room_id = int.Parse(response[3]);
                            break;

                        case "Room Word":
                            temp_str_room_word = response[1];
                            temp_str_room_pressed = response[2];
                            temp_str_room_id = int.Parse(response[3]);
                            break;

                        case "Play Form Enable":
                            while (game == null) ;
                            game.Dimmed = bool.Parse(response[1]);
                            game.Change_Label = response[2];
                            game.Count = int.Parse(response[3]);
                            if (response[2].Contains("Winner: Player"))
                                game.PlayerMessageBox();
                            break;

                        case "Dim Button":
                            while (game == null) ;
                            game.Pressed_Button(response[1]);
                            break;

                        case "Watch Room Info":
                            temp_str_room_word = response[1];
                            temp_str_room_pressed = response[2];
                            while (game == null) ;
                            game.Change_Label = response[3];
                            break;

                        case "Change Room Capacity":
                            int index = ListBox_ID.FindStringExact(response[1]);
                            ListBox_Players.Items[index] = "2/2";
                            break;

                        case "Change Room Capacity Half":
                            int hliindex = ListBox_ID.FindStringExact(response[1]);
                            ListBox_Players.Items[hliindex] = "1/2";
                            break;

                        case "Remove Room":
                            int listindex = ListBox_ID.FindStringExact(response[1]);
                            ListBox_ID.Items.RemoveAt(listindex);
                            ListBox_Categories.Items.RemoveAt(listindex);
                            ListBox_Levels.Items.RemoveAt(listindex);
                            ListBox_Rooms.Items.RemoveAt(listindex);
                            ListBox_Players.Items.RemoveAt(listindex);
                            break;

                        case "Rebuild Form":
                            game.Close();
                            game = null;
                            InvokeUI(() =>
                            {
                                game = new Play(response[2], int.Parse(response[1]), endpoint, response[3], "", bwriter);
                                game.Dimmed = bool.Parse(response[4]);
                                game.Score = response[5];
                                game.Change_Label = bool.Parse(response[4]) ? "Your Turn" : "Waiting for other player...";
                                game.Change_Button = bool.Parse(response[6]);
                                DialogResult DR3 = game.ShowDialog();
                                if (DR3 == DialogResult.Retry)
                                    New_Click(new object(), new EventArgs());
                            });
                            break;

                        case "Terminated":
                            MessageBox.Show("You Are Terminated", "Termination Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            this.Close();
                            break;

                        default:
                            MessageBox.Show(response[0]);
                            break;
                    }
                }
            }
            catch (EndOfStreamException)
            {
                DialogResult result = MessageBox.Show("Error : Web Server is Down");
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void InvokeUI(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            breader.Close();
            bwriter.Close();
            nStream.Close();
            Application.ExitThread();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}