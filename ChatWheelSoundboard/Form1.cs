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
using System.IO;
using System.Reflection;

namespace ChatWheelSoundboard
{
    public partial class Form1 : Form
    {
        //IWavePlayer waveOutDevice;
        int maxDevices;
        int currentDevice;
        int currentPlaybackDevice = 0;

        List<string> waves = new List<string>
        {
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
            "crowd_lv_02",
            "echo",
            "i_cant_believe",
            "lakad_matatag",
            "money",
            "next_level_play",
            "oy_oy"
        };
        static SoundMapping[] mapping =
        {
            new SoundMapping{ Display = "Crybaby", Wav = "crybaby"},
            new SoundMapping{ Display = "It's a disastah!", Wav = "disastah"},
            new SoundMapping{ Display = "Drum roll", Wav = "drum_roll"},
            new SoundMapping{ Display = "Это ГГ" , Wav = "ehto_g_g"},
            new SoundMapping{ Display =  "Это. Просто. Нечто.", Wav = "eto_prosto_netchto"},
            new SoundMapping{ Display = "Frog", Wav = "frog"},
            new SoundMapping{ Display = "Headshake", Wav = "headshake"},
            new SoundMapping{ Display = "加油！", Wav = "jia_you"},
            new SoundMapping{ Display = "Patience from Zhou", Wav = "patience"},
            new SoundMapping{ Display = "破两路更好打，是吧？", Wav = "po_liang_lu"},
            new SoundMapping{ Display = "Ba-dum tishh", Wav = "rimshot"},
            new SoundMapping{ Display = "Sad trombone", Wav = "sad_bone"},
            new SoundMapping{ Display = "天火！", Wav = "tian_huo"},
            new SoundMapping{ Display = "玩不了啦！", Wav = "wan_bu_liao_la"},
            new SoundMapping{ Display = "Waow", Wav = "wow"},
            new SoundMapping{ Display = "Жил до конца, умер как герой", Wav = "zhil_do_konsta"},
            new SoundMapping{ Display = "走好，不送", Wav = "zou_hao_bu_song"},
            new SoundMapping{ Display = "They're all dead!", Wav = "all_dead"},
            new SoundMapping{ Display = "Ай-ай-ай-ай-ай, что сейчас произошло!", Wav = "ay_ay_ay"},
            new SoundMapping{ Display = "Боже, ты посмотри вокруг, что происходит!", Wav = "bozhe_ti_posmotri"},
            new SoundMapping{ Display = "Brutal. Savage. Rekt.", Wav = "brutal"},
            new SoundMapping{ Display = "Charge", Wav = "charge"},
            new SoundMapping{ Display = "Crash and burn", Wav = "crash_burn"},
            new SoundMapping{ Display = "Crickets", Wav = "cricket"},
            new SoundMapping{ Display = "Applause", Wav = "crowd_lv_02"},
            new SoundMapping{ Display = "Easiest Money of my Life", Wav = "money"},
            new SoundMapping{ Display = "Echo Slamma Jamma", Wav = "echo"},
            new SoundMapping{ Display = "I can't believe what were seeing. What just happened?", Wav = "i_cant_believe"},
            new SoundMapping{ Display = "Lakad Matataaag, Normalin, Normalin", Wav = "lakad_matatag"},
            new SoundMapping{ Display = "Oyoy oy oy oy oy oy oy oy!", Wav = "oy_oy"},
            new SoundMapping{ Display = "The next level play!", Wav = "next_level_play"}
        };

        SoundMapping[] num0_val = new SoundMapping[mapping.Length];
        SoundMapping[] num1_val = new SoundMapping[mapping.Length];
        SoundMapping[] num2_val = new SoundMapping[mapping.Length];
        SoundMapping[] num3_val = new SoundMapping[mapping.Length];
        SoundMapping[] num4_val = new SoundMapping[mapping.Length];
        SoundMapping[] num5_val = new SoundMapping[mapping.Length];
        SoundMapping[] num6_val = new SoundMapping[mapping.Length];
        SoundMapping[] num7_val = new SoundMapping[mapping.Length];
        SoundMapping[] num8_val = new SoundMapping[mapping.Length];
        SoundMapping[] num9_val = new SoundMapping[mapping.Length];
        
        
    

