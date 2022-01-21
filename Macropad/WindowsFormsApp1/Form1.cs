using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Port;

        string[] Commands = {
            "A",
            "B",
            "C",
            "D" ,
            "E" ,
            "F" ,
            "G" ,
            "H" ,
            "I" ,
            "J" ,
            "K" ,
            "L" ,
            "M" ,
            "Ñ" ,
            "O" ,
            "P" ,
            "Q" ,
            "R" ,
            "S" ,
            "T" ,
            "U" ,
            "V" ,
            "W" ,
            "X" ,
            "Y" ,
            "Z" ,
            "1" ,
            "2" ,
            "3" ,
            "4" ,
            "5" ,
            "6" ,
            "7" ,
            "8" ,
            "9" ,
            "0" ,
            "ENTER",
            "ESC" ,
            "BACKSPACE" ,
            "TAB" ,
            "SPACE" ,
            "-",
            "=" ,
            "{" ,
            "}" ,
            "\\",
            "NON US" ,
            ";" ,
            "\"" ,
            "`" ,
            "," ,
            "." ,
            "/" ,
            "CAPS LOCK" ,
            "F1" ,
            "F2" ,
            "F3" ,
            "F4" ,
            "F5" ,
            "F6" ,
            "F7" ,
            "F8" ,
            "F9" ,
            "F10" ,
            "F11" ,
            "F12" ,
            "PRINT SCREEN" ,
            "SCROLL LOCK" ,
            "PAUSE" ,
            "INSERT" ,
            "HOME" ,
            "PAGE UP" ,
            "DELETE" ,
            "END" ,
            "PAGE DOWN" ,
            "RIGHT ARROW" ,
            "LEFT ARROW" ,
            "DOWN ARROW" ,
            "UP ARROW" ,
        };
        string[] WindowsShortcuts =
        {
            "Show desktop",
            "Task manager",
            "Open notifications",
            "Copy",
            "Paste",
            "Cut",
            "Undo",
            "Redo"
        };
        string[] Numpad =
        {
            "Num /",
            "Num *",
            "Num -",
            "Num +",
            "Num Enter",
            "Num 1",
            "Num 2",
            "Num 3",
            "Num 4",
            "Num 5",
            "Num 6",
            "Num 7",
            "Num 8",
            "Num 9",
            "Num 0",
            "Num Dot",
            "^",
            "<",
            ">",
            "(",
            ")"
        };

        int selectedLabel = 0;
        Label lb;

        ArrayList profileKeyList = new ArrayList();

        Dictionary<string, byte[]> IDs = new Dictionary<string, byte[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bluetooth_init();
            loadDictionary();
            foreach (Control contr in Controls)
            {
                if (contr is Button)
                {
                    contr.MouseHover += new EventHandler(button_MouseHover);
                    contr.MouseLeave += new EventHandler(button_MouseLeave);
                }
                if (contr is Label)
                {
                    contr.Click += new EventHandler(label_Enter);
                    contr.MouseHover += new EventHandler(button_MouseHover);
                    contr.MouseLeave += new EventHandler(button_MouseLeave);
                }
            }

            listBox1.Items.AddRange(Commands);
            comboBox2.SelectedIndex = 0;

            if (Settings.Default.profileNames != null)
            {
                comboBox1.Items.AddRange(Settings.Default.profileNames.ToArray());
                comboBox1.SelectedIndex = 0;
            }
            profileKeyList = Settings.Default.profileKeys;
            label1.Text = Settings.Default.profileKeys.Count.ToString();
            if (Settings.Default.profileKeys.Count <= 0)
            {
                profileKeyList.Add("A");
                profileKeyList.Add("B");
                profileKeyList.Add("C");
                profileKeyList.Add("D");
                profileKeyList.Add("E");
                profileKeyList.Add("F");
                KeyLabel1.Text = (string)profileKeyList[0 + 6 * comboBox1.SelectedIndex];
                KeyLabel2.Text = (string)profileKeyList[1 + 6 * comboBox1.SelectedIndex];
                KeyLabel3.Text = (string)profileKeyList[2 + 6 * comboBox1.SelectedIndex];
                KeyLabel4.Text = (string)profileKeyList[3 + 6 * comboBox1.SelectedIndex];
                KeyLabel5.Text = (string)profileKeyList[4 + 6 * comboBox1.SelectedIndex];
                KeyLabel6.Text = (string)profileKeyList[5 + 6 * comboBox1.SelectedIndex];
            }
            else
            {
            }

        }
        private void loadDictionary()
        {
            string s;
            for (int i = 0; i < 26; i++)
            {
                s = ((char)(i + 65)).ToString();
                IDs.Add(s, new byte[] { (byte)(i + 4) });
            }                                               //Letras
            for (int i = 0; i < 9; i++)
            {
                s = ((char)(i + 48)).ToString();
                IDs.Add(s, new byte[] { (byte)(i + 4) });
            }                                               //numeros

            IDs.Add("ENTER", new byte[] { 0x27 });
            IDs.Add("RETURN", new byte[] { 0x28 });
            IDs.Add("ESC", new byte[] { 0x29 });
            IDs.Add("BACKSPACE", new byte[] { 0x2A });
            IDs.Add("TAB", new byte[] { 0x2B });
            IDs.Add("SPACE", new byte[] { 0x2C });
            IDs.Add("-", new byte[] { 0x2D });
            IDs.Add("=", new byte[] { 0x2E });
            IDs.Add("[", new byte[] { 0x2F });
            IDs.Add("]", new byte[] { 0x30 });
            IDs.Add("\\", new byte[] { 0x31 });
            IDs.Add("NON US", new byte[] { 0x32 });
            IDs.Add(";", new byte[] { 0x33 });
            IDs.Add("", new byte[] { 0x34 });
            IDs.Add("`", new byte[] { 0x35 });
            IDs.Add(",", new byte[] { 0x36 });
            IDs.Add(".", new byte[] { 0x37 });
            IDs.Add("/", new byte[] { 0x38 });
            IDs.Add("CAPS LOCK", new byte[] { 0x39 });
            IDs.Add("F1", new byte[] { 0x3A });
            IDs.Add("F2", new byte[] { 0x3B });
            IDs.Add("F3", new byte[] { 0x3C });
            IDs.Add("F4", new byte[] { 0x3D });
            IDs.Add("F5", new byte[] { 0x3E });
            IDs.Add("F6", new byte[] { 0x3F });
            IDs.Add("F7", new byte[] { 0x40 });
            IDs.Add("F8", new byte[] { 0x41 });
            IDs.Add("F9", new byte[] { 0x42 });
            IDs.Add("F10", new byte[] { 0x43 });
            IDs.Add("F11", new byte[] { 0x44 });
            IDs.Add("F12", new byte[] { 0x45 });
            IDs.Add("PRINTSCREEN", new byte[] { 0x46 });
            IDs.Add("SCROLL LOCK", new byte[] { 0x47 });
            IDs.Add("PAUSE", new byte[] { 0x48 });
            IDs.Add("INSERT", new byte[] { 0x49 });
            IDs.Add("HOME", new byte[] { 0x4A });
            IDs.Add("PAGE UP", new byte[] { 0x4B });
            IDs.Add("DELETE", new byte[] { 0x4C });
            IDs.Add("END", new byte[] { 0x4D });
            IDs.Add("PAGE DOWN", new byte[] { 0x4E });
            IDs.Add("RIGHT ARROW", new byte[] { 0x4F });
            IDs.Add("LEFT ARROW", new byte[] { 0x50 });
            IDs.Add("DOWN ARROW", new byte[] { 0x51 });
            IDs.Add("UP ARROW", new byte[] { 0x52 });
            IDs.Add("Num LOCK", new byte[] { 0x53 });
            IDs.Add("Num /", new byte[] { 0x54 });
            IDs.Add("Num *", new byte[] { 0x55 });
            IDs.Add("Num -", new byte[] { 0x56 });
            IDs.Add("Num +", new byte[] { 0x57 });
            IDs.Add("Num ENTER", new byte[] { 0x58 });
            IDs.Add("Num 1", new byte[] { 0x59 });
            IDs.Add("Num 2", new byte[] { 0x5A });
            IDs.Add("Num 3", new byte[] { 0x5B });
            IDs.Add("Num 4", new byte[] { 0x5C });
            IDs.Add("Num 5", new byte[] { 0x5D });
            IDs.Add("Num 6", new byte[] { 0x5E });
            IDs.Add("Num 7", new byte[] { 0x5F });
            IDs.Add("Num 8", new byte[] { 0x60 });
            IDs.Add("Num 9", new byte[] { 0x61 });
            IDs.Add("Num 0", new byte[] { 0x62 });
            IDs.Add("Num .", new byte[] { 0x63 });
            IDs.Add("Show desktop", new byte[] { 0xE3, 0x07 });
            IDs.Add("Open notifications", new byte[] { 0xE3, 17 });
            IDs.Add("Task manager", new byte[] { 0xE0, 0xE5, 41 });
            IDs.Add("Copy", new byte[] { 0xE0, 0x06 });
            IDs.Add("Cut", new byte[] { 0xE0, 27 });
            IDs.Add("Paste", new byte[] { 0xE0, 25 });
            IDs.Add("Undo", new byte[] { 0xE0, 29 });
            IDs.Add("Redo", new byte[] { 0xE0, 28 });
            IDs.Add("Mute", new byte[] { 0x7F });
            IDs.Add("Volume Up", new byte[] { 0x80 });
            IDs.Add("Volume Down", new byte[] { 0x81 });
            IDs.Add("Unlock device", new byte[] { 0x2C, 0x5A, 0x5F, 0x5A, 0x5A });
            IDs.Add("^", new byte[] { 0xE5, 35 });
            IDs.Add("<", new byte[] { 0xE5, 0x36 });
            IDs.Add(">", new byte[] { 0xE5, 0x37 });
            IDs.Add("(", new byte[] { 0xE5, 38 });
            IDs.Add(")", new byte[] { 0xE5, 39 });

        }

        private void label_Enter(object sender, EventArgs e)
        {
            foreach (Control contr in Controls)
                if (contr is Label)
                    contr.ForeColor = Color.Black;

            lb = sender as Label;
            if (lb != label1)
                lb.ForeColor = Color.FromArgb(0, 120, 255);

            if (lb.Equals(KeyLabel1))
                selectedLabel = 0;
            else if (lb.Equals(KeyLabel2))
                selectedLabel = 1;
            else if (lb.Equals(KeyLabel3))
                selectedLabel = 2;
            else if (lb.Equals(KeyLabel4))
                selectedLabel = 3;
            else if (lb.Equals(KeyLabel5))
                selectedLabel = 4;
            else if (lb.Equals(KeyLabel6))
                selectedLabel = 5;
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label lb = sender as Label;
                if (lb != label1)
                    lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label lb = sender as Label;
                if (lb != label1)
                    lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] message = new byte[15];
            byte[] value = new byte[15];
            try
            {
                KeyLabel1.Text = (string)profileKeyList[0 + 6 * comboBox1.SelectedIndex];
                KeyLabel2.Text = (string)profileKeyList[1 + 6 * comboBox1.SelectedIndex];
                KeyLabel3.Text = (string)profileKeyList[2 + 6 * comboBox1.SelectedIndex];
                KeyLabel4.Text = (string)profileKeyList[3 + 6 * comboBox1.SelectedIndex];
                KeyLabel5.Text = (string)profileKeyList[4 + 6 * comboBox1.SelectedIndex];
                KeyLabel6.Text = (string)profileKeyList[5 + 6 * comboBox1.SelectedIndex];
                for (int i = 0; i < 6; i++)
                {
                    value = IDs[(string)profileKeyList[i + 6 * comboBox1.SelectedIndex]];
                    message[0] = (byte)i;
                    for (int j = 0; j < value.Length; j++)
                        message[j + 1] = value[j];
                    sendProfile(message);
                    Thread.Sleep(35);
                }
            }
            catch
            {
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    listBox1.Items.AddRange(Commands);
                    break;
                case 1:
                    listBox1.Items.AddRange(WindowsShortcuts);
                    break;
                case 2:
                    listBox1.Items.AddRange(Numpad);
                    break;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int nItems = comboBox1.Items.Count;
            if (nItems == 0)
                comboBox1.Items.Add("New profile");
            else
                comboBox1.Items.Add("New profile(" + nItems + ")");
            comboBox1.SelectedIndex = nItems;

            profileKeyList.Add("None");
            profileKeyList.Add("None");
            profileKeyList.Add("None");
            profileKeyList.Add("None");
            profileKeyList.Add("None");
            profileKeyList.Add("None");

            KeyLabel1.Text = (string)profileKeyList[0 + 6 * nItems];
            KeyLabel2.Text = (string)profileKeyList[1 + 6 * nItems];
            KeyLabel3.Text = (string)profileKeyList[2 + 6 * nItems];
            KeyLabel4.Text = (string)profileKeyList[3 + 6 * nItems];
            KeyLabel5.Text = (string)profileKeyList[4 + 6 * nItems];
            KeyLabel6.Text = (string)profileKeyList[5 + 6 * nItems];

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int itemIndex = comboBox1.SelectedIndex;
            if (comboBox1.Items.Count > 1)
            {
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.SelectedIndex = itemIndex - 1;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] message = new byte[15];
            byte[] value = new byte[15];
            string selected = listBox1.Items[listBox1.SelectedIndex].ToString();
            message[0] = (byte)selectedLabel;
            lb.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            if (IDs.ContainsKey(selected))
            {
                profileKeyList.RemoveAt(selectedLabel + 6 * comboBox1.SelectedIndex);
                profileKeyList.Insert(selectedLabel + 6 * comboBox1.SelectedIndex, selected);

                value = IDs[listBox1.Items[listBox1.SelectedIndex].ToString()];
                for (int i = 0; i < value.Length; i++)
                    message[i + 1] = value[i];
                sendProfile(message);
            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ArrayList arraylist = new ArrayList(comboBox1.Items);
            Settings.Default.profileKeys = profileKeyList;
            Settings.Default.profileNames = arraylist;
            Settings.Default.Save();
        }

        public void Bluetooth_init()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);
            Port = new System.IO.Ports.SerialPort();
            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();
                    if (desc.Contains("Arduino"))
                    {
                        labelPort.Text = deviceId;
                        Port.PortName = deviceId;
                        Port.BaudRate = 9600;
                        Port.ReadTimeout = 500;
                        Port.WriteTimeout = 500;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Arduino could not found");
            }
        }
        public void sendProfile(byte[] data)
        {
            try
            {
                if (!Port.IsOpen)
                    Port.Open();
                if (data[0] < 0x07)
                    Port.Write(data, 0, data.Length);
                Port.Close();

            }
            catch
            {
                MessageBox.Show("Error. Port can not be opened");
            }
        }

    }

}

