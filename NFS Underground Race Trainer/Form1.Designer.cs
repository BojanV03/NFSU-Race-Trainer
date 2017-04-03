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
            this.cbLapCount = new System.Windows.Forms.CheckBox();
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
            this.btnActivate.Location = new System.Drawing.Point(55, 52);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(100, 33);
            this.btnActivate.TabIndex = 0;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailable.Location = new System.Drawing.Point(31, 9);
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
            this.cbRaces.Location = new System.Drawing.Point(15, 91);
            this.cbRaces.Name = "cbRaces";
            this.cbRaces.Size = new System.Drawing.Size(184, 24);
            this.cbRaces.TabIndex = 2;
            this.cbRaces.SelectedValueChanged += new System.EventHandler(this.cbRaces_SelectedValueChanged);
            // 
            // numLapCount
            // 
            this.numLapCount.Location = new System.Drawing.Point(122, 120);
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
            this.numLapCount.Size = new System.Drawing.Size(77, 22);
            this.numLapCount.TabIndex = 3;
            // 
            // cbLapCount
            // 
            this.cbLapCount.AutoSize = true;
            this.cbLapCount.BackColor = System.Drawing.Color.Transparent;
            this.cbLapCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbLapCount.Location = new System.Drawing.Point(15, 121);
            this.cbLapCount.Name = "cbLapCount";
            this.cbLapCount.Size = new System.Drawing.Size(101, 21);
            this.cbLapCount.TabIndex = 4;
            this.cbLapCount.Text = "Set laps to:";
            this.cbLapCount.UseVisualStyleBackColor = false;
            // 
            // cbReversed
            // 
            this.cbReversed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReversed.FormattingEnabled = true;
            this.cbReversed.Items.AddRange(new object[] {
            "Don\'t Change",
            "Standard",
            "Reversed"});
            this.cbReversed.Location = new System.Drawing.Point(15, 150);
            this.cbReversed.Name = "cbReversed";
            this.cbReversed.Size = new System.Drawing.Size(184, 24);
            this.cbReversed.TabIndex = 5;
            // 
            // lblTrainerActivated
            // 
            this.lblTrainerActivated.AutoSize = true;
            this.lblTrainerActivated.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainerActivated.ForeColor = System.Drawing.Color.Red;
            this.lblTrainerActivated.Location = new System.Drawing.Point(31, 26);
            this.lblTrainerActivated.Name = "lblTrainerActivated";
            this.lblTrainerActivated.Size = new System.Drawing.Size(133, 17);
            this.lblTrainerActivated.TabIndex = 6;
            this.lblTrainerActivated.Text = "Trainer is not active";
            // 
            // cbNumOfOpponents
            // 
            this.cbNumOfOpponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumOfOpponents.FormattingEnabled = true;
            this.cbNumOfOpponents.Items.AddRange(new object[] {
            "Don\'t Change",
            "0 opponents",
            "1 opponent",
            "2 opponents",
            "3 opponents"});
            this.cbNumOfOpponents.Location = new System.Drawing.Point(15, 180);
            this.cbNumOfOpponents.Name = "cbNumOfOpponents";
            this.cbNumOfOpponents.Size = new System.Drawing.Size(184, 24);
            this.cbNumOfOpponents.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 358);
            this.Controls.Add(this.cbNumOfOpponents);
            this.Controls.Add(this.lblTrainerActivated);
            this.Controls.Add(this.cbReversed);
            this.Controls.Add(this.cbLapCount);
            this.Controls.Add(this.numLapCount);
            this.Controls.Add(this.cbRaces);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.btnActivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.CheckBox cbLapCount;
        private System.Windows.Forms.ComboBox cbReversed;
        private System.Windows.Forms.Label lblTrainerActivated;
        private System.Windows.Forms.ComboBox cbNumOfOpponents;
    }
}

