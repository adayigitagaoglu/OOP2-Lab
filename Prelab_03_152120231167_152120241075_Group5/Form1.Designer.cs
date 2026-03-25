namespace Prelab_03_152120231167_152120241075_Group5
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
            this.clockLabel = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pickColorButton = new System.Windows.Forms.Button();
            this.cBoxTimeZone = new System.Windows.Forms.ComboBox();
            this.txtZoneName = new System.Windows.Forms.TextBox();
            this.txtZoneoffset = new System.Windows.Forms.TextBox();
            this.addZoneButton = new System.Windows.Forms.Button();
            this.UpdateZoneButton = new System.Windows.Forms.Button();
            this.deleteZoneButton = new System.Windows.Forms.Button();
            this.clbTimeZones = new System.Windows.Forms.CheckedListBox();
            this.ZoneLabel = new System.Windows.Forms.Label();
            this.labelZoneName = new System.Windows.Forms.Label();
            this.labelZoneOffset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clockLabel.Font = new System.Drawing.Font("Niagara Engraved", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clockLabel.Location = new System.Drawing.Point(153, 49);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(366, 179);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "10:12:24";
            this.clockLabel.Click += new System.EventHandler(this.clockLabel_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(539, 101);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(114, 30);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // pickColorButton
            // 
            this.pickColorButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pickColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pickColorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickColorButton.Location = new System.Drawing.Point(539, 139);
            this.pickColorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pickColorButton.Name = "pickColorButton";
            this.pickColorButton.Size = new System.Drawing.Size(114, 32);
            this.pickColorButton.TabIndex = 2;
            this.pickColorButton.Text = "Select Color";
            this.pickColorButton.UseVisualStyleBackColor = false;
            this.pickColorButton.Click += new System.EventHandler(this.pickColorButton_Click);
            // 
            // cBoxTimeZone
            // 
            this.cBoxTimeZone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cBoxTimeZone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTimeZone.FormattingEnabled = true;
            this.cBoxTimeZone.Location = new System.Drawing.Point(401, 284);
            this.cBoxTimeZone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxTimeZone.Name = "cBoxTimeZone";
            this.cBoxTimeZone.Size = new System.Drawing.Size(130, 31);
            this.cBoxTimeZone.TabIndex = 3;
            this.cBoxTimeZone.Text = "Select Zone";
            this.cBoxTimeZone.SelectedIndexChanged += new System.EventHandler(this.cBoxTimeZone_SelectedIndexChanged);
            // 
            // txtZoneName
            // 
            this.txtZoneName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoneName.Location = new System.Drawing.Point(60, 302);
            this.txtZoneName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZoneName.Name = "txtZoneName";
            this.txtZoneName.Size = new System.Drawing.Size(117, 30);
            this.txtZoneName.TabIndex = 4;
            this.txtZoneName.TextChanged += new System.EventHandler(this.txtZoneName_TextChanged);
            // 
            // txtZoneoffset
            // 
            this.txtZoneoffset.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoneoffset.Location = new System.Drawing.Point(199, 302);
            this.txtZoneoffset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZoneoffset.Name = "txtZoneoffset";
            this.txtZoneoffset.Size = new System.Drawing.Size(114, 30);
            this.txtZoneoffset.TabIndex = 5;
            // 
            // addZoneButton
            // 
            this.addZoneButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addZoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addZoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addZoneButton.Location = new System.Drawing.Point(60, 340);
            this.addZoneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addZoneButton.Name = "addZoneButton";
            this.addZoneButton.Size = new System.Drawing.Size(78, 32);
            this.addZoneButton.TabIndex = 6;
            this.addZoneButton.Text = "Add ";
            this.addZoneButton.UseVisualStyleBackColor = false;
            this.addZoneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateZoneButton
            // 
            this.UpdateZoneButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UpdateZoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateZoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateZoneButton.Location = new System.Drawing.Point(146, 340);
            this.UpdateZoneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateZoneButton.Name = "UpdateZoneButton";
            this.UpdateZoneButton.Size = new System.Drawing.Size(78, 32);
            this.UpdateZoneButton.TabIndex = 7;
            this.UpdateZoneButton.Text = "Update Zone";
            this.UpdateZoneButton.UseVisualStyleBackColor = false;
            this.UpdateZoneButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteZoneButton
            // 
            this.deleteZoneButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deleteZoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteZoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteZoneButton.Location = new System.Drawing.Point(235, 340);
            this.deleteZoneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteZoneButton.Name = "deleteZoneButton";
            this.deleteZoneButton.Size = new System.Drawing.Size(78, 32);
            this.deleteZoneButton.TabIndex = 8;
            this.deleteZoneButton.Text = "Delete";
            this.deleteZoneButton.UseVisualStyleBackColor = false;
            this.deleteZoneButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // clbTimeZones
            // 
            this.clbTimeZones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clbTimeZones.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTimeZones.FormattingEnabled = true;
            this.clbTimeZones.Location = new System.Drawing.Point(539, 284);
            this.clbTimeZones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbTimeZones.Name = "clbTimeZones";
            this.clbTimeZones.Size = new System.Drawing.Size(142, 79);
            this.clbTimeZones.TabIndex = 9;
            this.clbTimeZones.SelectedIndexChanged += new System.EventHandler(this.clbTimeZones_SelectedIndexChanged);
            // 
            // ZoneLabel
            // 
            this.ZoneLabel.AutoSize = true;
            this.ZoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoneLabel.Location = new System.Drawing.Point(436, 328);
            this.ZoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZoneLabel.Name = "ZoneLabel";
            this.ZoneLabel.Size = new System.Drawing.Size(53, 23);
            this.ZoneLabel.TabIndex = 10;
            this.ZoneLabel.Text = "label1";
            this.ZoneLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelZoneName
            // 
            this.labelZoneName.AutoSize = true;
            this.labelZoneName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName.Location = new System.Drawing.Point(56, 275);
            this.labelZoneName.Name = "labelZoneName";
            this.labelZoneName.Size = new System.Drawing.Size(100, 23);
            this.labelZoneName.TabIndex = 12;
            this.labelZoneName.Text = "Zone Name";
            this.labelZoneName.Click += new System.EventHandler(this.labelZoneName_Click);
            // 
            // labelZoneOffset
            // 
            this.labelZoneOffset.AutoSize = true;
            this.labelZoneOffset.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneOffset.Location = new System.Drawing.Point(195, 275);
            this.labelZoneOffset.Name = "labelZoneOffset";
            this.labelZoneOffset.Size = new System.Drawing.Size(101, 23);
            this.labelZoneOffset.TabIndex = 13;
            this.labelZoneOffset.Text = "Zone Offset";
            this.labelZoneOffset.Click += new System.EventHandler(this.labelZoneOffset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 456);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.labelZoneOffset);
            this.Controls.Add(this.labelZoneName);
            this.Controls.Add(this.ZoneLabel);
            this.Controls.Add(this.clbTimeZones);
            this.Controls.Add(this.deleteZoneButton);
            this.Controls.Add(this.UpdateZoneButton);
            this.Controls.Add(this.addZoneButton);
            this.Controls.Add(this.txtZoneoffset);
            this.Controls.Add(this.txtZoneName);
            this.Controls.Add(this.cBoxTimeZone);
            this.Controls.Add(this.pickColorButton);
            this.Controls.Add(this.dateTimePicker);
            this.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button pickColorButton;
        private System.Windows.Forms.ComboBox cBoxTimeZone;
        private System.Windows.Forms.TextBox txtZoneName;
        private System.Windows.Forms.TextBox txtZoneoffset;
        private System.Windows.Forms.Button addZoneButton;
        private System.Windows.Forms.Button UpdateZoneButton;
        private System.Windows.Forms.Button deleteZoneButton;
        private System.Windows.Forms.CheckedListBox clbTimeZones;
        private System.Windows.Forms.Label ZoneLabel;
        private System.Windows.Forms.Label labelZoneName;
        private System.Windows.Forms.Label labelZoneOffset;
    }
}

