namespace ChatWheelSoundboard
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
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.soundLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num0ddb = new System.Windows.Forms.ComboBox();
            this.num1ddb = new System.Windows.Forms.ComboBox();
            this.num2ddb = new System.Windows.Forms.ComboBox();
            this.num4ddb = new System.Windows.Forms.ComboBox();
            this.num5ddb = new System.Windows.Forms.ComboBox();
            this.num6ddb = new System.Windows.Forms.ComboBox();
            this.num7ddb = new System.Windows.Forms.ComboBox();
            this.num8ddb = new System.Windows.Forms.ComboBox();
            this.num9ddb = new System.Windows.Forms.ComboBox();
            this.num3ddb = new System.Windows.Forms.ComboBox();
            this.num0label = new System.Windows.Forms.Label();
            this.num1label = new System.Windows.Forms.Label();
            this.num2label = new System.Windows.Forms.Label();
            this.num3label = new System.Windows.Forms.Label();
            this.num4label = new System.Windows.Forms.Label();
            this.num5label = new System.Windows.Forms.Label();
            this.num6label = new System.Windows.Forms.Label();
            this.num7label = new System.Windows.Forms.Label();
            this.num8label = new System.Windows.Forms.Label();
            this.num9label = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // inputListBox
            // 
            this.inputListBox.BackColor = System.Drawing.Color.White;
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.Location = new System.Drawing.Point(334, 128);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(130, 95);
            this.inputListBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.inputListBox, "Select the device that corresponds to \'CABLE INPUT\'.\r\nIf you recently installed t" +
        "he driver this is ussually the last device.\r\nCheck sound manager if indicator li" +
        "ghts up when a sound is played.\r\n\r\n");
            this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(334, 256);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(130, 95);
            this.outputListBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.outputListBox, "Select the device for sound playback (for you to hear the sounds).\r\nUsually your " +
        "current playback device is set to 0.\r\n");
            this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.BackColor = System.Drawing.Color.Transparent;
            this.soundLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundLabel.ForeColor = System.Drawing.Color.White;
            this.soundLabel.Location = new System.Drawing.Point(39, 80);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(130, 18);
            this.soundLabel.TabIndex = 3;
            this.soundLabel.Text = "Sounds Mapping:";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(331, 112);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(133, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Mic Device (Cable Input) (?)";
            this.toolTip1.SetToolTip(this.inputLabel, "Select the device that corresponds to \'CABLE INPUT\'.\r\nIf you recently installed t" +
        "he driver this is ussually the last device.\r\nCheck sound manager if indicator li" +
        "ghts up when a sound is played.");
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(331, 240);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(127, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Sound Playback Device (?)";
            this.toolTip1.SetToolTip(this.outputLabel, "Select the device for sound playback (for you to hear the sounds).\r\nUsually your " +
        "current playback device is set to 0.");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 53);
            this.label1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(66, 403);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/derdanielb";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Created by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Background image and sounds are property of Valve Corporation";
            // 
            // num0ddb
            // 
            this.num0ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num0ddb.FormattingEnabled = true;
            this.num0ddb.Location = new System.Drawing.Point(135, 113);
            this.num0ddb.Name = "num0ddb";
            this.num0ddb.Size = new System.Drawing.Size(121, 21);
            this.num0ddb.TabIndex = 10;
            this.num0ddb.SelectionChangeCommitted += new System.EventHandler(this.num0ddb_SelectionChangeCommitted);
            // 
            // num1ddb
            // 
            this.num1ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num1ddb.FormattingEnabled = true;
            this.num1ddb.Location = new System.Drawing.Point(135, 140);
            this.num1ddb.Name = "num1ddb";
            this.num1ddb.Size = new System.Drawing.Size(121, 21);
            this.num1ddb.TabIndex = 10;
            this.num1ddb.SelectionChangeCommitted += new System.EventHandler(this.num1ddb_SelectionChangeCommitted);
            // 
            // num2ddb
            // 
            this.num2ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num2ddb.FormattingEnabled = true;
            this.num2ddb.Location = new System.Drawing.Point(135, 167);
            this.num2ddb.Name = "num2ddb";
            this.num2ddb.Size = new System.Drawing.Size(121, 21);
            this.num2ddb.TabIndex = 10;
            this.num2ddb.SelectionChangeCommitted += new System.EventHandler(this.num2ddb_SelectionChangeCommitted);
            // 
            // num4ddb
            // 
            this.num4ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num4ddb.FormattingEnabled = true;
            this.num4ddb.Location = new System.Drawing.Point(135, 222);
            this.num4ddb.Name = "num4ddb";
            this.num4ddb.Size = new System.Drawing.Size(121, 21);
            this.num4ddb.TabIndex = 10;
            this.num4ddb.SelectionChangeCommitted += new System.EventHandler(this.num4ddb_SelectionChangeCommitted);
            // 
            // num5ddb
            // 
            this.num5ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num5ddb.FormattingEnabled = true;
            this.num5ddb.Location = new System.Drawing.Point(135, 249);
            this.num5ddb.Name = "num5ddb";
            this.num5ddb.Size = new System.Drawing.Size(121, 21);
            this.num5ddb.TabIndex = 10;
            this.num5ddb.SelectionChangeCommitted += new System.EventHandler(this.num5ddb_SelectionChangeCommitted);
            // 
            // num6ddb
            // 
            this.num6ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num6ddb.FormattingEnabled = true;
            this.num6ddb.Location = new System.Drawing.Point(135, 276);
            this.num6ddb.Name = "num6ddb";
            this.num6ddb.Size = new System.Drawing.Size(121, 21);
            this.num6ddb.TabIndex = 10;
            this.num6ddb.SelectionChangeCommitted += new System.EventHandler(this.num6ddb_SelectionChangeCommitted);
            // 
            // num7ddb
            // 
            this.num7ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num7ddb.FormattingEnabled = true;
            this.num7ddb.Location = new System.Drawing.Point(135, 303);
            this.num7ddb.Name = "num7ddb";
            this.num7ddb.Size = new System.Drawing.Size(121, 21);
            this.num7ddb.TabIndex = 10;
            this.num7ddb.SelectionChangeCommitted += new System.EventHandler(this.num7ddb_SelectionChangeCommitted);
            // 
            // num8ddb
            // 
            this.num8ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num8ddb.FormattingEnabled = true;
            this.num8ddb.Location = new System.Drawing.Point(135, 330);
            this.num8ddb.Name = "num8ddb";
            this.num8ddb.Size = new System.Drawing.Size(121, 21);
            this.num8ddb.TabIndex = 10;
            this.num8ddb.SelectionChangeCommitted += new System.EventHandler(this.num8ddb_SelectionChangeCommitted);
            // 
            // num9ddb
            // 
            this.num9ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num9ddb.FormattingEnabled = true;
            this.num9ddb.Location = new System.Drawing.Point(135, 357);
            this.num9ddb.Name = "num9ddb";
            this.num9ddb.Size = new System.Drawing.Size(121, 21);
            this.num9ddb.TabIndex = 10;
            this.num9ddb.SelectionChangeCommitted += new System.EventHandler(this.num9ddb_SelectionChangeCommitted);
            // 
            // num3ddb
            // 
            this.num3ddb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num3ddb.FormattingEnabled = true;
            this.num3ddb.Location = new System.Drawing.Point(135, 194);
            this.num3ddb.Name = "num3ddb";
            this.num3ddb.Size = new System.Drawing.Size(121, 21);
            this.num3ddb.TabIndex = 10;
            this.num3ddb.SelectionChangeCommitted += new System.EventHandler(this.num3ddb_SelectionChangeCommitted);
            // 
            // num0label
            // 
            this.num0label.AutoSize = true;
            this.num0label.BackColor = System.Drawing.Color.Transparent;
            this.num0label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0label.ForeColor = System.Drawing.Color.White;
            this.num0label.Location = new System.Drawing.Point(39, 114);
            this.num0label.Name = "num0label";
            this.num0label.Size = new System.Drawing.Size(83, 16);
            this.num0label.TabIndex = 11;
            this.num0label.Text = "NumPad 0:";
            // 
            // num1label
            // 
            this.num1label.AutoSize = true;
            this.num1label.BackColor = System.Drawing.Color.Transparent;
            this.num1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1label.ForeColor = System.Drawing.Color.White;
            this.num1label.Location = new System.Drawing.Point(39, 141);
            this.num1label.Name = "num1label";
            this.num1label.Size = new System.Drawing.Size(83, 16);
            this.num1label.TabIndex = 11;
            this.num1label.Text = "NumPad 1:";
            // 
            // num2label
            // 
            this.num2label.AutoSize = true;
            this.num2label.BackColor = System.Drawing.Color.Transparent;
            this.num2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2label.ForeColor = System.Drawing.Color.White;
            this.num2label.Location = new System.Drawing.Point(39, 168);
            this.num2label.Name = "num2label";
            this.num2label.Size = new System.Drawing.Size(83, 16);
            this.num2label.TabIndex = 11;
            this.num2label.Text = "NumPad 2:";
            // 
            // num3label
            // 
            this.num3label.AutoSize = true;
            this.num3label.BackColor = System.Drawing.Color.Transparent;
            this.num3label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3label.ForeColor = System.Drawing.Color.White;
            this.num3label.Location = new System.Drawing.Point(39, 195);
            this.num3label.Name = "num3label";
            this.num3label.Size = new System.Drawing.Size(83, 16);
            this.num3label.TabIndex = 11;
            this.num3label.Text = "NumPad 3:";
            // 
            // num4label
            // 
            this.num4label.AutoSize = true;
            this.num4label.BackColor = System.Drawing.Color.Transparent;
            this.num4label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4label.ForeColor = System.Drawing.Color.White;
            this.num4label.Location = new System.Drawing.Point(39, 223);
            this.num4label.Name = "num4label";
            this.num4label.Size = new System.Drawing.Size(83, 16);
            this.num4label.TabIndex = 11;
            this.num4label.Text = "NumPad 4:";
            // 
            // num5label
            // 
            this.num5label.AutoSize = true;
            this.num5label.BackColor = System.Drawing.Color.Transparent;
            this.num5label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5label.ForeColor = System.Drawing.Color.White;
            this.num5label.Location = new System.Drawing.Point(39, 250);
            this.num5label.Name = "num5label";
            this.num5label.Size = new System.Drawing.Size(83, 16);
            this.num5label.TabIndex = 11;
            this.num5label.Text = "NumPad 5:";
            // 
            // num6label
            // 
            this.num6label.AutoSize = true;
            this.num6label.BackColor = System.Drawing.Color.Transparent;
            this.num6label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6label.ForeColor = System.Drawing.Color.White;
            this.num6label.Location = new System.Drawing.Point(39, 277);
            this.num6label.Name = "num6label";
            this.num6label.Size = new System.Drawing.Size(83, 16);
            this.num6label.TabIndex = 11;
            this.num6label.Text = "NumPad 6:";
            // 
            // num7label
            // 
            this.num7label.AutoSize = true;
            this.num7label.BackColor = System.Drawing.Color.Transparent;
            this.num7label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7label.ForeColor = System.Drawing.Color.White;
            this.num7label.Location = new System.Drawing.Point(39, 304);
            this.num7label.Name = "num7label";
            this.num7label.Size = new System.Drawing.Size(83, 16);
            this.num7label.TabIndex = 11;
            this.num7label.Text = "NumPad 7:";
            // 
            // num8label
            // 
            this.num8label.AutoSize = true;
            this.num8label.BackColor = System.Drawing.Color.Transparent;
            this.num8label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8label.ForeColor = System.Drawing.Color.White;
            this.num8label.Location = new System.Drawing.Point(39, 331);
            this.num8label.Name = "num8label";
            this.num8label.Size = new System.Drawing.Size(83, 16);
            this.num8label.TabIndex = 11;
            this.num8label.Text = "NumPad 8:";
            // 
            // num9label
            // 
            this.num9label.AutoSize = true;
            this.num9label.BackColor = System.Drawing.Color.Transparent;
            this.num9label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9label.ForeColor = System.Drawing.Color.White;
            this.num9label.Location = new System.Drawing.Point(39, 358);
            this.num9label.Name = "num9label";
            this.num9label.Size = new System.Drawing.Size(83, 16);
            this.num9label.TabIndex = 11;
            this.num9label.Text = "NumPad 9:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(185, 403);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(63, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Contributors";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 438);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.num9label);
            this.Controls.Add(this.num8label);
            this.Controls.Add(this.num7label);
            this.Controls.Add(this.num6label);
            this.Controls.Add(this.num5label);
            this.Controls.Add(this.num4label);
            this.Controls.Add(this.num3label);
            this.Controls.Add(this.num2label);
            this.Controls.Add(this.num1label);
            this.Controls.Add(this.num0label);
            this.Controls.Add(this.num9ddb);
            this.Controls.Add(this.num8ddb);
            this.Controls.Add(this.num7ddb);
            this.Controls.Add(this.num6ddb);
            this.Controls.Add(this.num5ddb);
            this.Controls.Add(this.num4ddb);
            this.Controls.Add(this.num3ddb);
            this.Controls.Add(this.num2ddb);
            this.Controls.Add(this.num1ddb);
            this.Controls.Add(this.num0ddb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.soundLabel);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.inputListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dota 2 Chat-Wheel Soundboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox num0ddb;
        private System.Windows.Forms.ComboBox num1ddb;
        private System.Windows.Forms.ComboBox num2ddb;
        private System.Windows.Forms.ComboBox num4ddb;
        private System.Windows.Forms.ComboBox num5ddb;
        private System.Windows.Forms.ComboBox num6ddb;
        private System.Windows.Forms.ComboBox num7ddb;
        private System.Windows.Forms.ComboBox num8ddb;
        private System.Windows.Forms.ComboBox num9ddb;
        private System.Windows.Forms.ComboBox num3ddb;
        private System.Windows.Forms.Label num0label;
        private System.Windows.Forms.Label num1label;
        private System.Windows.Forms.Label num2label;
        private System.Windows.Forms.Label num3label;
        private System.Windows.Forms.Label num4label;
        private System.Windows.Forms.Label num5label;
        private System.Windows.Forms.Label num6label;
        private System.Windows.Forms.Label num7label;
        private System.Windows.Forms.Label num8label;
        private System.Windows.Forms.Label num9label;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

