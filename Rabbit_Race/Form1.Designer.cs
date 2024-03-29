﻿using System.Windows.Forms;

namespace Rabbit_Race
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            this.Jashandeep_RadioBtn = new System.Windows.Forms.RadioButton();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.Jagdeep_RadioBtn = new System.Windows.Forms.RadioButton();
            this.Tajinder_RadioBtn = new System.Windows.Forms.RadioButton();
            this.panelBets = new System.Windows.Forms.Panel();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTajinder = new System.Windows.Forms.Label();
            this.lblJashandeep = new System.Windows.Forms.Label();
            this.lblJagdeep = new System.Windows.Forms.Label();
            this.panelBetting = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnNewRace = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblBettor = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.nudCash = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRabbitNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBets.SuspendLayout();
            this.panelBetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRabbitNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pb2);
            this.splitContainer1.Panel1.Controls.Add(this.pb4);
            this.splitContainer1.Panel1.Controls.Add(this.pb1);
            this.splitContainer1.Panel1.Controls.Add(this.pb3);
            this.splitContainer1.Panel1.Controls.Add(this.pbRaceTrack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1147, 733);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 2;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.InitialImage = null;
            this.pb2.Location = new System.Drawing.Point(75, 173);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(94, 60);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            this.pb2.Tag = "1";
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.InitialImage = null;
            this.pb4.Location = new System.Drawing.Point(75, 407);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(94, 61);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 2;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.InitialImage = null;
            this.pb1.Location = new System.Drawing.Point(72, 60);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(94, 60);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.InitialImage = null;
            this.pb3.Location = new System.Drawing.Point(75, 287);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(94, 62);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRaceTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbRaceTrack.Image")));
            this.pbRaceTrack.Location = new System.Drawing.Point(0, 0);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(1147, 522);
            this.pbRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            this.pbRaceTrack.Click += new System.EventHandler(this.pbRaceTrack_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelBetting);
            this.splitContainer2.Size = new System.Drawing.Size(1147, 207);
            this.splitContainer2.SplitterDistance = 136;
            this.splitContainer2.TabIndex = 15;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panelBets);
            this.splitContainer3.Size = new System.Drawing.Size(1147, 136);
            this.splitContainer3.SplitterDistance = 381;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblMinimumBet);
            this.panel2.Controls.Add(this.Jashandeep_RadioBtn);
            this.panel2.Controls.Add(this.lblMaxBet);
            this.panel2.Controls.Add(this.Jagdeep_RadioBtn);
            this.panel2.Controls.Add(this.Tajinder_RadioBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 136);
            this.panel2.TabIndex = 16;
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumBet.Location = new System.Drawing.Point(16, 25);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(52, 17);
            this.lblMinimumBet.TabIndex = 0;
            this.lblMinimumBet.Text = "Bettor";
            // 
            // Jashandeep_RadioBtn
            // 
            this.Jashandeep_RadioBtn.AutoSize = true;
            this.Jashandeep_RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jashandeep_RadioBtn.Location = new System.Drawing.Point(19, 53);
            this.Jashandeep_RadioBtn.Name = "Jashandeep_RadioBtn";
            this.Jashandeep_RadioBtn.Size = new System.Drawing.Size(189, 21);
            this.Jashandeep_RadioBtn.TabIndex = 1;
            this.Jashandeep_RadioBtn.TabStop = true;
            this.Jashandeep_RadioBtn.Tag = "0";
            this.Jashandeep_RadioBtn.Text = "Jashandeep_RadioBtn";
            this.Jashandeep_RadioBtn.UseVisualStyleBackColor = true;
            this.Jashandeep_RadioBtn.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxBet.Location = new System.Drawing.Point(147, 25);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(52, 17);
            this.lblMaxBet.TabIndex = 14;
            this.lblMaxBet.Text = "label3";
            this.lblMaxBet.Visible = false;
            // 
            // Jagdeep_RadioBtn
            // 
            this.Jagdeep_RadioBtn.AutoSize = true;
            this.Jagdeep_RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jagdeep_RadioBtn.Location = new System.Drawing.Point(19, 76);
            this.Jagdeep_RadioBtn.Name = "Jagdeep_RadioBtn";
            this.Jagdeep_RadioBtn.Size = new System.Drawing.Size(163, 21);
            this.Jagdeep_RadioBtn.TabIndex = 2;
            this.Jagdeep_RadioBtn.TabStop = true;
            this.Jagdeep_RadioBtn.Tag = "1";
            this.Jagdeep_RadioBtn.Text = "Jagdeep_RadioBtn";
            this.Jagdeep_RadioBtn.UseVisualStyleBackColor = true;
            this.Jagdeep_RadioBtn.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
            // 
            // Tajinder_RadioBtn
            // 
            this.Tajinder_RadioBtn.AutoSize = true;
            this.Tajinder_RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tajinder_RadioBtn.Location = new System.Drawing.Point(19, 99);
            this.Tajinder_RadioBtn.Name = "Tajinder_RadioBtn";
            this.Tajinder_RadioBtn.Size = new System.Drawing.Size(161, 21);
            this.Tajinder_RadioBtn.TabIndex = 3;
            this.Tajinder_RadioBtn.TabStop = true;
            this.Tajinder_RadioBtn.Tag = "2";
            this.Tajinder_RadioBtn.Text = "Tajinder_RadioBtn";
            this.Tajinder_RadioBtn.UseVisualStyleBackColor = true;
            this.Tajinder_RadioBtn.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
            // 
            // panelBets
            // 
            this.panelBets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelBets.Controls.Add(this.lblWinner);
            this.panelBets.Controls.Add(this.label2);
            this.panelBets.Controls.Add(this.lblTajinder);
            this.panelBets.Controls.Add(this.lblJashandeep);
            this.panelBets.Controls.Add(this.lblJagdeep);
            this.panelBets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBets.Location = new System.Drawing.Point(0, 0);
            this.panelBets.Name = "panelBets";
            this.panelBets.Size = new System.Drawing.Size(762, 136);
            this.panelBets.TabIndex = 19;
            this.panelBets.Visible = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(208, 25);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 13);
            this.lblWinner.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bets";
            // 
            // lblTajinder
            // 
            this.lblTajinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTajinder.Location = new System.Drawing.Point(13, 94);
            this.lblTajinder.Name = "lblTajinder";
            this.lblTajinder.Size = new System.Drawing.Size(388, 17);
            this.lblTajinder.TabIndex = 18;
            this.lblTajinder.Text = "label3";
            // 
            // lblJashandeep
            // 
            this.lblJashandeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJashandeep.Location = new System.Drawing.Point(13, 48);
            this.lblJashandeep.Name = "lblJashandeep";
            this.lblJashandeep.Size = new System.Drawing.Size(388, 17);
            this.lblJashandeep.TabIndex = 16;
            this.lblJashandeep.Text = "label3";
            // 
            // lblJagdeep
            // 
            this.lblJagdeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJagdeep.Location = new System.Drawing.Point(13, 71);
            this.lblJagdeep.Name = "lblJagdeep";
            this.lblJagdeep.Size = new System.Drawing.Size(388, 17);
            this.lblJagdeep.TabIndex = 17;
            this.lblJagdeep.Text = "label3";
            // 
            // panelBetting
            // 
            this.panelBetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelBetting.Controls.Add(this.btnRestart);
            this.panelBetting.Controls.Add(this.btnNewRace);
            this.panelBetting.Controls.Add(this.btnRace);
            this.panelBetting.Controls.Add(this.lblBettor);
            this.panelBetting.Controls.Add(this.btnBet);
            this.panelBetting.Controls.Add(this.nudCash);
            this.panelBetting.Controls.Add(this.label1);
            this.panelBetting.Controls.Add(this.nudRabbitNumber);
            this.panelBetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBetting.Location = new System.Drawing.Point(0, 0);
            this.panelBetting.Name = "panelBetting";
            this.panelBetting.Size = new System.Drawing.Size(1147, 67);
            this.panelBetting.TabIndex = 15;
            this.panelBetting.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatAppearance.BorderSize = 5;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Linen;
            this.btnRestart.Location = new System.Drawing.Point(982, 9);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(142, 43);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Reset Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnNewRace
            // 
            this.btnNewRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNewRace.FlatAppearance.BorderSize = 5;
            this.btnNewRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRace.ForeColor = System.Drawing.Color.Linen;
            this.btnNewRace.Location = new System.Drawing.Point(797, 11);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(146, 43);
            this.btnNewRace.TabIndex = 10;
            this.btnNewRace.Text = "New Race";
            this.btnNewRace.UseVisualStyleBackColor = false;
            this.btnNewRace.Visible = false;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRace.FlatAppearance.BorderSize = 5;
            this.btnRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.Linen;
            this.btnRace.Location = new System.Drawing.Point(653, 12);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(94, 43);
            this.btnRace.TabIndex = 9;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Visible = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBettor.Location = new System.Drawing.Point(20, 11);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(52, 17);
            this.lblBettor.TabIndex = 4;
            this.lblBettor.Text = "label1";
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBet.FlatAppearance.BorderSize = 5;
            this.btnBet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.Color.Linen;
            this.btnBet.Location = new System.Drawing.Point(422, 11);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(184, 44);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "Bet for ...";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // nudCash
            // 
            this.nudCash.Location = new System.Drawing.Point(261, 9);
            this.nudCash.Name = "nudCash";
            this.nudCash.Size = new System.Drawing.Size(120, 20);
            this.nudCash.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "bucks on Rabbit number";
            // 
            // nudRabbitNumber
            // 
            this.nudRabbitNumber.Location = new System.Drawing.Point(261, 35);
            this.nudRabbitNumber.Name = "nudRabbitNumber";
            this.nudRabbitNumber.Size = new System.Drawing.Size(120, 20);
            this.nudRabbitNumber.TabIndex = 8;
            this.nudRabbitNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1151, 737);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBets.ResumeLayout(false);
            this.panelBets.PerformLayout();
            this.panelBetting.ResumeLayout(false);
            this.panelBetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRabbitNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRace;
        private NumericUpDown nudRabbitNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCash;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.RadioButton Tajinder_RadioBtn;
        private System.Windows.Forms.RadioButton Jagdeep_RadioBtn;
        private System.Windows.Forms.RadioButton Jashandeep_RadioBtn;
        private System.Windows.Forms.Label lblMinimumBet;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.Panel panelBetting;
        private System.Windows.Forms.Label lblTajinder;
        private System.Windows.Forms.Label lblJagdeep;
        private System.Windows.Forms.Label lblJashandeep;
        private System.Windows.Forms.Panel panelBets;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Panel panel2;
        private Button btnNewRace;
        private Label lblWinner;
        private PictureBox pb2;
        private Button btnRestart;
    }
}
