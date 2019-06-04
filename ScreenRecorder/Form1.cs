using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRecorder
{
    public partial class formMain : Form
    {
        string fileName = "";
        ScreenRecorder.Capturer.Recorder recorder;
        public formMain()
        {
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Video files (*.avi)|*.avi";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                this.Text = "Screen Capture - " + fileName;
                btRecord.Enabled = true;
            }
        }

        private void BtRecord_Click(object sender, EventArgs e)
        {
            recorder = new Capturer.Recorder(new Capturer.RecorderParams(fileName, 10, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 70));
            btRecord.Text = "Recording";
            btStop.Enabled = true;
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            recorder.Dispose();
            btStop.Enabled = false;
            btRecord.Enabled = true;
        }
    }
}
