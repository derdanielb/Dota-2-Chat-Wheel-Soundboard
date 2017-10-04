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
            this.mappingLabel = new System.Windows.Forms.Label();
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.soundLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // mappingLabel
            // 
            this.mappingLabel.AutoSize = true;
            this.mappingLabel.Location = new System.Drawing.Point(12, 71);
            this.mappingLabel.Name = "mappingLabel";
            this.mappingLabel.Size = new System.Drawing.Size(158, 130);
            this.mappingLabel.TabIndex = 0;
            this.mappingLabel.Text = resources.GetString("mappingLabel.Text");
            // 
            // inputListBox
            // 
            this.inputListBox.BackColor = System.Drawing.Color.White;
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.Location = new System.Drawing.Point(280, 101);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(120, 95);
            this.inputListBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.inputListBox, "Select the device that corresponds to \'CABLE INPUT\'.\r\nIf you recently installed t" +
        "he driver this is ussually the last device.\r\n\r\n");
            this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(434, 101);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(120, 95);
            this.outputListBox.TabIndex = 2;
            this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.BackColor = System.Drawing.Color.Transparent;
            this.soundLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundLabel.ForeColor = System.Drawing.Color.White;
            this.soundLabel.Location = new System.Drawing.Point(9, 30);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(115, 32);
            this.soundLabel.TabIndex = 3;
            this.soundLabel.Text = "Sounds:";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(277, 85);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(120, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Mic Device (Cable Input)";
            this.toolTip1.SetToolTip(this.inputLabel, "Select the device that corresponds to \'CABLE INPUT\'.\r\nIf you recently installed t" +
        "he driver this is ussually the last device.");
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(431, 85);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(122, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Sound Playback Device";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 433);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.soundLabel);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.inputListBox);
            this.Controls.Add(this.mappingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Dota 2 Chat-Wheel Soundboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mappingLabel;
        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

