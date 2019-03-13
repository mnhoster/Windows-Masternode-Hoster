using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Configuration;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace MasternodeHoster
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        bool firstRun = true;
        string externalip;
        List<Masternode> masternodes = new List<Masternode>();
        private void InitializeListView()
        {
            olvMasternodes.SetObjects(masternodes);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            

           

            while (backgroundWorker2.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker2.RunWorkerAsync();
            }
            catch
            { MessageBox.Show("Initializing Failed, Check App.config file if it exists"); }

            while (backgroundWorker3.IsBusy == true || backgroundWorker2.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker3.RunWorkerAsync();
            }
            catch
            { MessageBox.Show("Masternode Check Engine Has Failed"); }

            while (backgroundWorker3.IsBusy == true || backgroundWorker4.IsBusy == true || backgroundWorker5.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker5.RunWorkerAsync();
            }
            catch
            { MessageBox.Show("Masternode Check Engine Has Failed"); }

        }

        private void checkWorkingDirectory()
        {
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            ConfigurationManager.RefreshSection("appSettings");
            string configvalue1 = config.AppSettings.Settings["workingdirectory"].Value;
            if (configvalue1 != "" && configvalue1.Contains(":\\"))
            {
                button4.Enabled = true;
                toolStripLabel1.Text = "Working Directory is '" + configvalue1 + "'";
                toolStripLabel2.Text = "You Can Start Masternode Engine or Add/Remove Masternode";
                if (firstRun == true)
                {
                    MasternodeChecker(true);
                }
            }
            else
            {
                
                button4.Enabled = false;
                toolStripLabel1.Text = "Working Directory cannot be empty.";
                toolStripLabel2.Text = "You Need To Select Working Directory From Settings Tab Before Adding Masternode.";
            }
            MasternodeHosterParameters.workingdirectory = configvalue1;
        }
        private static void UpdateSetting(string key, string value)
        {
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }
        public static void AddValue(string key, string value)
        {
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Minimal);
        }
        public static void AddMasternode(string value)
        {
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            string configvalue3 = config.AppSettings.Settings["masternodecount"].Value;
            int masternodecount = Int32.Parse(configvalue3);
            masternodecount = masternodecount + 1;
            config.AppSettings.Settings["masternodecount"].Value = masternodecount.ToString();
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");
            config.AppSettings.Settings.Add("masternode" + masternodecount.ToString(), value);
            config.Save(ConfigurationSaveMode.Minimal);
        }
        public static void RemoveMasternode(int key)
        {
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            string configvalue3 = config.AppSettings.Settings["masternodecount"].Value;
            int masternodecount = Int32.Parse(configvalue3);
            string targetmasternode = config.AppSettings.Settings["masternode" + key.ToString()].Value;
            config.AppSettings.Settings.Remove("masternode" + key.ToString());
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");
            masternodecount = masternodecount - 1;
            config.AppSettings.Settings["masternodecount"].Value = masternodecount.ToString();
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");

            try
            {
                File.Delete(MasternodeHosterParameters.workingdirectory + "\\" + targetmasternode + "\\" + targetmasternode + ".exe");
                File.Delete(MasternodeHosterParameters.workingdirectory + "\\" + targetmasternode + "\\" + targetmasternode + ".conf");
                Directory.Delete(MasternodeHosterParameters.workingdirectory + "\\" + targetmasternode, true);
            }
            catch
            { MessageBox.Show("Failed Deleting Masternode Files At: '" + MasternodeHosterParameters.workingdirectory + "\\" + targetmasternode + "' Please Delete Manually"); }

            for (int i = key; i <= masternodecount; i++)
            {
                string text = File.ReadAllText(configFile);
                text = text.Replace("masternode" + (i + 1).ToString(), "masternode" + i.ToString());
                File.WriteAllText(configFile, text);
            }
        }
        public void MasternodeChecker(bool checkNewNode)
        {
            listBox1.Items.Clear();
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            string configvalue3 = config.AppSettings.Settings["masternodecount"].Value;
            int masternodecount = Int32.Parse(configvalue3);

            string workingdirectory = config.AppSettings.Settings["workingdirectory"].Value;

            var directories = Directory.GetDirectories(workingdirectory);

            var directoryList = new List<string>();

            var masternodeList = new List<string>();

            string configvalue4 = config.AppSettings.Settings["checkworkingdirectoryformasternodeconfigs"].Value;

            int oldmasternodecount = masternodecount;


            bool isConfigFound = false;
            foreach (string directory in directories)
            {
                if (checkNewNode == true && masternodecount == 0 && configvalue4 == "1")
                {
                    if (File.Exists(directory + "\\" + Path.GetFileName(Path.GetDirectoryName(directory + "\\")) + ".exe"))
                    {
                        if (File.Exists(directory + "\\" + Path.GetFileName(Path.GetDirectoryName(directory + "\\")) + ".conf"))
                            isConfigFound = true;
                        {
                            DialogResult dialogResult = MessageBox.Show("Do You Want To Import " + Path.GetFileName(Path.GetDirectoryName(directory + "\\")) + " ?", "Masternode Config Found For " + Path.GetFileName(Path.GetDirectoryName(directory + "\\")) + " At Working Directory", MessageBoxButtons.YesNoCancel);
                            if (dialogResult == DialogResult.Yes)
                            {
                                AddMasternode(Path.GetFileName(Path.GetDirectoryName(directory + "\\")));
                            }
                            else if (dialogResult == DialogResult.No)
                            {

                            }
                            else if (dialogResult == DialogResult.Cancel)
                            {
                                DialogResult dialogResult1 = MessageBox.Show("Do You Want To Disable Working Directory Check for Old Configs?", "Working Directory Check for Old Configs", MessageBoxButtons.YesNo);
                                if (dialogResult1 == DialogResult.Yes)
                                {
                                    UpdateSetting("checkworkingdirectoryformasternodeconfigs", "0");
                                    while (backgroundWorker3.IsBusy == true)
                                    {
                                        Application.DoEvents();
                                    }
                                    try
                                    {
                                        backgroundWorker3.RunWorkerAsync();
                                    }
                                    catch
                                    { MessageBox.Show("Refreshing Masternode List Has Failed"); }
                                    break;
                                }
                                else if (dialogResult1 == DialogResult.No)
                                {
                                    UpdateSetting("checkworkingdirectoryformasternodeconfigs", "1");
                                    while (backgroundWorker3.IsBusy == true)
                                    {
                                        Application.DoEvents();
                                    }
                                    try
                                    {
                                        backgroundWorker3.RunWorkerAsync();
                                    }
                                    catch
                                    { MessageBox.Show("Refreshing Masternode List Has Failed"); }
                                    break;
                                }
                            }
                            //listBox1.Items.Add(Path.GetFileName(Path.GetDirectoryName(directory + "\\")));
                        }
                    }
                }
            }


            //if (checkNewNode == true && masternodecount > 0)
            //{

            //    for (int i = 1; i <= masternodecount; i++)
            //    {
            //        try
            //        {
            //            listBox1.Items.Add(config.AppSettings.Settings["masternode" + i].Value.ToString()); ;
            //        }
            //        catch
            //        { }
            //    }
            //}


            if (checkNewNode == true && oldmasternodecount > 0 && configvalue4 == "1")
            {
                foreach (string directory in directories)

                {
                    bool isDirectoryInMasternodeList = false;

                    for (int i = 1; i <= masternodecount; i++)
                    {
                        try
                        {
                            if (config.AppSettings.Settings["masternode" + i].Value.ToString() == Path.GetFileName(Path.GetDirectoryName(directory + "\\")))
                            {
                                isDirectoryInMasternodeList = true;
                            }
                        }
                        catch
                        {
                            UpdateSetting("masternodecount", "0");
                            MessageBox.Show("Fixed MasternodeCount, Application Will Restart Now");
                            Application.Restart();
                        }
                    }

                    if (isDirectoryInMasternodeList == false)
                    {
                        isConfigFound = true;
                        DialogResult dialogResult = MessageBox.Show("Do You Want To Import " + Path.GetFileName(Path.GetDirectoryName(directory + "\\")) + " ?", "Masternode Config Found For " + Path.GetFileName(Path.GetDirectoryName(directory + "\\")) + " At Working Directory", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                        {
                            AddMasternode(Path.GetFileName(Path.GetDirectoryName(directory + "\\")));
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                        else if (dialogResult == DialogResult.Cancel)
                        {
                            DialogResult dialogResult1 = MessageBox.Show("Do You Want To Disable Working Directory Check For Old Configs?", "Working Directory Check For Old Configs", MessageBoxButtons.YesNo);
                            if (dialogResult1 == DialogResult.Yes)
                            {
                                UpdateSetting("checkworkingdirectoryformasternodeconfigs", "0");
                                while (backgroundWorker3.IsBusy == true)
                                {
                                    Application.DoEvents();
                                }
                                try
                                {
                                    backgroundWorker3.RunWorkerAsync();
                                }
                                catch
                                { MessageBox.Show("Refreshing Masternode List Has Failed"); }
                                break;
                            }
                            else if (dialogResult1 == DialogResult.No)
                            {
                                UpdateSetting("checkworkingdirectoryformasternodeconfigs", "1");
                                while (backgroundWorker3.IsBusy == true)
                                {
                                    Application.DoEvents();
                                }
                                try
                                {
                                    backgroundWorker3.RunWorkerAsync();
                                }
                                catch
                                { MessageBox.Show("Refreshing Masternode List Has Failed"); }
                                break;
                            }
                        }



                        //AddMasternode(Path.GetFileName(Path.GetDirectoryName(directory + "\\")));
                        //listBox1.Items.Add(Path.GetFileName(Path.GetDirectoryName(directory + "\\")));
                    }
                }
            }

            if (isConfigFound == true && configvalue4 == "1")
            {
                DialogResult dialogResult2 = MessageBox.Show("Do You Want To Disable Working Directory Check For Old Configs?", "Working Directory Check For Old Configs", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    UpdateSetting("checkworkingdirectoryformasternodeconfigs", "0");

                }
                else if (dialogResult2 == DialogResult.No)
                {
                    UpdateSetting("checkworkingdirectoryformasternodeconfigs", "1");

                }
            }

            //try
            //{
            //    backgroundWorker3.RunWorkerAsync();
            //} catch { }

            while (backgroundWorker3.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker3.RunWorkerAsync();
            }
            catch
            { MessageBox.Show("Refreshing Masternode List Has Failed"); }
        }

    
      
        public class CustomSearcher
        {
            public static List<string> GetDirectories(string path, string searchPattern = "*",
                SearchOption searchOption = SearchOption.TopDirectoryOnly)
            {
                if (searchOption == SearchOption.TopDirectoryOnly)
                    return Directory.GetDirectories(path, searchPattern).ToList();

                var directories = new List<string>(GetDirectories(path, searchPattern));

                for (var i = 0; i < directories.Count; i++)
                    directories.AddRange(GetDirectories(directories[i], searchPattern));

                return directories;
            }

            private static List<string> GetDirectories(string path, string searchPattern)
            {
                try
                {
                    return Directory.GetDirectories(path, searchPattern).ToList();
                }
                catch (UnauthorizedAccessException)
                {
                    return new List<string>();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                folderBrowserDialog1.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox10.Text = folderBrowserDialog1.SelectedPath;
                    Environment.SpecialFolder root = folderBrowserDialog1.RootFolder;
                }
            }
            catch { }
        }

        public static class MasternodeHosterParameters
        {
            public static string workingdirectory { get; set; }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //this.Visible = false;
            AddMasternode addMasternode = new AddMasternode();

            
            backgroundWorker5.RunWorkerAsync();
            addMasternode.FormClosed += AddMasternode_FormClosed;
            addMasternode.Show();

        }
        private void AddMasternode_FormClosed(object sender, FormClosedEventArgs e)
        {
            while (backgroundWorker3.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker3.RunWorkerAsync();
            }
            catch
            { MessageBox.Show("Refreshing Masternode List Has Failed"); }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            UpdateSetting("workingdirectory", textBox10.Text);
            toolStripLabel1.Text = "Working Directory Changed To: " + textBox10.Text;
            checkWorkingDirectory();
        }
   
        private void button5_Click(object sender, EventArgs e)
        {
          
            try
            {
                IWshRuntimeLibrary.WshShell wsh = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(
                Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Masternode Hoster.lnk") as IWshRuntimeLibrary.IWshShortcut;
                shortcut.Arguments = "";
                shortcut.TargetPath = Environment.CurrentDirectory + @"\" + AppDomain.CurrentDomain.FriendlyName;
                shortcut.WindowStyle = 1;
                shortcut.Description = "Masternode Hoster";
                shortcut.WorkingDirectory = Environment.CurrentDirectory + @"\";
                shortcut.Save();
            }
            catch { }

            UpdateSetting("startonboot", "1");
            button5.Enabled = false;
            button7.Enabled = true;
            toolStripLabel1.Text = "Start On Boot: Enabled";




    

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Masternode Hoster.lnk");
                                             
            }
            catch { }

            UpdateSetting("startonboot", "0");
            button5.Enabled = true;
            button7.Enabled = false;
            toolStripLabel1.Text = "Start On Boot: Disabled";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateSetting("workingdirectory", textBox10.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();

            //MasternodeChecker(true);

    
            while (backgroundWorker4.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker4.RunWorkerAsync();
            }
            catch
            { MessageBox.Show("Refreshing Masternode List Has Failed"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem eachItem in olvMasternodes.SelectedItems)
            {
                RemoveMasternode(eachItem.Index + 1);
                olvMasternodes.Items.Remove(eachItem);
            }
            while (backgroundWorker3.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker3.RunWorkerAsync();
            }
            catch
            { MessageBox.Show("Refreshing Masternode List Has Failed"); }

        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
         
        }
        public class RootObject
        {
            public string txhash { get; set; }
            public int outputidx { get; set; }
            public bool IsBlockchainSynced { get; set; }
            public int lastMasternodeList { get; set; }
            public int lastMasternodeWinner { get; set; }
            public int lastBudgetItem { get; set; }
            public int lastFailure { get; set; }
            public int nCountFailures { get; set; }
            public int sumMasternodeList { get; set; }
            public int sumMasternodeWinner { get; set; }
            public int sumBudgetItemProp { get; set; }
            public int sumBudgetItemFin { get; set; }
            public int countMasternodeList { get; set; }
            public int countMasternodeWinner { get; set; }
            public int countBudgetItemProp { get; set; }
            public int countBudgetItemFin { get; set; }
            public int sumCommunityItemProp { get; set; }
            public int countCommunityItemProp { get; set; }
            public int RequestedMasternodeAssets { get; set; }
            public int RequestedMasternodeAttempt { get; set; }
        }
        private void List()
        {

            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            ConfigurationManager.RefreshSection("appSettings");


        }

        //Loading config, initializing. 
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string externalip1 = new WebClient().DownloadString("http://icanhazip.com");
            string replacement = Regex.Replace(externalip1, @"\t|\n|\r", "");
            externalip = replacement;
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            ConfigurationManager.RefreshSection("appSettings");

            string configvalue1 = config.AppSettings.Settings["workingdirectory"].Value;
            string configvalue2 = config.AppSettings.Settings["startonboot"].Value;
            string configvalue3 = config.AppSettings.Settings["masternodecount"].Value;
            string configvalue4 = config.AppSettings.Settings["checkworkingdirectoryformasternodeconfigs"].Value;
            // string configvalue4 = config.AppSettings.Settings["addedmasternodecount"].Value;

            if (configvalue2 == "1")
            {
                button5.Enabled = false;
                button7.Enabled = true;
            }
            if (configvalue2 == "0")
            {
                button5.Enabled = true;
                button7.Enabled = false;
            }
            if (configvalue4 == "0")
            {
                button5.Enabled = false;
                button7.Enabled = true;
            }
            textBox10.Text = configvalue1;
            if (configvalue1 != "")
            {
                firstRun = false;
                MasternodeChecker(true);
            }
            else
            {
                checkWorkingDirectory();
            }
        }


        //Masternode list, statuses + listview vs.
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                olvMasternodes.Items.Clear();
            }
            catch
            { }
            masternodes.Clear();
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            string configvalue3 = config.AppSettings.Settings["masternodecount"].Value;
            int masternodecount = Int32.Parse(configvalue3);

            try
            {
                for (int i = 1; i <= masternodecount; i++)
                {
                    Masternode.GetMasternodes(i, config.AppSettings.Settings["masternode" + i].Value.ToString(), "MasternodeHoster Has Started", "", 0 , masternodes);
                }
            }
            catch { }
            olvMasternodes.SetObjects(masternodes);
            while (backgroundWorker4.IsBusy == true )
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker4.RunWorkerAsync();
            }
            catch { MessageBox.Show("Cannot Get Masternode Status"); }
        }


        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        public void MasternodeEngineStarter(string masternodeName, string startingParameters)
        {
            string masternodeWalletLocation = Path.Combine(MasternodeHosterParameters.workingdirectory, masternodeName + "\\" + masternodeName + ".exe");
            var proc = Process.Start(masternodeWalletLocation, startingParameters);
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                foreach (var item in masternodes)
                {
                    bool isRunning = ProcessChecker(item.Title, MasternodeHosterParameters.workingdirectory);
                    if (isRunning == true)
                    {
                        if (item.Status == "Blockchain is not synced")
                        {
                            item.Status = "Masternode Server is Running, Blockchain is not synced yet.";

                        }
                        if (item.Status == "Blockchain is synced")
                        {
                            item.Status = "Masternode Server is Running and Blockchain is synced. You Can Start Masternode From Your Wallet.";

                        }
                        if (item.Status == "Masternode Hoster just Started")
                        {
                            item.Status = "Masternode Server is Running.";

                        }
                    }
                    else
                    {
                        item.Status = "Masternode Server is not Running";

                    }

                }

                this.titleColumn.ImageGetter = delegate (object rowObject) {
                    Masternode s = (Masternode)rowObject;
                    if (s.Status == "Masternode Server is not Running")
                        return "red";
                    if (s.Status == "Masternode Server is Running and Blockchain is synced. You Can Start Masternode From Your Wallet.")
                        return "green";
                    if (s.Status == "Masternode Server is Running, Blockchain is not synced yet.")
                        return "yellow";
                    if (s.Status == "Masternode Server is Running.")
                        return "yellow";
                    else
                        return "red";
                };

                olvMasternodes.SetObjects(masternodes);
            }
            catch { }

        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in olvMasternodes.SelectedItems)
            {
                MasternodeEngineStarter(masternodes[eachItem.Index].Title, ("-datadir=" + Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title) + " -conf=" + Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title) + "\\" + masternodes[eachItem.Index].Title + ".conf " + "-windowtitle=MasternodeHostClient -listen=1 -upnp=1"));
            }

        }

        private bool ProcessChecker(string masternodeName, string workingDirectory)
        {
            bool isRunning = Process.GetProcessesByName(masternodeName)
                .FirstOrDefault(p => p.MainModule.FileName.StartsWith(@workingDirectory)) != default(Process);
            if (isRunning == true)
            {
                return true;
               }
            else
            {
                return false;}
        }

       
     
        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                
                if (olvMasternodes.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem eachItem in olvMasternodes.SelectedItems)
                    {
                        bool isRunning = ProcessChecker(masternodes[eachItem.Index].Title, MasternodeHosterParameters.workingdirectory);
                        if (isRunning == true)
                        {
                            try
                            {
                                var data = File
                               .ReadAllLines(@MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol.conf")
                               .Select(x => x.Split('='))
                               .Where(x => x.Length > 1)
                               .ToDictionary(x => x[0].Trim(), x => x[1]);
                                string rpcuser = data["rpcuser"];
                                string rpcpass = data["rpcpassword"];
                                string rpcport = data["rpcport"];
                                BitnetClient bc = new BitnetClient("http://localhost:" + rpcport);
                                bc.Credentials = new NetworkCredential(rpcuser, rpcpass);

                                ////var p = bc.GetMasternodeStatus();

                                masternodes[eachItem.Index].Block = "Last Synced Block is: " + bc.GetBlockCount().ToString();
                            }
                            catch { MessageBox.Show("Cannot Run RPC Blockchain Test, check " + MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol.conf file"); }
                            try
                            {
                                Process cmd = new Process();
                                cmd.StartInfo.FileName = "cmd.exe";
                                cmd.StartInfo.RedirectStandardInput = true;
                                cmd.StartInfo.RedirectStandardOutput = true;
                                cmd.StartInfo.CreateNoWindow = true;
                                cmd.StartInfo.UseShellExecute = false;
                                cmd.Start();
                                cmd.StandardInput.WriteLine(MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol-cli -conf=" + MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol.conf mnsync status");
                                cmd.StandardInput.Flush();
                                cmd.StandardInput.Close();
                                cmd.WaitForExit();

                                //int a = 0;

                                var dictionary = new Dictionary<int, string>();
                                bool IsBlockchainSynced = false;
                                while (!cmd.StandardOutput.EndOfStream)
                                {
                                    string line = cmd.StandardOutput.ReadLine();
                                    if (line.Contains("IsBlockchainSynced") == true && line.Contains("true") == true)
                                    {
                                        IsBlockchainSynced = true;
                                        masternodes[eachItem.Index].Status = "Blockchain is synced";
                                        break;
                                    }
                                }
                                if (IsBlockchainSynced == false)
                                {
                                    masternodes[eachItem.Index].Status = ("Blockchain is not synced");
                                }
                                while (backgroundWorker4.IsBusy == true)
                                {
                                    Application.DoEvents();
                                }
                                try
                                {
                                    backgroundWorker4.RunWorkerAsync();
                                }
                                catch
                                { MessageBox.Show("Refreshing Masternode List Has Failed"); }
                            }
                            catch { MessageBox.Show("Cannot Run CMD Blockchain Check"); }
                        }
                        else
                        { masternodes[eachItem.Index].Status = "Masternode Server is not Running"; }
                    }
              
                }
                //else
                //{
                //    foreach (ListViewItem eachItem in olvMasternodes.Items)
                //    {
                //            bool isRunning = ProcessChecker(masternodes[eachItem.Index].Title, MasternodeHosterParameters.workingdirectory);
                //        if (isRunning == true)
                //        {

                //            try
                //            {

                //                var data = File
                //               .ReadAllLines(@MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol.conf")
                //               .Select(x => x.Split('='))
                //               .Where(x => x.Length > 1)
                //               .ToDictionary(x => x[0].Trim(), x => x[1]);
                //                string rpcuser = data["rpcuser"];
                //                string rpcpass = data["rpcpassword"];
                //                string rpcport = data["rpcport"];
                //                BitnetClient bc = new BitnetClient("http://localhost:" + rpcport);
                //                bc.Credentials = new NetworkCredential(rpcuser, rpcpass);

                //                ////var p = bc.GetMasternodeStatus();

                //                masternodes[eachItem.Index].Block = "Last Synced Block is: " + bc.GetBlockCount().ToString();
                //            }
                //            catch { MessageBox.Show("Cannot Run RPC Blockchain Test, check " + MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol.conf file"); }
                //            try
                //            {
                //                Process cmd = new Process();
                //                cmd.StartInfo.FileName = "cmd.exe";
                //                cmd.StartInfo.RedirectStandardInput = true;
                //                cmd.StartInfo.RedirectStandardOutput = true;
                //                cmd.StartInfo.CreateNoWindow = true;
                //                cmd.StartInfo.UseShellExecute = false;
                //                cmd.Start();
                //                cmd.StandardInput.WriteLine(MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol-cli -conf=" + MasternodeHosterParameters.workingdirectory + "\\" + masternodes[eachItem.Index].Title + "\\masternodecontrol.conf mnsync status");
                //                cmd.StandardInput.Flush();
                //                cmd.StandardInput.Close();
                //                cmd.WaitForExit();

                //                //int a = 0;

                //                var dictionary = new Dictionary<int, string>();
                //                bool IsBlockchainSynced = false;
                //                while (!cmd.StandardOutput.EndOfStream)
                //                {
                //                    string line = cmd.StandardOutput.ReadLine();
                //                    if (line.Contains("IsBlockchainSynced") == true && line.Contains("true") == true)
                //                    {
                //                        IsBlockchainSynced = true;
                //                        masternodes[eachItem.Index].Status = "Blockchain is synced";
                //                        break;
                //                    }
                //                }
                //                if (IsBlockchainSynced == false)
                //                {
                //                    masternodes[eachItem.Index].Status = ("Blockchain is not synced");
                //                }
                //                while (backgroundWorker4.IsBusy == true)
                //                {
                //                    Application.DoEvents();
                //                }
                //                try
                //                {
                //                    backgroundWorker4.RunWorkerAsync();
                //                }
                //                catch
                //                { MessageBox.Show("Refreshing Masternode List Has Failed"); }
                //            }
                //            catch { MessageBox.Show("Cannot Run CMD Blockchain Check"); }
                //        }
                //        else
                //        { masternodes[eachItem.Index].Status = "Masternode Server is not Running"; }
                //    }
                //}
            }
            catch { MessageBox.Show("Masternode Status Check Failed"); }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            while (backgroundWorker5.IsBusy == true)
            {
                Application.DoEvents();
            }
            try
            {
                backgroundWorker5.RunWorkerAsync();
            }
            catch { MessageBox.Show("Cannot Get Masternode Status"); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (olvMasternodes.SelectedItems.Count > 0)
            {

                foreach (ListViewItem eachItem in olvMasternodes.SelectedItems)
                {
                    try
                    {
                        masternodes[eachItem.Index].Hwnd = Int32.Parse(File.ReadAllText(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\Hwnd.txt")));
                    } catch { }
                        ShowWindow(masternodes[eachItem.Index].Hwnd, SW_SHOW);
                    masternodes[eachItem.Index].Hwnd = 0;
                }
            }
            else
            {
                foreach (ListViewItem eachItem in olvMasternodes.Items)
                {
                    try
                    {
                        masternodes[eachItem.Index].Hwnd = Int32.Parse(File.ReadAllText(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\Hwnd.txt")));
                    }
                    catch { }
                    ShowWindow(masternodes[eachItem.Index].Hwnd, SW_SHOW);
                    masternodes[eachItem.Index].Hwnd = 0;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (olvMasternodes.SelectedItems.Count > 0)
            {

                foreach (ListViewItem eachItem in olvMasternodes.SelectedItems)
                {
                    
                    Process[] processRunning = Process.GetProcesses();
                    foreach (Process pr in processRunning)
                    {
                     
                        if (pr.ProcessName == masternodes[eachItem.Index].Title && pr.MainModule.FileName.StartsWith(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\")))
                        {
                            masternodes[eachItem.Index].Hwnd = pr.MainWindowHandle.ToInt32();
                            ShowWindow(masternodes[eachItem.Index].Hwnd, SW_HIDE);
                            File.WriteAllText(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\Hwnd.txt"), String.Empty);
                            File.WriteAllText(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\Hwnd.txt"), masternodes[eachItem.Index].Hwnd.ToString());
                        }
                    }
                }
            }
            else
                {
                foreach (ListViewItem eachItem in olvMasternodes.Items)
                {
                    Process[] processRunning = Process.GetProcesses();
                    foreach (Process pr in processRunning)
                    {

                        if (pr.ProcessName == masternodes[eachItem.Index].Title && pr.MainModule.FileName.StartsWith(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\")))
                        {
                            masternodes[eachItem.Index].Hwnd = pr.MainWindowHandle.ToInt32();
                            ShowWindow(masternodes[eachItem.Index].Hwnd, SW_HIDE);
                            File.WriteAllText(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\Hwnd.txt"), String.Empty);
                            File.WriteAllText(@Path.Combine(MasternodeHosterParameters.workingdirectory, masternodes[eachItem.Index].Title + "\\Hwnd.txt"), masternodes[eachItem.Index].Hwnd.ToString());
                        }
                    }
                }
            }





   
        }

        private void olvMasternodes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (olvMasternodes.SelectedItems.Count > 0)
            {
                button10.Text = "Hide Selected Masternode Window";
                button9.Text = "Show Selected Masternode Window";
            }
            else
            {
                button10.Text = "Hide Masternode Windows";
                button9.Text = "Show Masternode Windows";
            }

            
            }
    }
}
