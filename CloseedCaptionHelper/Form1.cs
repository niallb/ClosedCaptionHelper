using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ClosedCaptionHelper
{
    public partial class Form1 : Form
    {
        protected class captionInfo
        {
            public int line;
            public double start;
            public double length;
            public string caption;
            public string voice; 

            public captionInfo(double st)
            {
                start = st;
                length = 0;
                voice = "";
                caption = "";
            }

            public override string ToString()
            {
                string vctxt = "";
                if (voice.Length > 0)
                    vctxt = "<" + voice + "> ";
                if (caption.Length > 0)
                    return startTime() + " : " + vctxt + caption;
                else
                    return startTime() + " [empty]";
            }

            public string startTime()
            {
                TimeSpan t = TimeSpan.FromSeconds(start);
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
                return time;
            }

            public string endTime()
            {
                if (length == 0)
                    return "";
                TimeSpan t = TimeSpan.FromSeconds(start+length);
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
                return time;
            }
        }

        private int timeInc;
        private captionInfo curCaption;
        private bool captionsLoaded;
        private bool mediaLoaded;
        private string vttpath;
        private bool changingCaptionIndex;
        private bool curCaptionChanged;
        
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timeInc = 2;
            mediaLoaded = false;
            captionsLoaded = false;
            vttpath = null;
            changingCaptionIndex = false;
            curCaptionChanged = false;
            /*/Temp for dev
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\niall_000\\Videos\\MyStream_3.mp4";
            openClosedCaptionsFile("C:\\Users\\niall_000\\Videos\\MyStream_3.vtt"); 
            captionsList.SelectedIndex = 0; //*/

            //timer1.Start();
        }

        private void StepBack()
        {
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition > timeInc)
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= timeInc;
            else
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
        }

        private void StepForward()
        {
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition < axWindowsMediaPlayer1.currentMedia.duration - timeInc)
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition += timeInc;
            else
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration;
        }

        private void Home()
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
        }

        private int findCaptionIndexForTime(double time)
        {
            //captionsList.Items.
            int n = 0;
            while (n < captionsList.Items.Count)
            {
                captionInfo test = (captionInfo)captionsList.Items[n];
                if ((test.start <= time) && (test.start + test.length > time))
                    return n;
                n++;
            }
            return -1;
        }

        private void StartStop()
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                //Start a new caption
                changingCaptionIndex = true;
                curCaption.caption = captionEdt.Text;
                if (captionsList.SelectedItem != null)
                {
                    captionsList.Items[captionsList.SelectedIndex] = captionsList.SelectedItem;
                }
                else
                {
                    int n = 0;
                    while((n < captionsList.Items.Count)&&(((captionInfo)captionsList.Items[n]).start < curCaption.start))
                        n++;
                    captionsList.Items.Insert(n, curCaption);
                    //# This should only select if a caption at this time.
                    captionsList.SelectedIndex = n+1;
                }

                curCaption = new captionInfo(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                curCaptionChanged = false;
                captionsList.Items.Add(curCaption);
                captionsList.SelectedIndex = captionsList.Items.Count - 1;
                editCurCaption();

                axWindowsMediaPlayer1.Ctlcontrols.play();
                changingCaptionIndex = false;
            }
            else
            {
                if (curCaption.length == 0)
                {
                    double len = axWindowsMediaPlayer1.Ctlcontrols.currentPosition - curCaption.start;
                    if (len > 0)
                    {
                        curCaption.length = len;
                        endEdt.Text = curCaption.endTime();
                    }
                }
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void Restart()
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                //Continue with current caption if possible
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (mediaLoaded)
            {
                if (e.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Left:
                            StepBack();
                            e.SuppressKeyPress = true;
                            break;
                        case Keys.Right:
                            StepForward();
                            e.SuppressKeyPress = true;
                            break;
                        case Keys.Home:
                            Home();
                            e.SuppressKeyPress = true;
                            break;
                        case Keys.End:
                            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration;
                            e.SuppressKeyPress = true;
                            break;
                        case Keys.S:
                            StartStop();
                            e.SuppressKeyPress = true;
                            break;
                        case Keys.R:
                            Restart();                          
                            e.SuppressKeyPress = true;
                            break;
                        case Keys.Delete:
                            if (MessageBox.Show("Delete Current caption?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                deleteCurrentCaptionToolStripMenuItem_Click(null, null);
                            break;
                    }
                }
            }
        }

        private void openVideoAudioFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFileDlg = new OpenFileDialog();
            opnFileDlg.Multiselect = true;
            opnFileDlg.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*";
            if (opnFileDlg.ShowDialog() == DialogResult.OK)
            {
                string FileName = opnFileDlg.FileName;
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.URL = FileName;
                axWindowsMediaPlayer1.Ctlcontrols.next();
                //axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0.1;
                if (!captionsLoaded)
                {
                    vttpath = FileName.Substring(0, FileName.LastIndexOf(".")) + ".vtt";
                    if (File.Exists(vttpath))
                    {
                        openClosedCaptionsFile(vttpath);
                    }
                    else
                    {
                        captionsList.Items.Clear();
                        curCaption = new captionInfo(0);
                        captionsLoaded = true;
                        captionsList.Items.Add(curCaption);
                        captionsList.SelectedIndex = 0;
                        editCurCaption();
                    }
                }
                mediaLoaded = true;
            }
        }

        public void editCurCaption()
        {
            startEdt.Text = curCaption.startTime();
            endEdt.Text = curCaption.endTime();
            voiceLbl.Text = curCaption.voice;
            captionEdt.Text = curCaption.caption;
        }

        public void updateCurCaption()
        {
            //startEdt.Text = curCaption.startTime();
            //endEdt.Text = curCaption.endTime();
            if (curCaption != null)
            {
                curCaption.voice = voiceLbl.Text;
                curCaption.caption = captionEdt.Text;
                curCaptionChanged = false;
            }
        }

        public static double displayTimeToDouble(string dt)
        {
            string[] parts = dt.Split(':');
            double hr = 0;
            double mn = 0;
            double s = 0;
            double val = 0;
            if (parts.Length == 3)
            {
                double.TryParse(parts[0], out hr);
                double.TryParse(parts[1], out mn);
                double.TryParse(parts[2], out s);
                val = hr * 3600 + mn * 60 + s;
            }
            else if (parts.Length == 2)
            {
                double.TryParse(parts[0], out mn);
                double.TryParse(parts[1], out s);
                val = mn * 60 + s;
            }
            if (parts.Length == 1)
            {
                double.TryParse(parts[0], out s);
                val = s;
            }

            return val;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)// playing
                timer1.Start();
            else
                timer1.Stop();
          /*  if((e.newState == 3)&&(loadingVideo))
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                loadingVideo = false;
                textBox1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
            }*/
        }

        private void UpdateVidSync(bool toList)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            captionEdt.Focus();
        }

        private string getVTTSrc()
        {
            StringBuilder vtt = new StringBuilder();
            foreach (captionInfo cinf in captionsList.Items)
            {
                vtt.AppendLine(cinf.startTime() + " --> " + cinf.endTime());
                string vc = "";
                if (cinf.voice != "")
                {
                    vc = "<v " + cinf.voice + "> ";
                }
                vtt.AppendLine(vc + cinf.caption);
                vtt.AppendLine();
            }
            return vtt.ToString();
        }

        private string getVTTTranscript()
        {
            StringBuilder transcript = new StringBuilder();
            foreach (captionInfo cinf in captionsList.Items)
            {
                string vc = "";
                if (cinf.voice != "")
                {
                    vc = "[" + cinf.voice + "] ";
                }
                transcript.AppendLine(vc + cinf.caption);
                transcript.AppendLine();
            }
            return transcript.ToString();
        }

        private void saveClosedCaptionsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((vttpath == null)||(!File.Exists(vttpath)))
            {
                 saveClosedCaptionsFileAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(vttpath, getVTTSrc());
            }
        }

        private void saveClosedCaptionsFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if(vttpath != null)
                saveFileDialog1.FileName = vttpath;
            saveFileDialog1.Filter = "WebVTT files (*.vtt)|*.vtt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                vttpath = saveFileDialog1.FileName;
                File.WriteAllText(vttpath, getVTTSrc());
            }
        }

        private void openClosedCaptionsFile(string filename)
        {
            Regex readTimes = new Regex(@"\A\s*((?<sth>[0-9]+):)?(?<stm>[0-9]+):(?<sts>[0-9\.]+)\s*[->]+\s*((?<enh>[0-9]+):)?(?<enm>[0-9]+):(?<ens>[0-9\.]+)");
            Regex readVoice = new Regex(@"\A\s*<v\s+(?<voice>[^>]+)>\s*(?<caption>.*)");
            vttpath = filename;
            string[] vtt = File.ReadAllLines(vttpath);
            captionsList.Items.Clear();
            captionInfo cc = null;
            bool firstline = false;
            foreach (string ln in vtt)
            {
                Match tms = readTimes.Match(ln);
                if (tms.Success)
                {
                    if (cc != null)
                    {
                        captionsList.Items.Add(cc);
                    }
                    double start = 0;
                    if (tms.Groups["sth"].Success)
                        start += double.Parse(tms.Groups["sth"].Value) * 3600;
                    start += double.Parse(tms.Groups["stm"].Value) * 60;
                    start += double.Parse(tms.Groups["sts"].Value);
                    double end = 0;
                    if (tms.Groups["enh"].Success)
                        end += double.Parse(tms.Groups["enh"].Value) * 3600;
                    end += double.Parse(tms.Groups["enm"].Value) * 60;
                    end += double.Parse(tms.Groups["ens"].Value);
                    cc = new captionInfo(start);
                    cc.length = end - start;
                    firstline = true;
                }
                else if (cc != null)
                {
                    if(firstline)
                    {
                        Match flm = readVoice.Match(ln);
                        if(flm.Success)
                        {
                            cc.voice = flm.Groups["voice"].Value;
                            cc.caption = flm.Groups["caption"].Value;
                        }
                        else
                        {
                            cc.caption = ln;
                        }
                        firstline = false;
                    }
                    else
                    {
                        if(ln.Trim().Length > 0)
                        {
                            cc.caption += "\r\n" + ln;
                        }
                    }

                }
            }
            if (cc != null)
            {
                captionsList.Items.Add(cc);
            }
        }

        private void openClosedCaptionsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WebVTT files (*.vtt)|*.vtt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                openClosedCaptionsFile(ofd.FileName);
            }
        }

        private void captionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!changingCaptionIndex)
            {
                updateCurCaption();
                if (captionsList.SelectedIndex != -1)
                {
                    curCaption = (captionInfo)captionsList.Items[captionsList.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition = curCaption.start;
                    editCurCaption();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (curCaption != null)
            {
                if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition < curCaption.start)
                {

                }
                else if ((curCaption.length > 0) && (axWindowsMediaPlayer1.Ctlcontrols.currentPosition > curCaption.start + curCaption.length))
                {
                    if (captionsList.SelectedIndex < captionsList.Items.Count - 1)
                    {
                        captionsList.SelectedIndex++;
                    }
                    else
                    {
                        curCaption = new captionInfo(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                        captionsList.Items.Add(curCaption);
                        captionsList.SelectedIndex = captionsList.Items.Count - 1;
                    }
                }
            }
        }

        private void splitBtn_Click(object sender, EventArgs e)
        {

        }

        private void twoSecondsBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StepBack();
        }

        private void twoSecondsForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StepForward();
        }

        private void backToStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void startaddCaptionStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            if (curCaptionChanged)
            {
                bool isplaying = false;
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    isplaying = true;
                }
                if(MessageBox.Show("Save caption change?", "Caption changed", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    MessageBox.Show("Still to implement - I should refactor inserting and updating captions first.");
                }
                if(isplaying)
                    axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            int idx = findCaptionIndexForTime(e.newPosition);
            if(idx != -1)
            {
                captionsList.SelectedIndex = idx;
            }
        }

        private void captionEdt_TextChanged(object sender, EventArgs e)
        {
            if (!changingCaptionIndex)
                curCaptionChanged = true;
        }

        private void exportTranscriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //if (vttpath != null)
            //    saveFileDialog1.FileName = vttpath;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, getVTTTranscript());
            }
        }

        private void deleteCurrentCaptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (captionsList.SelectedIndex >= 0)
                captionsList.Items.RemoveAt(captionsList.SelectedIndex);
        }

        private void newClosedCaptionsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
