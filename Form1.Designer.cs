﻿namespace Hangman
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rad34 = new System.Windows.Forms.RadioButton();
            this.rad56 = new System.Windows.Forms.RadioButton();
            this.rad78 = new System.Windows.Forms.RadioButton();
            this.gpbSize = new System.Windows.Forms.GroupBox();
            this.grbDiff = new System.Windows.Forms.GroupBox();
            this.radHard = new System.Windows.Forms.RadioButton();
            this.radMed = new System.Windows.Forms.RadioButton();
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.Hangman = new System.Windows.Forms.GroupBox();
            this.ptb11 = new System.Windows.Forms.PictureBox();
            this.ptb10 = new System.Windows.Forms.PictureBox();
            this.ptb9 = new System.Windows.Forms.PictureBox();
            this.ptb8 = new System.Windows.Forms.PictureBox();
            this.ptb7 = new System.Windows.Forms.PictureBox();
            this.ptb6 = new System.Windows.Forms.PictureBox();
            this.ptb5 = new System.Windows.Forms.PictureBox();
            this.ptb4 = new System.Windows.Forms.PictureBox();
            this.ptb3 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.gbxLetters = new System.Windows.Forms.GroupBox();
            this.lblLet1 = new System.Windows.Forms.Label();
            this.lblLet2 = new System.Windows.Forms.Label();
            this.lblLet3 = new System.Windows.Forms.Label();
            this.lblLet4 = new System.Windows.Forms.Label();
            this.lblLet5 = new System.Windows.Forms.Label();
            this.lblLet6 = new System.Windows.Forms.Label();
            this.lblLet7 = new System.Windows.Forms.Label();
            this.lblLet8 = new System.Windows.Forms.Label();
            this.btnWSub = new System.Windows.Forms.Button();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gpbSize.SuspendLayout();
            this.grbDiff.SuspendLayout();
            this.Hangman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.gbxLetters.SuspendLayout();
            this.SuspendLayout();
            // 
            // rad34
            // 
            this.rad34.AutoSize = true;
            this.rad34.Location = new System.Drawing.Point(20, 34);
            this.rad34.Name = "rad34";
            this.rad34.Size = new System.Drawing.Size(75, 17);
            this.rad34.TabIndex = 2;
            this.rad34.TabStop = true;
            this.rad34.Text = "3-4 Letters";
            this.rad34.UseVisualStyleBackColor = true;
            // 
            // rad56
            // 
            this.rad56.AutoSize = true;
            this.rad56.Location = new System.Drawing.Point(20, 71);
            this.rad56.Name = "rad56";
            this.rad56.Size = new System.Drawing.Size(75, 17);
            this.rad56.TabIndex = 3;
            this.rad56.TabStop = true;
            this.rad56.Text = "5-6 Letters";
            this.rad56.UseVisualStyleBackColor = true;
            // 
            // rad78
            // 
            this.rad78.AutoSize = true;
            this.rad78.Location = new System.Drawing.Point(20, 105);
            this.rad78.Name = "rad78";
            this.rad78.Size = new System.Drawing.Size(75, 17);
            this.rad78.TabIndex = 4;
            this.rad78.TabStop = true;
            this.rad78.Text = "7-8 Letters";
            this.rad78.UseVisualStyleBackColor = true;
            // 
            // gpbSize
            // 
            this.gpbSize.Controls.Add(this.rad78);
            this.gpbSize.Controls.Add(this.rad56);
            this.gpbSize.Controls.Add(this.rad34);
            this.gpbSize.Location = new System.Drawing.Point(21, 267);
            this.gpbSize.Name = "gpbSize";
            this.gpbSize.Size = new System.Drawing.Size(138, 144);
            this.gpbSize.TabIndex = 5;
            this.gpbSize.TabStop = false;
            this.gpbSize.Text = "Word Size";
            // 
            // grbDiff
            // 
            this.grbDiff.Controls.Add(this.radHard);
            this.grbDiff.Controls.Add(this.radMed);
            this.grbDiff.Controls.Add(this.radEasy);
            this.grbDiff.Location = new System.Drawing.Point(21, 84);
            this.grbDiff.Name = "grbDiff";
            this.grbDiff.Size = new System.Drawing.Size(138, 144);
            this.grbDiff.TabIndex = 6;
            this.grbDiff.TabStop = false;
            this.grbDiff.Text = "Difficulty";
            // 
            // radHard
            // 
            this.radHard.AutoSize = true;
            this.radHard.Location = new System.Drawing.Point(20, 105);
            this.radHard.Name = "radHard";
            this.radHard.Size = new System.Drawing.Size(48, 17);
            this.radHard.TabIndex = 4;
            this.radHard.TabStop = true;
            this.radHard.Text = "Hard";
            this.radHard.UseVisualStyleBackColor = true;
            // 
            // radMed
            // 
            this.radMed.AutoSize = true;
            this.radMed.Location = new System.Drawing.Point(20, 71);
            this.radMed.Name = "radMed";
            this.radMed.Size = new System.Drawing.Size(62, 17);
            this.radMed.TabIndex = 3;
            this.radMed.TabStop = true;
            this.radMed.Text = "Medium";
            this.radMed.UseVisualStyleBackColor = true;
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.Location = new System.Drawing.Point(20, 34);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(48, 17);
            this.radEasy.TabIndex = 2;
            this.radEasy.TabStop = true;
            this.radEasy.Text = "Easy";
            this.radEasy.UseVisualStyleBackColor = true;
            // 
            // Hangman
            // 
            this.Hangman.BackColor = System.Drawing.Color.White;
            this.Hangman.Controls.Add(this.ptb11);
            this.Hangman.Controls.Add(this.ptb10);
            this.Hangman.Controls.Add(this.ptb9);
            this.Hangman.Controls.Add(this.ptb8);
            this.Hangman.Controls.Add(this.ptb7);
            this.Hangman.Controls.Add(this.ptb6);
            this.Hangman.Controls.Add(this.ptb5);
            this.Hangman.Controls.Add(this.ptb4);
            this.Hangman.Controls.Add(this.ptb3);
            this.Hangman.Controls.Add(this.ptb2);
            this.Hangman.Controls.Add(this.ptb1);
            this.Hangman.Location = new System.Drawing.Point(201, 35);
            this.Hangman.Name = "Hangman";
            this.Hangman.Size = new System.Drawing.Size(300, 304);
            this.Hangman.TabIndex = 9;
            this.Hangman.TabStop = false;
            this.Hangman.Text = "groupBox3";
            // 
            // ptb11
            // 
            this.ptb11.Image = global::Hangman.Properties.Resources.Step4;
            this.ptb11.Location = new System.Drawing.Point(190, 206);
            this.ptb11.Name = "ptb11";
            this.ptb11.Size = new System.Drawing.Size(52, 50);
            this.ptb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb11.TabIndex = 17;
            this.ptb11.TabStop = false;
            // 
            // ptb10
            // 
            this.ptb10.Image = global::Hangman.Properties.Resources.Step3;
            this.ptb10.Location = new System.Drawing.Point(137, 209);
            this.ptb10.Name = "ptb10";
            this.ptb10.Size = new System.Drawing.Size(53, 47);
            this.ptb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb10.TabIndex = 16;
            this.ptb10.TabStop = false;
            // 
            // ptb9
            // 
            this.ptb9.Image = global::Hangman.Properties.Resources.Step1;
            this.ptb9.Location = new System.Drawing.Point(195, 144);
            this.ptb9.Name = "ptb9";
            this.ptb9.Size = new System.Drawing.Size(58, 10);
            this.ptb9.TabIndex = 15;
            this.ptb9.TabStop = false;
            // 
            // ptb8
            // 
            this.ptb8.Image = global::Hangman.Properties.Resources.Step1;
            this.ptb8.Location = new System.Drawing.Point(137, 144);
            this.ptb8.Name = "ptb8";
            this.ptb8.Size = new System.Drawing.Size(52, 10);
            this.ptb8.TabIndex = 14;
            this.ptb8.TabStop = false;
            // 
            // ptb7
            // 
            this.ptb7.Image = global::Hangman.Properties.Resources.Step1;
            this.ptb7.Location = new System.Drawing.Point(185, 117);
            this.ptb7.Name = "ptb7";
            this.ptb7.Size = new System.Drawing.Size(10, 103);
            this.ptb7.TabIndex = 13;
            this.ptb7.TabStop = false;
            // 
            // ptb6
            // 
            this.ptb6.Image = global::Hangman.Properties.Resources.Step21;
            this.ptb6.Location = new System.Drawing.Point(169, 81);
            this.ptb6.Name = "ptb6";
            this.ptb6.Size = new System.Drawing.Size(44, 40);
            this.ptb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb6.TabIndex = 12;
            this.ptb6.TabStop = false;
            // 
            // ptb5
            // 
            this.ptb5.Image = global::Hangman.Properties.Resources.Step1;
            this.ptb5.Location = new System.Drawing.Point(185, 34);
            this.ptb5.Name = "ptb5";
            this.ptb5.Size = new System.Drawing.Size(10, 50);
            this.ptb5.TabIndex = 11;
            this.ptb5.TabStop = false;
            // 
            // ptb4
            // 
            this.ptb4.Image = global::Hangman.Properties.Resources.Step1;
            this.ptb4.Location = new System.Drawing.Point(113, 34);
            this.ptb4.Name = "ptb4";
            this.ptb4.Size = new System.Drawing.Size(80, 10);
            this.ptb4.TabIndex = 10;
            this.ptb4.TabStop = false;
            // 
            // ptb3
            // 
            this.ptb3.Image = global::Hangman.Properties.Resources.Step1;
            this.ptb3.Location = new System.Drawing.Point(68, 34);
            this.ptb3.Name = "ptb3";
            this.ptb3.Size = new System.Drawing.Size(62, 10);
            this.ptb3.TabIndex = 9;
            this.ptb3.TabStop = false;
            // 
            // ptb2
            // 
            this.ptb2.Image = global::Hangman.Properties.Resources.Step1;
            this.ptb2.Location = new System.Drawing.Point(61, 34);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(10, 224);
            this.ptb2.TabIndex = 8;
            this.ptb2.TabStop = false;
            // 
            // ptb1
            // 
            this.ptb1.Image = ((System.Drawing.Image)(resources.GetObject("ptb1.Image")));
            this.ptb1.Location = new System.Drawing.Point(22, 254);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(84, 10);
            this.ptb1.TabIndex = 7;
            this.ptb1.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(21, 23);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(35, 35);
            this.btnA.TabIndex = 10;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(58, 23);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(35, 35);
            this.btnB.TabIndex = 11;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(95, 23);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(35, 35);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(132, 23);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(35, 35);
            this.btnD.TabIndex = 13;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(169, 23);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(35, 35);
            this.btnE.TabIndex = 14;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(21, 67);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(35, 35);
            this.btnF.TabIndex = 15;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(58, 67);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(35, 35);
            this.btnG.TabIndex = 16;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(95, 67);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(35, 35);
            this.btnH.TabIndex = 17;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(132, 67);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(35, 35);
            this.btnI.TabIndex = 18;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(169, 67);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(35, 35);
            this.btnJ.TabIndex = 19;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(21, 111);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(35, 35);
            this.btnK.TabIndex = 20;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(58, 111);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(35, 35);
            this.btnL.TabIndex = 21;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(95, 111);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(35, 35);
            this.btnM.TabIndex = 22;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(132, 111);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(35, 35);
            this.btnN.TabIndex = 23;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(169, 111);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(35, 35);
            this.btnO.TabIndex = 24;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(21, 158);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(35, 35);
            this.btnP.TabIndex = 25;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(58, 158);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(35, 35);
            this.btnQ.TabIndex = 26;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(95, 158);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(35, 35);
            this.btnR.TabIndex = 27;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(132, 158);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(35, 35);
            this.btnS.TabIndex = 28;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(169, 158);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(35, 35);
            this.btnT.TabIndex = 29;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(21, 205);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(35, 35);
            this.btnU.TabIndex = 30;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(58, 205);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(35, 35);
            this.btnV.TabIndex = 31;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(95, 205);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(35, 35);
            this.btnW.TabIndex = 32;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(132, 205);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(35, 35);
            this.btnX.TabIndex = 33;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(169, 205);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(35, 35);
            this.btnY.TabIndex = 34;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(169, 249);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(35, 35);
            this.btnZ.TabIndex = 35;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // gbxLetters
            // 
            this.gbxLetters.Controls.Add(this.btnZ);
            this.gbxLetters.Controls.Add(this.btnY);
            this.gbxLetters.Controls.Add(this.btnX);
            this.gbxLetters.Controls.Add(this.btnW);
            this.gbxLetters.Controls.Add(this.btnV);
            this.gbxLetters.Controls.Add(this.btnU);
            this.gbxLetters.Controls.Add(this.btnT);
            this.gbxLetters.Controls.Add(this.btnS);
            this.gbxLetters.Controls.Add(this.btnR);
            this.gbxLetters.Controls.Add(this.btnQ);
            this.gbxLetters.Controls.Add(this.btnP);
            this.gbxLetters.Controls.Add(this.btnO);
            this.gbxLetters.Controls.Add(this.btnN);
            this.gbxLetters.Controls.Add(this.btnM);
            this.gbxLetters.Controls.Add(this.btnL);
            this.gbxLetters.Controls.Add(this.btnK);
            this.gbxLetters.Controls.Add(this.btnJ);
            this.gbxLetters.Controls.Add(this.btnI);
            this.gbxLetters.Controls.Add(this.btnH);
            this.gbxLetters.Controls.Add(this.btnG);
            this.gbxLetters.Controls.Add(this.btnF);
            this.gbxLetters.Controls.Add(this.btnE);
            this.gbxLetters.Controls.Add(this.btnD);
            this.gbxLetters.Controls.Add(this.btnC);
            this.gbxLetters.Controls.Add(this.btnB);
            this.gbxLetters.Controls.Add(this.btnA);
            this.gbxLetters.Location = new System.Drawing.Point(558, 12);
            this.gbxLetters.Name = "gbxLetters";
            this.gbxLetters.Size = new System.Drawing.Size(216, 306);
            this.gbxLetters.TabIndex = 1;
            this.gbxLetters.TabStop = false;
            this.gbxLetters.Text = "Letters";
            // 
            // lblLet1
            // 
            this.lblLet1.AutoSize = true;
            this.lblLet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet1.Location = new System.Drawing.Point(177, 417);
            this.lblLet1.Name = "lblLet1";
            this.lblLet1.Size = new System.Drawing.Size(44, 44);
            this.lblLet1.TabIndex = 37;
            this.lblLet1.Text = "A";
            // 
            // lblLet2
            // 
            this.lblLet2.AutoSize = true;
            this.lblLet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet2.Location = new System.Drawing.Point(228, 417);
            this.lblLet2.Name = "lblLet2";
            this.lblLet2.Size = new System.Drawing.Size(44, 44);
            this.lblLet2.TabIndex = 38;
            this.lblLet2.Text = "A";
            // 
            // lblLet3
            // 
            this.lblLet3.AutoSize = true;
            this.lblLet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet3.Location = new System.Drawing.Point(278, 417);
            this.lblLet3.Name = "lblLet3";
            this.lblLet3.Size = new System.Drawing.Size(44, 44);
            this.lblLet3.TabIndex = 39;
            this.lblLet3.Text = "A";
            // 
            // lblLet4
            // 
            this.lblLet4.AutoSize = true;
            this.lblLet4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet4.Location = new System.Drawing.Point(328, 417);
            this.lblLet4.Name = "lblLet4";
            this.lblLet4.Size = new System.Drawing.Size(44, 44);
            this.lblLet4.TabIndex = 40;
            this.lblLet4.Text = "A";
            // 
            // lblLet5
            // 
            this.lblLet5.AutoSize = true;
            this.lblLet5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet5.Location = new System.Drawing.Point(378, 417);
            this.lblLet5.Name = "lblLet5";
            this.lblLet5.Size = new System.Drawing.Size(44, 44);
            this.lblLet5.TabIndex = 41;
            this.lblLet5.Text = "A";
            // 
            // lblLet6
            // 
            this.lblLet6.AutoSize = true;
            this.lblLet6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet6.Location = new System.Drawing.Point(428, 417);
            this.lblLet6.Name = "lblLet6";
            this.lblLet6.Size = new System.Drawing.Size(44, 44);
            this.lblLet6.TabIndex = 42;
            this.lblLet6.Text = "A";
            // 
            // lblLet7
            // 
            this.lblLet7.AutoSize = true;
            this.lblLet7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet7.Location = new System.Drawing.Point(478, 417);
            this.lblLet7.Name = "lblLet7";
            this.lblLet7.Size = new System.Drawing.Size(44, 44);
            this.lblLet7.TabIndex = 43;
            this.lblLet7.Text = "A";
            // 
            // lblLet8
            // 
            this.lblLet8.AutoSize = true;
            this.lblLet8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLet8.Location = new System.Drawing.Point(528, 417);
            this.lblLet8.Name = "lblLet8";
            this.lblLet8.Size = new System.Drawing.Size(44, 44);
            this.lblLet8.TabIndex = 44;
            this.lblLet8.Text = "A";
            // 
            // btnWSub
            // 
            this.btnWSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWSub.Location = new System.Drawing.Point(596, 468);
            this.btnWSub.Name = "btnWSub";
            this.btnWSub.Size = new System.Drawing.Size(150, 32);
            this.btnWSub.TabIndex = 46;
            this.btnWSub.Text = "Test Word";
            this.btnWSub.UseVisualStyleBackColor = true;
            this.btnWSub.Click += new System.EventHandler(this.btnWSub_Click);
            // 
            // tbxWord
            // 
            this.tbxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWord.Location = new System.Drawing.Point(597, 429);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(149, 23);
            this.tbxWord.TabIndex = 47;
            this.tbxWord.Text = "pencil";
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(21, 33);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(150, 32);
            this.btnGO.TabIndex = 48;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(598, 379);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 36);
            this.btnSubmit.TabIndex = 49;
            this.btnSubmit.Text = "Submit Letter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.tbxWord);
            this.Controls.Add(this.btnWSub);
            this.Controls.Add(this.lblLet8);
            this.Controls.Add(this.lblLet7);
            this.Controls.Add(this.lblLet6);
            this.Controls.Add(this.lblLet5);
            this.Controls.Add(this.lblLet4);
            this.Controls.Add(this.lblLet3);
            this.Controls.Add(this.lblLet2);
            this.Controls.Add(this.lblLet1);
            this.Controls.Add(this.gbxLetters);
            this.Controls.Add(this.Hangman);
            this.Controls.Add(this.grbDiff);
            this.Controls.Add(this.gpbSize);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.gpbSize.ResumeLayout(false);
            this.gpbSize.PerformLayout();
            this.grbDiff.ResumeLayout(false);
            this.grbDiff.PerformLayout();
            this.Hangman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.gbxLetters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rad34;
        private System.Windows.Forms.RadioButton rad56;
        private System.Windows.Forms.RadioButton rad78;
        private System.Windows.Forms.GroupBox gpbSize;
        private System.Windows.Forms.GroupBox grbDiff;
        private System.Windows.Forms.RadioButton radHard;
        private System.Windows.Forms.RadioButton radMed;
        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.GroupBox Hangman;
        private System.Windows.Forms.PictureBox ptb3;
        private System.Windows.Forms.PictureBox ptb6;
        private System.Windows.Forms.PictureBox ptb5;
        private System.Windows.Forms.PictureBox ptb4;
        private System.Windows.Forms.PictureBox ptb10;
        private System.Windows.Forms.PictureBox ptb9;
        private System.Windows.Forms.PictureBox ptb8;
        private System.Windows.Forms.PictureBox ptb7;
        private System.Windows.Forms.PictureBox ptb11;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
        public System.Windows.Forms.GroupBox gbxLetters;
        public System.Windows.Forms.Label lblLet1;
        private System.Windows.Forms.Label lblLet2;
        private System.Windows.Forms.Label lblLet3;
        private System.Windows.Forms.Label lblLet4;
        private System.Windows.Forms.Label lblLet5;
        private System.Windows.Forms.Label lblLet6;
        private System.Windows.Forms.Label lblLet7;
        private System.Windows.Forms.Label lblLet8;
        private System.Windows.Forms.Button btnWSub;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnSubmit;
    }
}

