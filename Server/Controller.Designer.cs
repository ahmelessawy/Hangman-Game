﻿namespace Server
{
    partial class Controller
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
        private void InitializeComponent()
        {
            this.List_Connected_endpoint = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.List_Disonnected_endpoint = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.List_ClientMsgs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Terminate = new System.Windows.Forms.Button();
            this.Button_Log = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.List_Connected_name = new System.Windows.Forms.ListBox();
            this.List_Disonnected_name = new System.Windows.Forms.ListBox();
            this.Insert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Category = new My_TextBox.My_TextBox();
            this.textBox_Word = new My_TextBox.My_TextBox();
            this.List_Categories = new System.Windows.Forms.ListBox();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_Connected_endpoint
            // 
            this.List_Connected_endpoint.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Connected_endpoint.FormattingEnabled = true;
            this.List_Connected_endpoint.ItemHeight = 16;
            this.List_Connected_endpoint.Location = new System.Drawing.Point(25, 32);
            this.List_Connected_endpoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Connected_endpoint.Name = "List_Connected_endpoint";
            this.List_Connected_endpoint.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List_Connected_endpoint.Size = new System.Drawing.Size(128, 212);
            this.List_Connected_endpoint.TabIndex = 0;
            this.List_Connected_endpoint.SelectedIndexChanged += new System.EventHandler(this.List_Connected_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connected Clients";
            // 
            // List_Disonnected_endpoint
            // 
            this.List_Disonnected_endpoint.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Disonnected_endpoint.Enabled = false;
            this.List_Disonnected_endpoint.FormattingEnabled = true;
            this.List_Disonnected_endpoint.ItemHeight = 16;
            this.List_Disonnected_endpoint.Location = new System.Drawing.Point(25, 272);
            this.List_Disonnected_endpoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Disonnected_endpoint.Name = "List_Disonnected_endpoint";
            this.List_Disonnected_endpoint.Size = new System.Drawing.Size(128, 164);
            this.List_Disonnected_endpoint.TabIndex = 0;
            this.List_Disonnected_endpoint.SelectedIndexChanged += new System.EventHandler(this.List_Disonnected_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disconnected Clients";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.Location = new System.Drawing.Point(161, 456);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Send_KeyDown);
            // 
            // Button_Send
            // 
            this.Button_Send.BackColor = System.Drawing.Color.Orange;
            this.Button_Send.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Send.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send.Location = new System.Drawing.Point(688, 457);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(121, 43);
            this.Button_Send.TabIndex = 3;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = false;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // List_ClientMsgs
            // 
            this.List_ClientMsgs.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_ClientMsgs.FormattingEnabled = true;
            this.List_ClientMsgs.ItemHeight = 16;
            this.List_ClientMsgs.Location = new System.Drawing.Point(296, 32);
            this.List_ClientMsgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_ClientMsgs.Name = "List_ClientMsgs";
            this.List_ClientMsgs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.List_ClientMsgs.Size = new System.Drawing.Size(513, 404);
            this.List_ClientMsgs.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clients Messages";
            // 
            // Button_Terminate
            // 
            this.Button_Terminate.BackColor = System.Drawing.Color.Orange;
            this.Button_Terminate.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Terminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Terminate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Terminate.Location = new System.Drawing.Point(25, 561);
            this.Button_Terminate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Terminate.Name = "Button_Terminate";
            this.Button_Terminate.Size = new System.Drawing.Size(152, 62);
            this.Button_Terminate.TabIndex = 3;
            this.Button_Terminate.Text = "Terminate";
            this.Button_Terminate.UseVisualStyleBackColor = false;
            this.Button_Terminate.Click += new System.EventHandler(this.Button_Terminate_Click);
            // 
            // Button_Log
            // 
            this.Button_Log.BackColor = System.Drawing.Color.Orange;
            this.Button_Log.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Log.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Log.Location = new System.Drawing.Point(183, 561);
            this.Button_Log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Log.Name = "Button_Log";
            this.Button_Log.Size = new System.Drawing.Size(152, 62);
            this.Button_Log.TabIndex = 3;
            this.Button_Log.Text = "Save Log";
            this.Button_Log.UseVisualStyleBackColor = false;
            this.Button_Log.Click += new System.EventHandler(this.Button_Log_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Orange;
            this.Button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(657, 561);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(152, 62);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.Orange;
            this.Button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Start.Location = new System.Drawing.Point(341, 591);
            this.Button_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(310, 32);
            this.Button_Start.TabIndex = 4;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // List_Connected_name
            // 
            this.List_Connected_name.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Connected_name.FormattingEnabled = true;
            this.List_Connected_name.ItemHeight = 16;
            this.List_Connected_name.Location = new System.Drawing.Point(161, 32);
            this.List_Connected_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Connected_name.Name = "List_Connected_name";
            this.List_Connected_name.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List_Connected_name.Size = new System.Drawing.Size(128, 212);
            this.List_Connected_name.TabIndex = 0;
            this.List_Connected_name.SelectedIndexChanged += new System.EventHandler(this.List_Connected_SelectedIndexChanged);
            // 
            // List_Disonnected_name
            // 
            this.List_Disonnected_name.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Disonnected_name.Enabled = false;
            this.List_Disonnected_name.FormattingEnabled = true;
            this.List_Disonnected_name.ItemHeight = 16;
            this.List_Disonnected_name.Location = new System.Drawing.Point(161, 272);
            this.List_Disonnected_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Disonnected_name.Name = "List_Disonnected_name";
            this.List_Disonnected_name.Size = new System.Drawing.Size(128, 164);
            this.List_Disonnected_name.TabIndex = 0;
            this.List_Disonnected_name.SelectedIndexChanged += new System.EventHandler(this.List_Disonnected_SelectedIndexChanged);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Orange;
            this.Insert.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(525, 3);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(121, 30);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Category);
            this.panel1.Controls.Add(this.Insert);
            this.panel1.Controls.Add(this.textBox_Word);
            this.panel1.Location = new System.Drawing.Point(161, 509);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 36);
            this.panel1.TabIndex = 10;
            // 
            // textBox_Category
            // 
            this.textBox_Category.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_Category.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.textBox_Category.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Category.Location = new System.Drawing.Point(3, 7);
            this.textBox_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Category.Name = "textBox_Category";
            this.textBox_Category.PlaceHolder = "Category";
            this.textBox_Category.Size = new System.Drawing.Size(186, 24);
            this.textBox_Category.TabIndex = 9;
            this.textBox_Category.Text = "Category";
            // 
            // textBox_Word
            // 
            this.textBox_Word.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_Word.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.textBox_Word.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Word.Location = new System.Drawing.Point(195, 7);
            this.textBox_Word.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Word.Name = "textBox_Word";
            this.textBox_Word.PlaceHolder = "Word";
            this.textBox_Word.Size = new System.Drawing.Size(326, 24);
            this.textBox_Word.TabIndex = 9;
            this.textBox_Word.Text = "Word";
            // 
            // List_Categories
            // 
            this.List_Categories.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Categories.FormattingEnabled = true;
            this.List_Categories.ItemHeight = 16;
            this.List_Categories.Location = new System.Drawing.Point(25, 456);
            this.List_Categories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Categories.Name = "List_Categories";
            this.List_Categories.Size = new System.Drawing.Size(128, 84);
            this.List_Categories.TabIndex = 11;
            // 
            // IpAddress
            // 
            this.IpAddress.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IpAddress.Location = new System.Drawing.Point(341, 561);
            this.IpAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IpAddress.Size = new System.Drawing.Size(310, 23);
            this.IpAddress.TabIndex = 2;
            this.IpAddress.Text = "127.0.0.1";
            this.IpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IpAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Send_KeyDown);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(841, 651);
            this.ControlBox = false;
            this.Controls.Add(this.List_Categories);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Log);
            this.Controls.Add(this.Button_Terminate);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_ClientMsgs);
            this.Controls.Add(this.List_Disonnected_name);
            this.Controls.Add(this.List_Disonnected_endpoint);
            this.Controls.Add(this.List_Connected_name);
            this.Controls.Add(this.List_Connected_endpoint);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controller";
            this.ShowIcon = false;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_Connected_endpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox List_Disonnected_endpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.ListBox List_ClientMsgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Terminate;
        private System.Windows.Forms.Button Button_Log;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.ListBox List_Connected_name;
        private System.Windows.Forms.ListBox List_Disonnected_name;
        private System.Windows.Forms.Button Insert;
        private My_TextBox.My_TextBox textBox_Category;
        private My_TextBox.My_TextBox textBox_Word;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox List_Categories;
        private System.Windows.Forms.TextBox IpAddress;
    }
}