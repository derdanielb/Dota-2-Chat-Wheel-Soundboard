
using NHotkey;
using NHotkey.WindowsForms;
using NAudio;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatWheelSoundboard
{
    public partial class Form1 : Form
    {
        //IWavePlayer waveOutDevice;
        int maxDevices;
        int currentDevice;
        int currentPlaybackDevice = 0;
        String[] messages = {
            "crybaby",
            "disastah",
            "drum_roll",
            "ehto_g_g",
            "eto_prosto_netchto",
            "frog",
            "headshake",
            "jia_you",
            "patience",
            "po_liang_lu",
            "rimshot",
            "sad_bone",
            "tian_huo",
            "wan_bu_liao_la",
            "wow",
            "zhil_do_konsta",
            "zou_hao_bu_song",
            "all_dead",
            "ay_ay_ay",
            "bozhe_ti_posmotri",
            "brutal",
            "charge",
            "crash_burn",
            "cricket",
            "crowd_lv_02"
        };


        public Form1()
        {
            
            InitializeComponent();

            maxDevices = WaveOut.DeviceCount;
            currentDevice = maxDevices - 1;
            List<string> _devicesIn = new List<string>();
            List<string> _devicesOut = new List<string>();
            for (int i = 0; i < maxDevices; i++)
            {
                _devicesIn.Add(i.ToString());
                _devicesOut.Add(i.ToString());
            }
            inputListBox.DataSource = _devicesIn;
            outputListBox.DataSource = _devicesOut;

            //num0ddb.DataSource = messages;
            //num1ddb.DataSource = messages;
            //num2ddb.DataSource = messages;
            //num3ddb.DataSource = messages;
            //num4ddb.DataSource = messages;
            //num5ddb.DataSource = messages;
            //num6ddb.DataSource = messages;
            //num7ddb.DataSource = messages;
            //num8ddb.DataSource = messages;
            //num9ddb.DataSource = messages;

            HotkeyManager.Current.AddOrReplace("crowd_lv_02", Keys.NumPad0, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("patience", Keys.NumPad1, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("wow", Keys.NumPad2, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("all_dead", Keys.NumPad3, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("brutal", Keys.NumPad4, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("disastah", Keys.NumPad5, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("bozhe_ti_posmotri", Keys.NumPad6, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("ay_ay_ay", Keys.NumPad7, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("ehto_g_g", Keys.NumPad8, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("eto_prosto_netchto", Keys.NumPad9, OnSoundTrigger);

            currentDevice = maxDevices - 1;
            inputListBox.SetSelected(currentDevice, true);
            currentDevice = maxDevices - 1;
        }


        private void OnSoundTrigger(object sender, HotkeyEventArgs e)
        {

            new Thread(() =>
            {
                AudioFileReader audioFileReader;
                AudioFileReader audioFileReader2;
                WaveOut waveOutDevice;
                waveOutDevice = new WaveOut();
                waveOutDevice.DeviceNumber = currentDevice;

                WaveOut playbackDevice;
                playbackDevice = new WaveOut();
                playbackDevice.DeviceNumber = currentPlaybackDevice;

                switch (e.Name)
                {
                    case "disastah":
                        audioFileReader = new AudioFileReader("Chatwheel_disastah.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_disastah.wav");
                        break;
                    case "ehto_g_g":
                        audioFileReader = new AudioFileReader("Chatwheel_ehto_g_g.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_ehto_g_g.wav");
                        break;
                    case "eto_prosto_netchto":
                        audioFileReader = new AudioFileReader("Chatwheel_eto_prosto_netchto.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_eto_prosto_netchto.wav");
                        break;
                    case "patience":
                        audioFileReader = new AudioFileReader("Chatwheel_patience.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_patience.wav");
                        break;
                    case "wow":
                        audioFileReader = new AudioFileReader("Chatwheel_wow.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_wow.wav");
                        break;
                    case "all_dead":
                        audioFileReader = new AudioFileReader("Chatwheel_all_dead.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_all_dead.wav");
                        break;
                    case "ay_ay_ay":
                        audioFileReader = new AudioFileReader("Chatwheel_ay_ay_ay.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_ay_ay_ay.wav");
                        break;
                    case "bozhe_ti_posmotri":
                        audioFileReader = new AudioFileReader("Chatwheel_bozhe_ti_posmotri.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_bozhe_ti_posmotri.wav");
                        break;
                    case "brutal":
                        audioFileReader = new AudioFileReader("Chatwheel_brutal.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_brutal.wav");
                        break;
                    case "crowd_lv_02":
                        audioFileReader = new AudioFileReader("Chatwheel_crowd_lv_02.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_crowd_lv_02.wav");
                        break;
                    default:
                            audioFileReader = new AudioFileReader("Chatwheel_crowd_lv_02.wav");
                        audioFileReader2 = new AudioFileReader("Chatwheel_crowd_lv_02.wav");
                        break;
                }

                waveOutDevice.Init(audioFileReader);
                playbackDevice.Init(audioFileReader2);

                waveOutDevice.Play();
                playbackDevice.Play();
                while (waveOutDevice.PlaybackState == PlaybackState.Playing || playbackDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
                audioFileReader.Dispose();
                waveOutDevice.Dispose();
                playbackDevice.Dispose();

        }
            ).Start();

        e.Handled = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDevice = ((ListBox) sender).SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPlaybackDevice = ((ListBox)sender).SelectedIndex;
        }

        //private void num0ddb_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string sound = (((ComboBox)sender).SelectedItem).ToString();
        //    Keys key = Keys.NumPad0;
        //    setHotKey(key, sound);

        //}

        //private void setHotKey(Keys key, string sound)
        //{
        //    //this is causing an exception if keys are re-binded during runtime
        //    HotkeyManager.Current.Remove(sound);
        //    HotkeyManager.Current.AddOrReplace(sound, key, OnSoundTrigger);
        //}
    }
}