        public Form1()
        {
            
            InitializeComponent();

            mapping.CopyTo(num0_val, 0);
            mapping.CopyTo(num1_val, 0);
            mapping.CopyTo(num2_val, 0);
            mapping.CopyTo(num3_val, 0);
            mapping.CopyTo(num4_val, 0);
            mapping.CopyTo(num5_val, 0);
            mapping.CopyTo(num6_val, 0);
            mapping.CopyTo(num7_val, 0);
            mapping.CopyTo(num8_val, 0);
            mapping.CopyTo(num9_val, 0);

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

            num0ddb.DataSource = num0_val;
            num1ddb.DataSource = num1_val;
            num2ddb.DataSource = num2_val;
            num3ddb.DataSource = num3_val;
            num4ddb.DataSource = num4_val;
            num5ddb.DataSource = num5_val;
            num6ddb.DataSource = num6_val;
            num7ddb.DataSource = num7_val;
            num8ddb.DataSource = num8_val;
            num9ddb.DataSource = num9_val;

            num0ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num0);
            num0ddb.DisplayMember = "Display";
            num0ddb.ValueMember = "Wav";
            num1ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num1);
            num1ddb.DisplayMember = "Display";
            num1ddb.ValueMember = "Wav";
            num2ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num2);
            num2ddb.DisplayMember = "Display";
            num2ddb.ValueMember = "Wav";
            num3ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num3);
            num3ddb.DisplayMember = "Display";
            num3ddb.ValueMember = "Wav";
            num4ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num4);
            num4ddb.DisplayMember = "Display";
            num4ddb.ValueMember = "Wav";
            num5ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num5);
            num5ddb.DisplayMember = "Display";
            num5ddb.ValueMember = "Wav";
            num6ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num6);
            num6ddb.DisplayMember = "Display";
            num6ddb.ValueMember = "Wav";
            num7ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num7);
            num7ddb.DisplayMember = "Display";
            num7ddb.ValueMember = "Wav";
            num8ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num8);
            num8ddb.DisplayMember = "Display";
            num8ddb.ValueMember = "Wav";
            num9ddb.SelectedIndex = waves.IndexOf(Properties.Settings.Default.num9);
            num9ddb.DisplayMember = "Display";
            num9ddb.ValueMember = "Wav";


            HotkeyManager.Current.AddOrReplace("num0", Keys.NumPad0, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num1", Keys.NumPad1, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num2", Keys.NumPad2, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num3", Keys.NumPad3, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num4", Keys.NumPad4, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num5", Keys.NumPad5, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num6", Keys.NumPad6, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num7", Keys.NumPad7, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num8", Keys.NumPad8, OnSoundTrigger);
            HotkeyManager.Current.AddOrReplace("num9", Keys.NumPad9, OnSoundTrigger);


            currentDevice = maxDevices - 1;
            inputListBox.SetSelected(currentDevice, true);
            currentDevice = maxDevices - 1;
        }


        private void OnSoundTrigger(object sender, HotkeyEventArgs e)
        {

            new Thread(() =>
            {
                WaveFileReader audioFileReader;
                WaveFileReader audioFileReader2;
                WaveOut waveOutDevice;
                waveOutDevice = new WaveOut();
                waveOutDevice.DeviceNumber = currentDevice;

                WaveOut playbackDevice;
                playbackDevice = new WaveOut();
                playbackDevice.DeviceNumber = currentPlaybackDevice;
                
                switch (e.Name)
                {
                    case "num0":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num0));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num0));
                        break;
                    case "num1":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num1));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num1));
                        break;
                    case "num2":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num2));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num2));
                        break;
                    case "num3":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num3));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num3));
                        break;
                    case "num4":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num4));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num4));
                        break;
                    case "num5":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num5));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num5));
                        break;
                    case "num6":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num6));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num6));
                        break;
                    case "num7":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num7));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num7));
                        break;
                    case "num8":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num8));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num8));
                        break;
                    case "num9":
                        audioFileReader = new WaveFileReader(getSoundResource(Properties.Settings.Default.num9));
                        audioFileReader2 = new WaveFileReader(getSoundResource(Properties.Settings.Default.num9));
                        break;
                    default:
                        audioFileReader = new WaveFileReader(getSoundResource("default"));
                        audioFileReader2 = new WaveFileReader(getSoundResource("default"));
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

        private UnmanagedMemoryStream getSoundResource(string identifier)
        {

            switch (identifier)
            {
                case "crybaby":
                    return Properties.Resources.Chatwheel_crybaby;
                case "disastah":
                    return Properties.Resources.Chatwheel_disastah;
                case "drum_roll":
                    return Properties.Resources.Chatwheel_drum_roll;
                case "ehto_g_g":
                    return Properties.Resources.Chatwheel_ehto_g_g;
                case "eto_prosto_netchto":
                    return Properties.Resources.Chatwheel_eto_prosto_netchto;
                case "frog":
                    return Properties.Resources.Chatwheel_frog;
                case "headshake":
                    return Properties.Resources.Chatwheel_headshake;
                case "jia_you":
                    return Properties.Resources.Chatwheel_jia_you;
                case "patience":
                    return Properties.Resources.Chatwheel_patience;
                case "po_liang_lu":
                    return Properties.Resources.Chatwheel_po_liang_lu;
                case "rimshot":
                    return Properties.Resources.Chatwheel_rimshot;
                case "sad_bone":
                    return Properties.Resources.Chatwheel_sad_bone;
                case "tian_huo":
                    return Properties.Resources.Chatwheel_tian_huo;
                case "wan_bu_liao_la":
                    return Properties.Resources.Chatwheel_wan_bu_liao_la;
                case "wow":
                    return Properties.Resources.Chatwheel_wow;
                case "zhil_do_konsta":
                    return Properties.Resources.Chatwheel_zhil_do_konsta;
                case "zou_hao_bu_song":
                    return Properties.Resources.Chatwheel_zou_hao_bu_song;
                case "all_dead":
                    return Properties.Resources.Chatwheel_all_dead;
                case "ay_ay_ay":
                    return Properties.Resources.Chatwheel_ay_ay_ay;
                case "bozhe_ti_posmotri":
                    return Properties.Resources.Chatwheel_bozhe_ti_posmotri;
                case "brutal":
                    return Properties.Resources.Chatwheel_brutal;
                case "charge":
                    return Properties.Resources.Chatwheel_charge;
                case "crash_burn":
                    return Properties.Resources.Chatwheel_crash_burn;
                case "cricket":
                    return Properties.Resources.Chatwheel_cricket;
                case "crowd_lv_02":
                    return Properties.Resources.Chatwheel_Crowd_lv_02;
                case "echo":
                    return Properties.Resources.Chatwheel_echo;
                case "i_cant_believe":
                    return Properties.Resources.Chatwheel_i_cant_believe;
                case "lakad_matatag":
                    return Properties.Resources.Chatwheel_lakad_matatag;
                case "money":
                    return Properties.Resources.Chatwheel_money;
                case "next_level_play":
                    return Properties.Resources.Chatwheel_next_level_play;
                case "oy_oy":
                    return Properties.Resources.Chatwheel_oy_oy;
             default:
                    return Properties.Resources.Chatwheel_cricket;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDevice = ((ListBox) sender).SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPlaybackDevice = ((ListBox)sender).SelectedIndex;
        }

        private void num0ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num0ddb.SelectedValue.ToString();
            Properties.Settings.Default.num0 = sound;
            Properties.Settings.Default.Save();
        }
        private void num1ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num1ddb.SelectedValue.ToString();
            Properties.Settings.Default.num1 = sound;
            Properties.Settings.Default.Save();
        }

        private void num2ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num2ddb.SelectedValue.ToString();
            Properties.Settings.Default.num2 = sound;
            Properties.Settings.Default.Save();
        }

        private void num3ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num3ddb.SelectedValue.ToString();
            Properties.Settings.Default.num3 = sound;
            Properties.Settings.Default.Save();
        }

        private void num4ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num4ddb.SelectedValue.ToString();
            Properties.Settings.Default.num4 = sound;
            Properties.Settings.Default.Save();
        }

        private void num5ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num5ddb.SelectedValue.ToString();
            Properties.Settings.Default.num5 = sound;
            Properties.Settings.Default.Save();
        }

        private void num6ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num6ddb.SelectedValue.ToString();
            Properties.Settings.Default.num6 = sound;
            Properties.Settings.Default.Save();
        }

        private void num7ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num7ddb.SelectedValue.ToString();
            Properties.Settings.Default.num7 = sound;
            Properties.Settings.Default.Save();
        }

        private void num8ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num8ddb.SelectedValue.ToString();
            Properties.Settings.Default.num8 = sound;
            Properties.Settings.Default.Save();
        }

        private void num9ddb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sound = num9ddb.SelectedValue.ToString();
            Properties.Settings.Default.num9 = sound;
            Properties.Settings.Default.Save();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/derdanielb");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/derdanielb/Dota-2-Chat-Wheel-Soundboard/graphs/contributors");
        }
    }
}
