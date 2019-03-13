using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using static MasternodeHoster.Form1;

namespace MasternodeHoster
{
    public partial class AddMasternode : Form
    {
        public AddMasternode()
        {
            InitializeComponent();
        }



        private void AddMasternode_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                //file.InitialDirectory = textBox19.Text;
                file.RestoreDirectory = true;
                file.Title = "Select Masternode Wallet File";
                file.Multiselect = false;

                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox19.Text = file.FileName;
                    try
                    {
                        string nameWithoutExe = file.SafeFileName.Replace(".exe", "");
                        string nameWithoutQT = nameWithoutExe.Replace("-qt", "");
                        textBox7.Text = nameWithoutQT;
                    }
                    catch { }
                    


                }
            }
            catch { }
        }
        void changeLine(RichTextBox RTB, int line, string text)
        {
            int s1 = RTB.GetFirstCharIndexFromLine(line);
            int s2 = line < RTB.Lines.Count() - 1 ?
                      RTB.GetFirstCharIndexFromLine(line + 1) - 1 :
                      RTB.Text.Length;
            RTB.Select(s1, s2 - s1);
            RTB.SelectedText = text;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            checkBox1.Checked = true;
           checkBox2.Checked = true;
            string externalip = new System.Net.WebClient().DownloadString("http://icanhazip.com");
            string replacement = Regex.Replace(externalip, @"\t|\n|\r", "");

            textBox4.Text = replacement;
        }

        private void richTextMaker()
        {
            string rpcport = textBox1.Text;
            if (textBox1.Text == "")
            {
                rpcport = "rpcport";
            }
            string masternodeport = textBox2.Text;
            if (textBox2.Text == "")
            {
                masternodeport = "masternodeport";
            }
            string masternodeprivatekey = textBox3.Text;
            if (textBox3.Text == "")
            {
                masternodeprivatekey = "masternodeprivatekey";
            }
            string myexternalip = textBox4.Text;
            if (textBox4.Text == "")
            {
                myexternalip = "myexternalip";
            }
            string txid = textBox5.Text;
            if (textBox5.Text == "")
            {
                txid = "txid";
            }
            string txindex = textBox6.Text;
            if (textBox6.Text == "")
            {
                txindex = "txindex";
            }
            string rpcuser = textBox8.Text;
            if (textBox8.Text == "")
            {
                rpcuser = "rpcuser";
            }
            string rpcpassword = textBox9.Text;
            if (textBox9.Text == "")
            {
                rpcpassword = "rpcpassword";
            }

            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox1.Text += "server=1";
            richTextBox1.Text += Environment.NewLine + "rpcallowip=127.0.0.1";
            richTextBox1.Text += Environment.NewLine + "listen=1";
            richTextBox1.Text += Environment.NewLine + "daemon=1";
            richTextBox1.Text += Environment.NewLine + "masternode=1";
            richTextBox1.Text += Environment.NewLine + "externalip=" + myexternalip;
            richTextBox1.Text += Environment.NewLine + "rpcuser=" + rpcuser;
            richTextBox1.Text += Environment.NewLine + "rpcpassword=" + rpcpassword;
            richTextBox1.Text += Environment.NewLine + "rpcport=" + rpcport;
            richTextBox1.Text += Environment.NewLine + "port=" + masternodeport;
            richTextBox1.Text += Environment.NewLine + "masternodeprivkey=" + masternodeprivatekey;

            richTextBox2.Text = "01 " + myexternalip + ":" + masternodeport + " " + masternodeprivatekey + " " + txid + " " + txindex;

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox19.Text != "")
            { button1.Enabled = true; }
            else
            {                button1.Enabled = false;            }

        }
       


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            richTextMaker();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            richTextMaker();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[12];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                textBox8.Text = finalString;
            }
            if (checkBox1.Checked == false)
            {
                textBox8.Text = "";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[12];
                var random = new Random();
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                var finalString = new String(stringChars);
                textBox9.Text = finalString;
            }
            if (checkBox2.Checked == false)
            {
                textBox9.Text = "";
            }
        }

        public static class MasternodeParameters
        {
            public static string walletlocation { get; set; }
            public static string rpcport { get; set; }
            public static string masternodeport { get; set; }
            public static string masternodeprivatekey { get; set; }
            public static string myexternalip { get; set; }
            public static string txid { get; set; }
            public static string txindex { get; set; }
            public static string rpcuser { get; set; }
            public static string rpcpassword { get; set; }
            public static string coinname { get; set; }
            public static string wallettargetlocation { get; set; }
            public static string dashclitargetlocation { get; set; }
            public static string dashconftargetlocation { get; set; }
            public static bool  isAddMasternodeFormClosed { get; set; }
        }







        private void button1_Click(object sender, EventArgs e)
        {
            MasternodeParameters.walletlocation = textBox19.Text;
            MasternodeParameters.rpcport = textBox1.Text;
            MasternodeParameters.masternodeport = textBox2.Text;
            MasternodeParameters.masternodeprivatekey = textBox3.Text;
            MasternodeParameters.myexternalip = textBox4.Text;
            MasternodeParameters.txid = textBox5.Text;
            MasternodeParameters.txindex = textBox6.Text;
            MasternodeParameters.rpcuser = textBox8.Text;
            MasternodeParameters.rpcpassword = textBox9.Text;
            MasternodeParameters.coinname = textBox7.Text;
            MasternodeParameters.wallettargetlocation = MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\" + MasternodeParameters.coinname+".exe";
            MasternodeParameters.dashclitargetlocation = MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\masternodecontrol-cli.exe";
            MasternodeParameters.dashconftargetlocation = MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\masternodecontrol.conf";
            Directory.CreateDirectory(MasternodeHosterParameters.workingdirectory + "\\"+ MasternodeParameters.coinname);
            if (!File.Exists(MasternodeParameters.wallettargetlocation))
            {
                File.Copy(textBox19.Text, MasternodeParameters.wallettargetlocation);
            }
            else
            {
                File.Delete(MasternodeParameters.wallettargetlocation);
                File.Copy(textBox19.Text, MasternodeParameters.wallettargetlocation);
            }

            //richTextBox1.SaveFile(MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\" + MasternodeParameters.coinname + ".conf", RichTextBoxStreamType.RichText);
            File.WriteAllLines(@MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\" + MasternodeParameters.coinname + ".conf",richTextBox1.Lines);
            //File.WriteAllLines(@MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\" + "masternode.conf",richTextBox2.Lines);

            if (!File.Exists(MasternodeParameters.dashclitargetlocation))
            {
                File.Copy(@"Resources\\masternodecontrol-cli.exe", MasternodeParameters.dashclitargetlocation);
            }
            else
            {
                File.Delete(MasternodeParameters.dashclitargetlocation);
                File.Copy(@"Resources\\masternodecontrol-cli.exe", MasternodeParameters.dashclitargetlocation);
            }
            if (!File.Exists(MasternodeParameters.dashconftargetlocation))
            {
                File.Copy(@MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\" + MasternodeParameters.coinname + ".conf", MasternodeParameters.dashconftargetlocation);
            }
            else
            {
                File.Delete(MasternodeParameters.dashconftargetlocation);
                File.Copy(@MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + "\\" + MasternodeParameters.coinname + ".conf", MasternodeParameters.dashconftargetlocation);
            }
            string messageBoxMessage = "If you already have blockchain files of " + textBox7.Text + " you can copy 'blocks, chainstate, sporks etc.' folders to " + MasternodeHosterParameters.workingdirectory + "\\" + MasternodeParameters.coinname + " before starting masternode for fast sync.";
            Form1.AddMasternode(textBox7.Text);
            
            this.Close();
            MessageBox.Show(messageBoxMessage);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
