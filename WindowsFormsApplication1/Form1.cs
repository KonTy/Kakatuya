using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public enum State
    {
        paused,
        stopped,
        reading
    }
    public enum BarStatus
    {
        Narrating,
        Paused,
        Resuming,
        Idle,
        Complete,
        Stopped,
        Err_Blank,
        Err_Pause
    }
    public partial class Form1 : Form
    {
        SpeechSynthesizer speaker;
        char[] trims = { ' ', '\n' };
        char[] delim1 = { '.', '\n', '?', '!' };
        char[] delims = { '{', '}', '[', ']', '|', '\\', '(', ')', '<', '>' };

        State state;
        Thread readingThread;

        public Form1()
        {
            initiator();
            InitializeComponent();
            initNext();
        }
        private void initiator()
        {
            speaker = new SpeechSynthesizer();
            speaker.Rate = 0;
            speaker.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
            state = State.stopped;
        }
        private void initNext()
        {
            aboutPanel.SendToBack();
            Pause.Enabled = false;
            Stop.Enabled = false;
            togglePauseResume(false);
            togglePalyStop(false);
            statusIcon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bar_status(BarStatus.Idle);
        }
        private void welcome()
        {
            speaker.Speak("Welcome to Kaakatuya. A text to speech app for you by Khan 'Sadh' Mostafa from Sfaar.net");
        }
        private void reader()
        {
            string theText = textToRead.Text;
            string[] delimOfSentence = { ". ",".\n", "? ", "! ", "\"", "; ", "\n",":\n",": " };
            //string[] sentences = theText.Split(delim1);
            string[] sentences = theText.Split(delimOfSentence, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                if (this.state == State.reading)
                {
                    //String[] phrases = sentence.Split(delims);
                    bar_status(BarStatus.Narrating);
                    //foreach (string phrase in phrases)
                    {
                        //highliteTxt.Text = phrase.Replace('\n', ' ').Trim();
                        highliteTxt.Text = sentence.Replace('\n', ' ').Trim();
                        Thread sth = new Thread(new ThreadStart(shower));
                        sth.Start();
                        speaker.Rate = speedrateBar.Value;
                        speaker.Volume = volumeBar.Value * 5;
                        //speaker.Speak(phrase);
                        speaker.Speak(sentence);
                    }
                }
                else
                {
                    Thread.Sleep(1);
                }
            }
            state = State.stopped;
            bar_status(BarStatus.Complete);
            Thread.Sleep(1986);
            highliteTxt.Text = "";
            theWord.Text = "";
            Read.Enabled = true;
            Pause.Enabled = false;
            Stop.Enabled = false;
            Thread.Sleep(2005);
            bar_status(BarStatus.Idle);
            readingThread.Abort();
        }

        private void shower()
        {
            char[] delimSpace = { ' ', ',','{', '}', '[', ']', '|', '\\', '(', ')', 
                                '<', '>','+','-','*','/','\n'  };
            int waitTimer;
            char[] delims = { '{', '}', '[', ']', '|', '\\', '(', ')', 
                                '<', '>','+','-','*','/','\n' };
            String[] words = highliteTxt.Text.Split(delimSpace);
            foreach (String word in words)
            {
                theWord.Font = new Font(theWord.Font.Name, (float)((word.Length > 13) ? 11.75 : 15.75) );
                theWord.Text = word;
                waitTimer = word.Length * 19 / 3;
                if ((word.Length > 2) && ((Char.IsUpper(word, 2) || (Char.IsUpper(word, 2)))))
                {
                    waitTimer = 19 * word.Length;
                }
                Thread.Sleep(waitTimer * (10 - speedrateBar.Value));
            }
        }

        private void togglePauseResume(bool isPaused)
        {
            Pause.Visible = !isPaused;
            Resume.Visible = isPaused;
        }
        private void togglePalyStop(bool isPlaying)
        {
            Read.Visible = !isPlaying;
            Stop.Visible = isPlaying;
        }

        private void statusBar(string msg, Color color, Image statusImage, Image statusIcon)
        {
            this.statusLabel.Text = msg;
            this.statusLabel.BackColor = color;
            this.statusLabel.Image = statusImage;
            this.statusIcon.Image = statusIcon;
            this.statusIcon.BackColor = color;
        }
        private void bar_status(Exception ex)
        {
            statusBar("Error! " + ex.Message, Color.Pink,
            global::WindowsFormsApplication1.Properties.Resources.errr,
            global::WindowsFormsApplication1.Properties.Resources.err);
        }
        private void bar_status(BarStatus statusInfo)
        {
            switch (statusInfo)
            {
                case BarStatus.Narrating:
                    statusBar("Narrating Text...", Color.Transparent,
                         global::WindowsFormsApplication1.Properties.Resources.narrator,
                         global::WindowsFormsApplication1.Properties.Resources.NarratLoadin);
                    return;
                case BarStatus.Paused:
                    statusBar("Paused. (Resume to Narrate)", Color.Honeydew,
                        global::WindowsFormsApplication1.Properties.Resources.paused_loader_,
                        global::WindowsFormsApplication1.Properties.Resources.paused);
                    return;
                case BarStatus.Resuming:
                    statusBar("Resuming ...", Color.Transparent,
                        global::WindowsFormsApplication1.Properties.Resources.paused,
                        global::WindowsFormsApplication1.Properties.Resources.ajax_loader);
                    return;
                case BarStatus.Idle:
                    statusBar("Put some text to narrate.", Color.Transparent,
                        global::WindowsFormsApplication1.Properties.Resources.write_something,
                        global::WindowsFormsApplication1.Properties.Resources.Kakatuya);
                    return;
                case BarStatus.Complete:
                    statusBar("Narration Completed.", Color.Transparent,
                        global::WindowsFormsApplication1.Properties.Resources.narration_completed,
                        global::WindowsFormsApplication1.Properties.Resources.narration_completed_2);
                    return;
                case BarStatus.Stopped:
                    statusBar("Stopprd", Color.Transparent,
                        global::WindowsFormsApplication1.Properties.Resources.err,
                        global::WindowsFormsApplication1.Properties.Resources.stopped);
                    return;
                case BarStatus.Err_Blank:
                    statusBar("No text to narrate! Put some text.", Color.Pink,
                         global::WindowsFormsApplication1.Properties.Resources.write_something,
                         global::WindowsFormsApplication1.Properties.Resources.redd);
                    return;
                case BarStatus.Err_Pause:
                    statusBar("No text to reading and nothing to pause!", Color.Pink,
                    global::WindowsFormsApplication1.Properties.Resources.err,
                        global::WindowsFormsApplication1.Properties.Resources.redd);
                    return;
            }
        }
        private void read_Click(object sender, EventArgs e)
        {
            if (textToRead.Text == null || textToRead.Text.Length <= 0)
            {
                bar_status(BarStatus.Err_Blank);
                return;
            }
            try
            {
                readingThread = new Thread(new ThreadStart(reader));
                readingThread.Start();
            }
            catch (Exception ex)
            {
                //readingThread.Resume();
                bar_status(ex);
            }
            state = State.reading;
            Read.Enabled = false;
            Pause.Enabled = true;
            Stop.Enabled = true;
            togglePalyStop(true);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (state == State.reading)
            {
                speaker.Pause();
                bar_status(BarStatus.Paused);
                Stop.Enabled = false;
                Resume.Enabled = true;
                Pause.Enabled = false;
                Read.Enabled = false;
                togglePauseResume(true);
                state = State.paused;
            }
            else
            {
                bar_status(BarStatus.Err_Pause);
            }
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            if (state == State.paused)
            {
                bar_status(BarStatus.Resuming);
                speaker.Resume();
                Stop.Enabled = true;
                Resume.Enabled = false;
                Pause.Enabled = true;
                Read.Enabled = false;
                togglePauseResume(false);
                state = State.reading;
            }
            else
            {
                bar_status(BarStatus.Err_Pause);
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (state == State.stopped)
            {
                statusLabel.Image = global::WindowsFormsApplication1.Properties.Resources.red_orb;
                statusLabel.Text = "Already Stopped or Nothing to read!";
                return;
            }
            readingThread.Abort();
            readingThread = null;
            bar_status(BarStatus.Stopped);
            Stop.Enabled = false;
            Resume.Enabled = false;
            Pause.Enabled = false;
            Read.Enabled = true;
            togglePalyStop(false);
            state = State.stopped;
            new Thread(new ThreadStart(rt)).Start();
        }


        private void settingsButton_Click(object sender, EventArgs e)
        {
        }
        private void fontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textToRead.Font;
            fontDialog1.ShowDialog();
            textToRead.Font = fontDialog1.Font;
        }

        private void rt()
        {
            Thread.Sleep(5000);
            bar_status(BarStatus.Idle);
        }
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            aboutPanel.BringToFront();
        }

        private void aboutDoneButton_Click(object sender, EventArgs e)
        {
            aboutPanel.SendToBack();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Web Document | *.htm; *.html";
            openFileDialog1.ShowDialog();
            try
            {
              textToRead.Text = Form1.GetInnerHtmltext(File.ReadAllText(openFileDialog1.FileName));
            }
            catch (Exception)
            {

            }
        }
        public static string GetInnerHtmltext(string data)
        {
            string decode = System.Web.HttpUtility.HtmlDecode(data);
            Regex objRegExp = new Regex("<(.|\n)+?>");
            string replace = objRegExp.Replace(decode, "");
            return replace.Trim("\t\r\n ".ToCharArray());
        }

        private void smartClick(object sender, EventArgs e)
        {
            switch (state)
            {
                case State.stopped:
                    read_Click(sender, e);
                    return;

                case State.reading:
                    Pause_Click(sender, e);
                    return;

                case State.paused:
                    Resume_Click(sender, e);
                    return;

                default: return;


            }
        }
    }
}
