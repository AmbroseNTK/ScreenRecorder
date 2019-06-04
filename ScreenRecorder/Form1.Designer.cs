namespace ScreenRecorder
{
    partial class formMain
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
            this.btSave = new System.Windows.Forms.Button();
            this.btRecord = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(36, 28);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(190, 70);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save as";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btRecord
            // 
            this.btRecord.BackColor = System.Drawing.Color.Firebrick;
            this.btRecord.Enabled = false;
            this.btRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRecord.Location = new System.Drawing.Point(36, 115);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(752, 76);
            this.btRecord.TabIndex = 1;
            this.btRecord.Text = "Record";
            this.btRecord.UseVisualStyleBackColor = false;
            this.btRecord.Click += new System.EventHandler(this.BtRecord_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(36, 217);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(752, 62);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btRecord);
            this.Controls.Add(this.btSave);
            this.Name = "formMain";
            this.Text = "Screen Recorder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btStop;
    }
}

