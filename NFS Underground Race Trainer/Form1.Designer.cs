﻿namespace NFS_Underground_Race_Trainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameAvailable = new System.Windows.Forms.Timer(this.components);
            this.updateCheats = new System.Windows.Forms.Timer(this.components);
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.cbRaces = new System.Windows.Forms.ComboBox();
            this.numLapCount = new System.Windows.Forms.NumericUpDown();
            this.chbLapCount = new System.Windows.Forms.CheckBox();
            this.cbReversed = new System.Windows.Forms.ComboBox();
            this.lblTrainerActivated = new System.Windows.Forms.Label();
            this.cbNumOfOpponents = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLapCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gameAvailable
            // 
            this.gameAvailable.Enabled = true;
            this.gameAvailable.Tick += new System.EventHandler(this.gameAvailable_Tick);
            // 
            // updateCheats
            // 
            this.updateCheats.Interval = 250;
            this.updateCheats.Tick += new System.EventHandler(this.updateCheats_Tick);
            // 
            // btnActivate
            // 
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Location = new System.Drawing.Point(41, 42);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 27);
            this.btnActivate.TabIndex = 0;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(23, 4);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(46, 17);
            this.lblAvailable.TabIndex = 1;
            this.lblAvailable.Text = "label1";
            // 
            // cbRaces
            // 
            this.cbRaces.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRaces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRaces.DropDownHeight = 500;
            this.cbRaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaces.FormattingEnabled = true;
            this.cbRaces.IntegralHeight = false;
            this.cbRaces.Items.AddRange(new object[] {
            "Don\'t Change",
            "-------------------Circuit-------------------",
            "Market Street",
            "Stadium",
            "Olympic Square",
            "Terminal",
            "Atlantica",
            "Inner City",
            "Port Royal",
            "National Rail",
            "Secret track",
            "-------------------Sprint-------------------",
            "Liberty Gardens",
            "Broadway",
            "Lock Up",
            "9th. & Frey",
            "Beddard Bridge",
            "Spillway",
            "1st Ave. Truck Stop",
            "7th & Sparkling",
            "-------------------Drag-------------------",
            "14th and Vine Construction",
            "Highway 1",
            "Main street",
            "Commercial",
            "14th and Vine",
            "Main Street Construction",
            "-------------------Drift-------------------",
            "Drift Track 1",
            "Drift Track 2",
            "Drift Track 3",
            "Drift Track 4",
            "Drift Track 5",
            "Drift Track 6",
            "Drift Track 7",
            "Drift Track 8"});
            this.cbRaces.Location = new System.Drawing.Point(11, 74);
            this.cbRaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRaces.Name = "cbRaces";
            this.cbRaces.Size = new System.Drawing.Size(160, 24);
            this.cbRaces.TabIndex = 2;
            this.cbRaces.SelectedValueChanged += new System.EventHandler(this.cbRaces_SelectedValueChanged);
            // 
            // numLapCount
            // 
            this.numLapCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLapCount.Location = new System.Drawing.Point(113, 102);
            this.numLapCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numLapCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numLapCount.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numLapCount.Name = "numLapCount";
            this.numLapCount.Size = new System.Drawing.Size(58, 23);
            this.numLapCount.TabIndex = 3;
            // 
            // chbLapCount
            // 
            this.chbLapCount.AutoSize = true;
            this.chbLapCount.BackColor = System.Drawing.Color.Transparent;
            this.chbLapCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLapCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbLapCount.Location = new System.Drawing.Point(11, 102);
            this.chbLapCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbLapCount.Name = "chbLapCount";
            this.chbLapCount.Size = new System.Drawing.Size(98, 21);
            this.chbLapCount.TabIndex = 4;
            this.chbLapCount.Text = "Set laps to:";
            this.chbLapCount.UseVisualStyleBackColor = false;
            // 
            // cbReversed
            // 
            this.cbReversed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReversed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReversed.FormattingEnabled = true;
            this.cbReversed.Items.AddRange(new object[] {
            "Don\'t Change",
            "Standard",
            "Reversed"});
            this.cbReversed.Location = new System.Drawing.Point(11, 129);
            this.cbReversed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbReversed.Name = "cbReversed";
            this.cbReversed.Size = new System.Drawing.Size(160, 24);
            this.cbReversed.TabIndex = 5;
            // 
            // lblTrainerActivated
            // 
            this.lblTrainerActivated.AutoSize = true;
            this.lblTrainerActivated.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainerActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerActivated.ForeColor = System.Drawing.Color.Red;
            this.lblTrainerActivated.Location = new System.Drawing.Point(23, 21);
            this.lblTrainerActivated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainerActivated.Name = "lblTrainerActivated";
            this.lblTrainerActivated.Size = new System.Drawing.Size(133, 17);
            this.lblTrainerActivated.TabIndex = 6;
            this.lblTrainerActivated.Text = "Trainer is not active";
            // 
            // cbNumOfOpponents
            // 
            this.cbNumOfOpponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumOfOpponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumOfOpponents.FormattingEnabled = true;
            this.cbNumOfOpponents.Items.AddRange(new object[] {
            "Don\'t Change",
            "0 opponents",
            "1 opponent",
            "2 opponents",
            "3 opponents"});
            this.cbNumOfOpponents.Location = new System.Drawing.Point(10, 157);
            this.cbNumOfOpponents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNumOfOpponents.Name = "cbNumOfOpponents";
            this.cbNumOfOpponents.Size = new System.Drawing.Size(160, 24);
            this.cbNumOfOpponents.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 291);
            this.Controls.Add(this.cbNumOfOpponents);
            this.Controls.Add(this.lblTrainerActivated);
            this.Controls.Add(this.cbReversed);
            this.Controls.Add(this.chbLapCount);
            this.Controls.Add(this.numLapCount);
            this.Controls.Add(this.cbRaces);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.btnActivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NFSU2 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLapCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameAvailable;
        private System.Windows.Forms.Timer updateCheats;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ComboBox cbRaces;
        private System.Windows.Forms.NumericUpDown numLapCount;
        private System.Windows.Forms.CheckBox chbLapCount;
        private System.Windows.Forms.ComboBox cbReversed;
        private System.Windows.Forms.Label lblTrainerActivated;
        private System.Windows.Forms.ComboBox cbNumOfOpponents;
    }
}

