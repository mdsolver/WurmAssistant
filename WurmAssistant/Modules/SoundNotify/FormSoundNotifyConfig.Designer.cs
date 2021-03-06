﻿namespace WurmAssistant
{
    partial class FormSoundNotifyConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoundNotifyConfig));
            this.listViewSounds = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpecials = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPlaylistHelp = new System.Windows.Forms.Button();
            this.buttonManageSNDBank = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.trackBarGlobalVolume = new System.Windows.Forms.TrackBar();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.checkBoxToggleQSound = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownQueueDelay = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClearQueSound = new System.Windows.Forms.Button();
            this.buttonQueSoundHelp = new System.Windows.Forms.Button();
            this.textBoxQueSoundName = new System.Windows.Forms.TextBox();
            this.buttonChangeQueSound = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlobalVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueueDelay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSounds
            // 
            this.listViewSounds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSounds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderSound,
            this.columnHeaderCondition,
            this.columnHeaderSpecials,
            this.columnHeaderActive});
            this.listViewSounds.FullRowSelect = true;
            this.listViewSounds.GridLines = true;
            this.listViewSounds.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSounds.HideSelection = false;
            this.listViewSounds.Location = new System.Drawing.Point(6, 21);
            this.listViewSounds.MultiSelect = false;
            this.listViewSounds.Name = "listViewSounds";
            this.listViewSounds.Size = new System.Drawing.Size(758, 285);
            this.listViewSounds.TabIndex = 0;
            this.listViewSounds.UseCompatibleStateImageBehavior = false;
            this.listViewSounds.View = System.Windows.Forms.View.Details;
            this.listViewSounds.DoubleClick += new System.EventHandler(this.listViewSounds_DoubleClick);
            this.listViewSounds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewSounds_KeyDown);
            this.listViewSounds.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSounds_MouseClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 0;
            // 
            // columnHeaderSound
            // 
            this.columnHeaderSound.Text = "Sound";
            this.columnHeaderSound.Width = 130;
            // 
            // columnHeaderCondition
            // 
            this.columnHeaderCondition.Text = "Condition";
            this.columnHeaderCondition.Width = 303;
            // 
            // columnHeaderSpecials
            // 
            this.columnHeaderSpecials.Text = "Special Options";
            this.columnHeaderSpecials.Width = 243;
            // 
            // columnHeaderActive
            // 
            this.columnHeaderActive.Text = "Active";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 47);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(200, 312);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(91, 47);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonPlaylistHelp);
            this.groupBox1.Controls.Add(this.buttonManageSNDBank);
            this.groupBox1.Controls.Add(this.buttonMute);
            this.groupBox1.Controls.Add(this.trackBarGlobalVolume);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.listViewSounds);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 365);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist Manager";
            // 
            // buttonPlaylistHelp
            // 
            this.buttonPlaylistHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlaylistHelp.Location = new System.Drawing.Point(707, 312);
            this.buttonPlaylistHelp.Name = "buttonPlaylistHelp";
            this.buttonPlaylistHelp.Size = new System.Drawing.Size(57, 47);
            this.buttonPlaylistHelp.TabIndex = 11;
            this.buttonPlaylistHelp.Text = "Help\r\n";
            this.buttonPlaylistHelp.UseVisualStyleBackColor = true;
            this.buttonPlaylistHelp.Click += new System.EventHandler(this.buttonPlaylistHelp_Click);
            // 
            // buttonManageSNDBank
            // 
            this.buttonManageSNDBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonManageSNDBank.Location = new System.Drawing.Point(320, 312);
            this.buttonManageSNDBank.Name = "buttonManageSNDBank";
            this.buttonManageSNDBank.Size = new System.Drawing.Size(104, 47);
            this.buttonManageSNDBank.TabIndex = 11;
            this.buttonManageSNDBank.Text = "Manage Sound Bank";
            this.buttonManageSNDBank.UseVisualStyleBackColor = true;
            this.buttonManageSNDBank.Click += new System.EventHandler(this.buttonManageSNDBank_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMute.Image = global::WurmAssistant.Properties.Resources.SoundEnabledSmall;
            this.buttonMute.Location = new System.Drawing.Point(450, 312);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(52, 47);
            this.buttonMute.TabIndex = 8;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // trackBarGlobalVolume
            // 
            this.trackBarGlobalVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarGlobalVolume.AutoSize = false;
            this.trackBarGlobalVolume.Location = new System.Drawing.Point(499, 321);
            this.trackBarGlobalVolume.Maximum = 100;
            this.trackBarGlobalVolume.Name = "trackBarGlobalVolume";
            this.trackBarGlobalVolume.Size = new System.Drawing.Size(202, 38);
            this.trackBarGlobalVolume.TabIndex = 11;
            this.trackBarGlobalVolume.Value = 100;
            this.trackBarGlobalVolume.Scroll += new System.EventHandler(this.trackBarGlobalVolume_Scroll);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(103, 312);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 47);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // checkBoxToggleQSound
            // 
            this.checkBoxToggleQSound.AutoSize = true;
            this.checkBoxToggleQSound.Location = new System.Drawing.Point(6, 27);
            this.checkBoxToggleQSound.Name = "checkBoxToggleQSound";
            this.checkBoxToggleQSound.Size = new System.Drawing.Size(275, 21);
            this.checkBoxToggleQSound.TabIndex = 3;
            this.checkBoxToggleQSound.Text = "Enable action queue sound notification";
            this.checkBoxToggleQSound.UseVisualStyleBackColor = true;
            this.checkBoxToggleQSound.CheckedChanged += new System.EventHandler(this.checkBoxToggleQSound_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Queue sound delay (seconds):";
            // 
            // numericUpDownQueueDelay
            // 
            this.numericUpDownQueueDelay.DecimalPlaces = 1;
            this.numericUpDownQueueDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownQueueDelay.Location = new System.Drawing.Point(212, 122);
            this.numericUpDownQueueDelay.Name = "numericUpDownQueueDelay";
            this.numericUpDownQueueDelay.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownQueueDelay.TabIndex = 7;
            this.numericUpDownQueueDelay.ValueChanged += new System.EventHandler(this.numericUpDownQueueDelay_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonClearQueSound);
            this.groupBox2.Controls.Add(this.buttonQueSoundHelp);
            this.groupBox2.Controls.Add(this.textBoxQueSoundName);
            this.groupBox2.Controls.Add(this.buttonChangeQueSound);
            this.groupBox2.Controls.Add(this.checkBoxToggleQSound);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownQueueDelay);
            this.groupBox2.Location = new System.Drawing.Point(12, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 155);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Queue Sound Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current sound:";
            // 
            // buttonClearQueSound
            // 
            this.buttonClearQueSound.Location = new System.Drawing.Point(222, 54);
            this.buttonClearQueSound.Name = "buttonClearQueSound";
            this.buttonClearQueSound.Size = new System.Drawing.Size(105, 30);
            this.buttonClearQueSound.TabIndex = 11;
            this.buttonClearQueSound.Text = "reset default";
            this.buttonClearQueSound.UseVisualStyleBackColor = true;
            this.buttonClearQueSound.Click += new System.EventHandler(this.buttonClearQueSound_Click);
            // 
            // buttonQueSoundHelp
            // 
            this.buttonQueSoundHelp.Location = new System.Drawing.Point(298, 20);
            this.buttonQueSoundHelp.Name = "buttonQueSoundHelp";
            this.buttonQueSoundHelp.Size = new System.Drawing.Size(26, 28);
            this.buttonQueSoundHelp.TabIndex = 10;
            this.buttonQueSoundHelp.Text = "?";
            this.buttonQueSoundHelp.UseVisualStyleBackColor = true;
            this.buttonQueSoundHelp.Click += new System.EventHandler(this.buttonQueSoundHelp_Click);
            // 
            // textBoxQueSoundName
            // 
            this.textBoxQueSoundName.Location = new System.Drawing.Point(111, 90);
            this.textBoxQueSoundName.Name = "textBoxQueSoundName";
            this.textBoxQueSoundName.ReadOnly = true;
            this.textBoxQueSoundName.Size = new System.Drawing.Size(213, 22);
            this.textBoxQueSoundName.TabIndex = 9;
            // 
            // buttonChangeQueSound
            // 
            this.buttonChangeQueSound.Location = new System.Drawing.Point(6, 54);
            this.buttonChangeQueSound.Name = "buttonChangeQueSound";
            this.buttonChangeQueSound.Size = new System.Drawing.Size(210, 30);
            this.buttonChangeQueSound.TabIndex = 8;
            this.buttonChangeQueSound.Text = "Change sound";
            this.buttonChangeQueSound.UseVisualStyleBackColor = true;
            this.buttonChangeQueSound.Click += new System.EventHandler(this.buttonChangeQueSound_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Powered by:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WurmAssistant.Properties.Resources.irrklang_small;
            this.pictureBox1.Location = new System.Drawing.Point(634, 493);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 13;
            // 
            // FormSoundNotifyConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 540);
            this.Name = "FormSoundNotifyConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundNotify Manager";
            this.Load += new System.EventHandler(this.FormWarningsConfig_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlobalVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueueDelay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSounds;
        private System.Windows.Forms.ColumnHeader columnHeaderSound;
        private System.Windows.Forms.ColumnHeader columnHeaderCondition;
        private System.Windows.Forms.ColumnHeader columnHeaderSpecials;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownQueueDelay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxToggleQSound;
        private System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.TrackBar trackBarGlobalVolume;
        private System.Windows.Forms.Button buttonManageSNDBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeaderActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQueSoundName;
        private System.Windows.Forms.Button buttonChangeQueSound;
        private System.Windows.Forms.Button buttonQueSoundHelp;
        private System.Windows.Forms.Button buttonPlaylistHelp;
        private System.Windows.Forms.Button buttonClearQueSound;
        private System.Windows.Forms.Label label4;

    }
}