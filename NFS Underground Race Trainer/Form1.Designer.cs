namespace NFS_Underground_Race_Trainer
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
            this.chbTimeTrial = new System.Windows.Forms.CheckBox();
            this.numTimeHours = new System.Windows.Forms.NumericUpDown();
            this.numTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.numTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblReverse = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLapCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeSeconds)).BeginInit();
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
            this.btnActivate.Location = new System.Drawing.Point(55, 47);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(113, 33);
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
            this.lblAvailable.Location = new System.Drawing.Point(31, 5);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(53, 20);
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
            "-------------Circuit--------------",
            "Market Street",
            "Stadium",
            "Olympic Square",
            "Terminal",
            "Atlantica",
            "Inner City",
            "Port Royal",
            "National Rail",
            "Secret track",
            "-------------Sprint---------------",
            "Liberty Gardens",
            "Broadway",
            "Lock Up",
            "9th. & Frey",
            "Beddard Bridge",
            "Spillway",
            "1st Ave. Truck Stop",
            "7th & Sparkling",
            "-------------Drag---------------",
            "14th and Vine Construction",
            "Highway 1",
            "Main street",
            "Commercial",
            "14th and Vine",
            "Main Street Construction",
            "-------------Drift---------------",
            "Drift Track 1",
            "Drift Track 2",
            "Drift Track 3",
            "Drift Track 4",
            "Drift Track 5",
            "Drift Track 6",
            "Drift Track 7",
            "Drift Track 8"});
            this.cbRaces.Location = new System.Drawing.Point(16, 121);
            this.cbRaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRaces.Name = "cbRaces";
            this.cbRaces.Size = new System.Drawing.Size(212, 28);
            this.cbRaces.TabIndex = 2;
            this.cbRaces.SelectedValueChanged += new System.EventHandler(this.cbRaces_SelectedValueChanged);
            // 
            // numLapCount
            // 
            this.numLapCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLapCount.Location = new System.Drawing.Point(152, 158);
            this.numLapCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numLapCount.Size = new System.Drawing.Size(77, 26);
            this.numLapCount.TabIndex = 3;
            // 
            // chbLapCount
            // 
            this.chbLapCount.AutoSize = true;
            this.chbLapCount.BackColor = System.Drawing.Color.Transparent;
            this.chbLapCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLapCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chbLapCount.Location = new System.Drawing.Point(16, 159);
            this.chbLapCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbLapCount.Name = "chbLapCount";
            this.chbLapCount.Size = new System.Drawing.Size(116, 24);
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
            this.cbReversed.Location = new System.Drawing.Point(16, 212);
            this.cbReversed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReversed.Name = "cbReversed";
            this.cbReversed.Size = new System.Drawing.Size(212, 28);
            this.cbReversed.TabIndex = 5;
            // 
            // lblTrainerActivated
            // 
            this.lblTrainerActivated.AutoSize = true;
            this.lblTrainerActivated.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainerActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerActivated.ForeColor = System.Drawing.Color.Red;
            this.lblTrainerActivated.Location = new System.Drawing.Point(31, 26);
            this.lblTrainerActivated.Name = "lblTrainerActivated";
            this.lblTrainerActivated.Size = new System.Drawing.Size(157, 20);
            this.lblTrainerActivated.TabIndex = 6;
            this.lblTrainerActivated.Text = "Trainer is not active";
            // 
            // chbTimeTrial
            // 
            this.chbTimeTrial.AutoSize = true;
            this.chbTimeTrial.BackColor = System.Drawing.Color.Transparent;
            this.chbTimeTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTimeTrial.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chbTimeTrial.Location = new System.Drawing.Point(16, 247);
            this.chbTimeTrial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbTimeTrial.Name = "chbTimeTrial";
            this.chbTimeTrial.Size = new System.Drawing.Size(106, 24);
            this.chbTimeTrial.TabIndex = 8;
            this.chbTimeTrial.Text = "Time Trial";
            this.chbTimeTrial.UseVisualStyleBackColor = false;
            this.chbTimeTrial.CheckedChanged += new System.EventHandler(this.chbTimeTrial_CheckedChanged);
            // 
            // numTimeHours
            // 
            this.numTimeHours.Enabled = false;
            this.numTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimeHours.Location = new System.Drawing.Point(16, 298);
            this.numTimeHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTimeHours.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numTimeHours.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numTimeHours.Name = "numTimeHours";
            this.numTimeHours.Size = new System.Drawing.Size(68, 26);
            this.numTimeHours.TabIndex = 9;
            // 
            // numTimeMinutes
            // 
            this.numTimeMinutes.Enabled = false;
            this.numTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimeMinutes.Location = new System.Drawing.Point(92, 298);
            this.numTimeMinutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTimeMinutes.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numTimeMinutes.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numTimeMinutes.Name = "numTimeMinutes";
            this.numTimeMinutes.Size = new System.Drawing.Size(64, 26);
            this.numTimeMinutes.TabIndex = 10;
            // 
            // numTimeSeconds
            // 
            this.numTimeSeconds.Enabled = false;
            this.numTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimeSeconds.Location = new System.Drawing.Point(164, 298);
            this.numTimeSeconds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTimeSeconds.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numTimeSeconds.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numTimeSeconds.Name = "numTimeSeconds";
            this.numTimeSeconds.Size = new System.Drawing.Size(63, 26);
            this.numTimeSeconds.TabIndex = 11;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.Transparent;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHours.Location = new System.Drawing.Point(15, 276);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(50, 18);
            this.lblHours.TabIndex = 12;
            this.lblHours.Text = "hours ";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMinutes.Location = new System.Drawing.Point(88, 277);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(60, 18);
            this.lblMinutes.TabIndex = 13;
            this.lblMinutes.Text = "minutes";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSeconds.Location = new System.Drawing.Point(160, 277);
            this.lblSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(65, 18);
            this.lblSeconds.TabIndex = 14;
            this.lblSeconds.Text = "seconds";
            // 
            // lblReverse
            // 
            this.lblReverse.AutoSize = true;
            this.lblReverse.BackColor = System.Drawing.Color.Transparent;
            this.lblReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReverse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblReverse.Location = new System.Drawing.Point(16, 188);
            this.lblReverse.Name = "lblReverse";
            this.lblReverse.Size = new System.Drawing.Size(76, 20);
            this.lblReverse.TabIndex = 15;
            this.lblReverse.Text = "Reverse:";
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.BackColor = System.Drawing.Color.Transparent;
            this.lblTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTrack.Location = new System.Drawing.Point(15, 97);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(100, 20);
            this.lblTrack.TabIndex = 16;
            this.lblTrack.Text = "Set track to:";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(309, 298);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 28);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.Location = new System.Drawing.Point(417, 298);
            this.btnGithub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(100, 28);
            this.btnGithub.TabIndex = 18;
            this.btnGithub.Text = "Github";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(525, 298);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacebook.BackgroundImage")));
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Location = new System.Drawing.Point(506, 5);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(40, 40);
            this.btnFacebook.TabIndex = 20;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYoutube.BackgroundImage")));
            this.btnYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutube.Location = new System.Drawing.Point(552, 5);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(40, 40);
            this.btnYoutube.TabIndex = 21;
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(598, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(40, 40);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 346);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnYoutube);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.lblReverse);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.numTimeSeconds);
            this.Controls.Add(this.numTimeMinutes);
            this.Controls.Add(this.numTimeHours);
            this.Controls.Add(this.chbTimeTrial);
            this.Controls.Add(this.lblTrainerActivated);
            this.Controls.Add(this.cbReversed);
            this.Controls.Add(this.chbLapCount);
            this.Controls.Add(this.numLapCount);
            this.Controls.Add(this.cbRaces);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.btnActivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NFS Underground Race Trainer ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLapCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeSeconds)).EndInit();
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
        private System.Windows.Forms.CheckBox chbTimeTrial;
        private System.Windows.Forms.NumericUpDown numTimeHours;
        private System.Windows.Forms.NumericUpDown numTimeMinutes;
        private System.Windows.Forms.NumericUpDown numTimeSeconds;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblReverse;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Button btnHelp;
    }
}

