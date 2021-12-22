using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Management;
using System.Diagnostics;
using System.IO;

namespace MCCheatFinder
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Сообщение перед запуском, раскомментируйте если нужно. MessageBox.Show("Пожалуйста не закрывайте программу до окончания проверки ПРОВЕРЯЮЩИМ! Вам может понадобиться скопировать ID Проверки уже после проверки программой и передать его проверяющему.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DateTime now = DateTime.Now;
            string datedmy = now.ToString("dd.MM.yyyy");
            string datehms = now.ToString("hh:mm:ss");
            string datefull = datedmy + datehms;

            string GetHash()
            {
                var md5 = MD5.Create();
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(datefull));

                return Convert.ToBase64String(hash);
            }

            label1.Text = "ID Проверки: " + GetHash();
        }

        string[] mcversions = new string[] { "1.8", "1.8.1", "1.8.2", "1.8.3", "1.8.4", "1.8.5", "1.8.6", "1.8.7", "1.8.8", "1.8.9", "1.9", "1.9.1", "1.9.2", "1.9.3", "1.9.4", "1.10", "1.10.1", "1.10.2", "1.11", "1.11.1", "1.11.2", "1.12", "1.12.1", "1.12.2", "1.13", "1.13.1", "1.13.2", "1.14", "1.14.1", "1.14.2", "1.14.3", "1.14.4", "1.15", "1.15.1", "1.15.2", "1.16", "1.16.1", "1.16.2", "1.16.3", "1.16.4", "1.16.5", "1.17" }; //42 версии всего
        string[] impactversions = new string[] { "-Impact_4.9.1", "-Impact_4.8.3", "-Impact_4.8.2", "-Impact_4.8.1", "-Impact_4.7.3", "-Impact_4.7.2", "-Impact_4.7.1", "-Impact_4.6", "-Impact_4.5", "-Impact_4.4", "-Impact_4.3", "-Impact_4.2", "-Impact_4.1", "-Impact_4.0"};

        public string mcdir = "C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\versions";

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(mcdir + "\\" + mcversions[20] + impactversions[13]))
            {
                richTextBox1.Text = richTextBox1.Text + "Найден " + mcversions[20] + impactversions[13];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[20] + impactversions[13] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[21] + impactversions[13]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[21] + impactversions[13];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[21] + impactversions[13] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[22] + impactversions[12]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[22] + impactversions[12];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[22] + impactversions[12] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[1]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[1];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[1] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[2]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[2];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[2] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[3]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[3];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[3] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[4]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[4];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[4] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[5]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[5];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[5] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[6]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[6];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[6] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[7]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[7];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[7] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[8]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[8];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[8] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[9]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[9];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[9] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[10]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[10];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[10] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[11]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[11];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[11] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[23] + impactversions[12]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[23] + impactversions[12];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[23] + impactversions[12] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[26] + impactversions[1]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[26] + impactversions[1];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[26] + impactversions[1] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[26] + impactversions[2]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[26] + impactversions[2];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[26] + impactversions[2] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[26] + impactversions[3]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[26] + impactversions[3];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[26] + impactversions[3] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[26] + impactversions[4]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[26] + impactversions[4];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[26] + impactversions[4] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[26] + impactversions[5]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[26] + impactversions[5];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[26] + impactversions[5] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[26] + impactversions[6]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[26] + impactversions[6];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[26] + impactversions[6] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[26] + impactversions[7]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[26] + impactversions[7];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[26] + impactversions[7] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[31] + impactversions[1]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[31] + impactversions[1];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[31] + impactversions[1] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[31] + impactversions[2]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[31] + impactversions[2];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[31] + impactversions[2] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[31] + impactversions[3]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[31] + impactversions[3];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[31] + impactversions[3] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[31] + impactversions[4]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[31] + impactversions[4];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[31] + impactversions[4] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[34] + impactversions[1]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[34] + impactversions[1];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[34] + impactversions[1] + " НЕ найден.";
            }
            if (Directory.Exists(mcdir + "\\" + mcversions[40] + impactversions[1]))
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + "Найден " + mcversions[40] + impactversions[1];
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + mcversions[40] + impactversions[1] + " НЕ найден.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text, TextDataFormat.UnicodeText);
        }

    }
}
