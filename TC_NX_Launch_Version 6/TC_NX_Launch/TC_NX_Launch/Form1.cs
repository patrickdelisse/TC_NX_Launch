using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Net.Mail;
using KMWE_Sec;


[assembly: AssemblyVersionAttribute("6.0.1")]

/// <summary>
/// Program reads a XML file and filles two listboxes with NX version and CustomGroup
/// If settings in registry are availible, then these values are highlighted in the listboxes if they occur there
/// When user made a selection and chooses Save, the selected values are stored in the registry
/// The startup script for NX in teamcenter environment pickes these values from the registry
/// </summary>
namespace TC_NX_Launch
{
    public partial class Form1 : Form
    {
        #region Define and Set Variables

        const string XML_File = "TC_NX_Launch_settings.xml";
        const string Help_File = "TC_NX_Launch.pdf";
        const string _defaultinstallationfolder = "c:\\program files\\Siemens\\";
        public string NX_desktop_shortcut = null;
        public string NX_AppName = null;
        public string NX_App = "";
        public string NX_GroupName = null;
        public string TC_Server = null;
        public string TC_Env = null;
        public string TC_BatFile = null;
        public string TC_para_portal = null;
        public string TC_para_manager = null;
        public string TC_FIXED_NXVer = null; //Fixed NX version for Teamcenter Produktion Database
        public string _defver = null;
        public string _defgroup = null;
        public string _defhidden = "no";
        public string _defapp = "TC";
        public string Editor = null;
        public string _u = null;
        public string _p = null;
        public int ListAppSelected = 0;
        public int ListGroupSelected = 0;
        public bool NX_availible = false;
        public bool TC_FIXED_NX = false; //Fixed NX version for Teamcenter Produktion Database
        public bool Splash = false;
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "Software\\KMWE\\NX_Select\\Defaults";
        const string keyName = userRoot + "\\" + subkey;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CancelButton = Cancel;
            logo.Image = global::TC_NX_Launch.Properties.Resources.logo;

            RegistryRead();
            ArangeWindow_Normal();
            SelectionHide();
            ReadSettings();

            UpdateTitle();

            if (!(File.Exists(TC_Server + "\\" + TC_BatFile))) //If batfile does not exist
            {
                MessageBox.Show("Cannot find the startup script.\n\n" + TC_Server + "\\" + TC_BatFile + "\n\nCheck network connections.", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Afsluiten();
            }

            if (NX_availible == false || _defhidden == "yes" )
            {
                // NX is not installed, so don't bother the user with the interface
                // or
                // NX is installed but user choose to hide the interface
                // Arange Form1 to a Splash screen
                ArangeWindow_Minimizedl();
                timer1.Enabled = true;
                //timer1 launches teamcenter
            }
            else
            {
                // NX is installed, let the user choose, but give launch teamcenter the focus
                LAUNCH_TC_MouseEnter("Form1Load", null);
                if (_defapp == "NX") { LAUNCH_NX_MouseEnter("Form1Load", null); }
                if (_defapp == "TC") { LAUNCH_TC_MouseEnter("Form1Load", null); }
                // Check if needed and copy native NX shortcut to desktop
                NX_desktop_shortcut = "KMWE - Native NX (" + TC_Server.Replace("\\\\TC-","") +  ").lnk";
                string source_shrtct = Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\" + NX_desktop_shortcut;
                string destin_shrtct = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\" + NX_desktop_shortcut;
                if (!(File.Exists(destin_shrtct)))
                {
                    try
                    {
                        File.Copy(source_shrtct, destin_shrtct, true);
                    }
                    catch { }
                }
            }
        }

        // Closing Application
        private void Afsluiten()
        {
            Cancel_Click("Afsluiten", null);
        }

        /// <summary>
        /// Arange the window as the regular interface
        /// </summary>
        private void ArangeWindow_Normal()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            panelselect.Location = paneloverview.Location;
            SettingsPanel.Location = new Point(15, 180);
            LBL_Fixed_NX.Location = new Point(8, 95);
            Foldup.Location = Folddown.Location;
            this.Height = paneloverview.Top + paneloverview.Height + 75;
            
            Splash = false;

            // Get the version of the current assembly.
            Assembly assem = typeof(Form1).Assembly;
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;

            LBL_AppVersion.Text = assemName.Name + " - version: " + ver.ToString();
        }

        /// <summary>
        /// Arange the window as the regular interface
        /// </summary>
        private void ArangeWindow_Minimizedl()
        {
            // NX is not installed, so don't bother the user with the interface
            //Arange Form1 to a Splash screen
            this.Height = panel1.Height + 45;
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Enabled = true;
            SettingsPanel.Location = new Point(15, 17);
            Splash = true;
        }

        /// <summary>
        /// Open Credentials window and let user specify Username/Password for quick launch
        /// </summary>
        private void Button_Credits_Click(object sender, EventArgs e)
        {
            using(Credentials form = new Credentials())
            {
                if (!(_u== "_##_clearfromregistry_@@_##_$$"))
                {
                    form.Un = _u;
                    form.Pw = _p;
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _u = form.Un;
                    _p = form.Pw;

                    if (!(_u == null) && !(_u == ""))
                    {
                        UpdateTitle();
                    }
                    else
                    {
                        _u = "_##_clearfromregistry_@@_##_$$";
                        UpdateTitle();
                    }
                }
            }
        }

        // Button Cancel
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Check if selected version folder exists or if a version wasn't selected
        /// </summary>
        private void Check_Groups()
        {
            if (Directory.Exists(TC_Server + "\\PLMShare\\PLM_Startup\\NX" + NX_App + "config\\" + NX_GroupName) || (!(LbL_NX_environment.Text == "-") && !(Lbl_NX_versie.Text=="-")))
            {
                // Folder exists and version was selected
                LAUNCH_TC.Visible = true;
                LAUNCH_NX.Visible = true;
                LAUNCH_NX.Enabled = true;
                LAUNCH_NX.Image = global::TC_NX_Launch.Properties.Resources.NX_Icon;
                LBL_Fixed_NX.Visible = false;
                if (TC_FIXED_NX)
                {
                    if (!(NX_App==TC_FIXED_NXVer))
                    {
                        LAUNCH_TC.Visible = false;
                        LAUNCH_NX.Enabled = false;
                        LAUNCH_NX.Image = global::TC_NX_Launch.Properties.Resources.NX_Icon_dim;
                        LBL_Fixed_NX.Visible = true;
                        LBL_Fixed_NX.Text = "Only NX" + TC_FIXED_NXVer.Replace("0",".0") + " allowed";
                    }
                }
                // LAUNCH_NX.Visible = true;
                LBL_AppVersion.Visible = true;
                LBL_grouperror.Visible = false;
            }
            else
            {
                // Folder doesn't exists or version wasn't selected
                LAUNCH_TC.Visible = false;
                LAUNCH_NX.Visible = false;
                LBL_AppVersion.Visible = false;
                LBL_grouperror.Visible = true;
            }
        }

        /// <summary>
        /// If no NX version was selected or read from the registry, disable the launch button
        /// </summary>
        private void Check_NX()
        {
            if (ListAppSelected == 0) 
            {
                LAUNCH_NX.Enabled = false;
                LAUNCH_NX.Image = global::TC_NX_Launch.Properties.Resources.NX_Icon_dim;
            }
            else
            {
                LAUNCH_NX.Enabled = true;
                LAUNCH_NX.Image = global::TC_NX_Launch.Properties.Resources.NX_Icon;
            }
            Check_Groups();
        }

        /// <summary>
        /// Check if specified process is running
        /// </summary>
        /// <param name="process"></param>
        /// <returns> true or false </returns>
        private bool CheckIfRunning(string process)
        {
            if (process == "UGRAF") { return false; } //NX can be run as router takes care of this
            Process[] collectionOfProcess = Process.GetProcessesByName(process);
            if (collectionOfProcess.Length >= 1)
            {
                Process PLM = collectionOfProcess[0];
                return true;
            }
            return false;
        }

        /// <summary>
        /// Opens documentation
        /// </summary>
        private void Doku_Click(object sender, EventArgs e)
        {
            Help_Click(doku, null);
            Settingspanel_Click(doku, null);
        }

        /// <summary>
        /// Execute specified process
        /// </summary>
        private void ExecuteIt(string arg, string process, string name)
        {
            if (CheckIfRunning(process) == true)
            {
                MessageBox.Show(process + " is already running", "Already active", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!(_u == null) && !(_u == "") && !(_u == "_##_clearfromregistry_@@_##_$$"))
                {
                    arg = arg + " " + _u + " " + _p; //Add the user credentials as arguments
                }
                Process compiler = new Process();
                compiler.StartInfo.FileName = TC_Server + "\\" + TC_BatFile;
                compiler.StartInfo.Arguments = arg;
                compiler.StartInfo.UseShellExecute = false;
                compiler.StartInfo.RedirectStandardOutput = false;
                compiler.Start();
                compiler.WaitForExit();
            }
        }

        /// <summary>
        /// Button folddown
        /// </summary>
        private void Folddown_Click(object sender, EventArgs e)
        {
            SelectionShow(); // Show NX App and Group selection window
        }

        /// <summary>
        /// Button foldup
        /// </summary>
        private void Foldup_Click(object sender, EventArgs e)
        {
            SelectionHide(); // Hide NX App and Group selection window
        }

        /// <summary>
        /// Open the Help file (PDF)
        /// </summary>
        private void Help_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Help_File);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\n" + Help_File, "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sends an email to the Teamcenter helpdesk
        /// </summary>
         private void LinkMail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:" + "teamcenter@kmwe.com" + "?CC=" + "maarten@cardsplmsolutions.com" + "&BODY=" + "Omschrijving:");
            Settingspanel_Click(linkMail, null);
        }

        /// <summary>
        /// When selection is made in App list
        /// </summary>
        private void ListApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAppSelected = ListApp.SelectedIndex + 1;
            NX_AppName = ListApp.SelectedItem.ToString();
            NX_App = NX_AppName.Replace(".", "").Replace(" ", "").Replace("NX", "").Trim();
            Lbl_NX_versie.Text = NX_AppName;
            Check_Groups();
            SelectionHide();
        }

        /// <summary>
        /// When selection is made in Group list
        /// </summary>
        private void ListGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListGroupSelected = ListGroup.SelectedIndex + 1;
            NX_GroupName = ListGroup.SelectedItem.ToString();
            LbL_NX_environment.Text = NX_GroupName;
            //if (NX_GroupName == "DutchAero")
            //{
            //    logo.Image = global::TC_NX_Launch.Properties.Resources.dutchaero_transparent;
            //}
            //else
            //{
            //    logo.Image = global::TC_NX_Launch.Properties.Resources.logo;
            //}
            Check_Groups();
            SelectionHide();
        }

        // Set Focus to and highlight Teamcenter Launch
        private void LAUNCH_TC_MouseEnter(object sender, EventArgs e)
        {
            LAUNCH_TC.FlatAppearance.BorderSize = 1;
            LAUNCH_TC.BackColor = Color.FromArgb(30, 30, 30);
            LAUNCH_NX.FlatAppearance.BorderSize = 0;
            LAUNCH_NX.BackColor = Color.Transparent;
            LAUNCH_TC.Focus();
            LAUNCH_TC.Select();
        }

        // Set Focus to and highlight NX Launch
        private void LAUNCH_NX_MouseEnter(object sender, EventArgs e)
        {
            LAUNCH_NX.FlatAppearance.BorderSize = 1;
            LAUNCH_NX.BackColor = Color.FromArgb(30, 30, 30);
            LAUNCH_TC.FlatAppearance.BorderSize = 0;
            LAUNCH_TC.BackColor = Color.Transparent;
            LAUNCH_NX.Focus();
            LAUNCH_NX.Select();
        }

        /// <summary>
        /// Save Settings, Launch NX and close
        /// </summary>
        private void LAUNCH_NX_Click(object sender, EventArgs e)
        {
            RegistrySave();
            ExecuteIt(TC_para_manager, "UGRAF", "NX Manager");

            Afsluiten();
        }

        /// <summary>
        /// Save Settings, Launch Teamcenter and close
        /// </summary>
        private void LAUNCH_TC_Click(object sender, EventArgs e)
        {
            RegistrySave();
            ExecuteIt(TC_para_portal, "Teamcenter", "Teamcenter");

            Afsluiten();
        }

        /// <summary>
        /// Show or hide settings
        /// </summary>
        private void NXbar_Click(object sender, EventArgs e)
        {
            if (Folddown.Visible)
            {
                Folddown_Click("NXBar", null);
            }
            else
            {
                Foldup_Click("NXBar", null);
            }
        }

        /// <summary>
        /// Read in all settings from XML file and build selection lists
        /// </summary>
        private void ReadSettings()
        {
            int indx = 0;
            string Regel = null;
            string NX_Install = null;
            ListApp.Items.Clear();
            ListGroup.Items.Clear();

            try
            {
                using (StreamReader FStream = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + XML_File))
                {
                    while (FStream.Peek() >= 0)
                    {
                        Regel = FStream.ReadLine();
                        if (!(Regel.IndexOf("<NX_AppName>") == -1)) //NX application, add to list, if installed
                        {
                            NX_AppName = Regel.Replace("<NX_AppName>", "").Replace("</NX_AppName>", "").Trim();
                            NX_Install = _defaultinstallationfolder + NX_AppName;
                            NX_App = NX_AppName.Replace(".", "").Replace(" ", "").Replace("NX", "").Trim();
                            
                            if (Directory.Exists(NX_Install))
                            {
                                ListApp.Items.Add(NX_AppName);
                                NX_availible = true;
                                indx = ListApp.Items.Count - 1;
                                if (_defver == NX_App)
                                {
                                    ListAppSelected = indx + 1;
                                }
                            }
                        }
                        if (!(Regel.IndexOf("<GroupName>") == -1)) //NX customer group
                        {
                            NX_GroupName = Regel.Replace("<GroupName>", "").Replace("</GroupName>", "").Trim();
                            ListGroup.Items.Add(NX_GroupName);
                            indx = ListGroup.Items.Count - 1;
                            if (_defgroup == NX_GroupName)
                            {
                                ListGroupSelected = indx + 1;
                            }
                        }
                        if (!(Regel.IndexOf("<TC_ver>") == -1)) //Teamcenter version
                        {
                            Lbl_TC_versie.Text = Regel.Replace("<TC_ver>", "").Replace("</TC_ver>", "").Trim();
                        }
                        if (!(Regel.IndexOf("<TC_server>") == -1)) //Teamcenter server
                        {
                            TC_Server = Regel.Replace("<TC_server>", "").Replace("</TC_server>", "").Trim();
                            LBL_TC_Server.Text = TC_Server.Replace("\\", "");
                        }
                        if (!(Regel.IndexOf("<TC_Env>") == -1)) //Teamcenter Environment string
                        {
                            TC_Env = Regel.Replace("<TC_Env>", "").Replace("</TC_Env>", "").Trim();
                        }
                        if (!(Regel.IndexOf("<TC_bat>") == -1)) //Teamcenter startup batch-file
                        {
                            TC_BatFile = Regel.Replace("<TC_bat>", "").Replace("</TC_bat>", "").Trim();
                        }
                        if (!(Regel.IndexOf("<TC_portal>") == -1)) //Startup argument for batch-file
                        {
                            TC_para_portal = Regel.Replace("<TC_portal>", "").Replace("</TC_portal>", "").Trim();
                        }
                        if (!(Regel.IndexOf("<TC_NXman>") == -1)) //Startup argument for batch-file
                        {
                            TC_para_manager = Regel.Replace("<TC_NXman>", "").Replace("</TC_NXman>", "").Trim();
                        }
                        if (!(Regel.IndexOf("<TC_FixedNX>") == -1)) //Startup argument for batch-file
                        {
                            if (Regel.Replace("<TC_FixedNX>", "").Replace("</TC_FixedNX>", "").Trim() == "yes")
                            {
                                TC_FIXED_NX = true;
                            }
                        }
                        if (!(Regel.IndexOf("<TC_FixedNXver>") == -1)) //Startup argument for batch-file
                        {
                            TC_FIXED_NXVer = Regel.Replace("<TC_FixedNXver>", "").Replace("</TC_FixedNXver>", "").Trim();
                            if (TC_FIXED_NXVer.Length==2) { TC_FIXED_NXVer = TC_FIXED_NXVer + "0"; }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Afsluiten();
            }

            if (!(ListAppSelected == 0)) //If a default version -last saved- was found, highlight it
            {
                ListApp.SetSelected(ListAppSelected - 1, true);
            }
            if (!(ListGroupSelected == 0)) //If a default group -last saved- was found, highlight it
            {
                ListGroup.SetSelected(ListGroupSelected - 1, true);
            }
            Check_NX();
        }

        /// <summary>
        /// Settings from registry 'Computer\HKEY_CURRENT_USER\Software\KMWE\NX_Select\Defaults'
        /// </summary>
        public void RegistryRead()
        {
            try
            {
                _defver = (string)Registry.GetValue(keyName, "NXversion", "");
                _defgroup = (string)Registry.GetValue(keyName, "CustomGroup", "");
                _defhidden = (string)Registry.GetValue(keyName, "HiddenInterface", "");
                _defapp = (string)Registry.GetValue(keyName, "FocusApp", "");
                _u = ((string)Registry.GetValue(keyName, "User", ""));
                _p = (string)Registry.GetValue(keyName, "Pwd", "");
                if (_defapp == "TC") { Check_FocusTC.Checked = true; Check_FocusNX.Checked = false; }
                if (_defapp == "NX") { Check_FocusNX.Checked = true; Check_FocusTC.Checked = false; }
                if (_defhidden=="yes") { Check_HideInterFace.Checked = true; }
                UpdateTitle();
                if (!(_p == null) && !(_p == "")) {
                    _p = KMWE_Security.Decrypt(_p, "Pwd");
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Save NX App and Group to registry 'Computer\HKEY_CURRENT_USER\Software\KMWE\NX_Select\Defaults'
        /// </summary>
        private void RegistrySave()
        {
            if (!(ListAppSelected == 0)) //Only save if an NX version is selected
            {
                if (NX_GroupName == "-")
                {
                    NX_GroupName = "-none-";
                }
                try
                {
                    Registry.SetValue(keyName, "NXversion", NX_App);
                    Registry.SetValue(keyName, "CustomGroup", NX_GroupName);
                }
                catch {}
            }
            try
            {
                if (Check_HideInterFace.Checked)
                {
                    Registry.SetValue(keyName, "HiddenInterface", "yes");
                }
                else
                {
                    Registry.SetValue(keyName, "HiddenInterface", "no");
                }
                if (Check_FocusNX.Checked)
                {
                    Registry.SetValue(keyName, "FocusApp", "NX");
                }
                if (Check_FocusTC.Checked)
                {
                    Registry.SetValue(keyName, "FocusApp", "TC");
                }

                if (!(_u == null) && !(_p == null))
                {
                    if (_u == "_##_clearfromregistry_@@_##_$$")
                    {
                        Registry.SetValue(keyName, "User", "");
                        Registry.SetValue(keyName, "Pwd", "");
                    }
                    else
                    {
                        string cryptedPwd = KMWE_Security.Encrypt(_p, "Pwd");
                        Registry.SetValue(keyName, "User", _u);
                        Registry.SetValue(keyName, "Pwd", cryptedPwd);
                    }
                }
            }
            catch {}
        }

        /// <summary>
        /// Hide the NX app and custopmgroup selection window
        /// </summary>
        private void SelectionHide()
        {
            panelselect.Visible = false;
            paneloverview.Visible = true;
            paneltc.Visible = true;
            Foldup.Visible = false;
            Folddown.Visible = true;
            label4.Visible = true;
            Check_NX();
        }

        /// <summary>
        /// Hide the NX app and custopmgroup selection window
        /// </summary>
        private void SelectionShow()
        {
            panelselect.Visible = true;
            paneloverview.Visible = false;
            paneltc.Visible = false;
            Foldup.Visible = true;
            Folddown.Visible = false;
            label4.Visible = false;
        }

        /// <summary>
        /// Display the setting panel
        /// </summary>
        private void SettingsEdit_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            panelselect.Visible = false;
            ShowHide_others(false);
            this.ControlBox = false;
            if (Splash)
            {
                this.Height = panel1.Height + 40;
            }
            if (!(NX_availible))
            {
                Check_FocusNX.Enabled = false;
                Check_FocusTC.Enabled = false;
                Check_HideInterFace.Enabled = false;
            }
        }

        /// <summary>
        /// Opens the settingfile in a text editor
        /// </summary>
        private void SettingsOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be carefull when editing settings. This will have impact on every teamcenter user", "Be carefull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            string Editor = null;
            string editor = "c:\\windows\\notepad.exe";
            if (File.Exists(editor))
            {
                Editor = editor;
            }
            editor = "C:\\Program Files (x86)\\Notepad++\\notepad++.exe";
            if (File.Exists(editor))
            {
                Editor = editor;
            }
            editor = "C:\\Program Files\\Notepad++\\notepad++.exe";
            if (File.Exists(editor))
            {
                Editor = editor;
            }

            if (!(Editor == null))
            {
                Process myProcess = new Process();
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(Editor, Path.GetDirectoryName(Application.ExecutablePath) + "\\" + XML_File)
                {
                    UseShellExecute = false,
                    RedirectStandardError = true
                };
                myProcess.StartInfo = myProcessStartInfo;
                myProcess.Start();
                string error = myProcess.StandardError.ReadToEnd();
                myProcess.WaitForExit();

                ReadSettings();
            }
            Settingspanel_Click(SettingsOpen, null);
        }

        /// <summary>
        /// /// Close the setting panel
        /// </summary>
        private void Settingspanel_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            
            if (Splash)
            {
                this.Height = panel1.Height + 15;
                timer1.Interval = 500;
                timer1.Start();
            }
            else
            {
                ShowHide_others(true);
                this.ControlBox = true;
            }
        }

        /// <summary>
        /// Show of Hide most controls
        /// </summary>
        /// <param name="state"></param>
        private void ShowHide_others(bool state)
        {
            panel2.Visible = state;
            paneloverview.Visible = state;
            paneltc.Visible = state;
            NXbar.Visible = state;
            label3.Visible = state;
            label4.Visible = state;
            pictureBox5.Visible = state;
            Foldup.Visible = state;
            Folddown.Visible = state;
        }


        /// <summary>
        /// Time will only become active if NX installation was not found, so user only will run Teamcenter
        /// The form will be set to a splash screen
        /// </summary>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            LAUNCH_TC_Click(timer1, null);
        }

        /// <summary>
        /// What to do when user clicks in the title area
        /// </summary>
        private void TitleClick(object sender, EventArgs e)
        {
            if (NX_availible)
            { // If NX is avialible
                if (Splash)
                { // and window is in splash state
                    timer1.Stop();
                    ArangeWindow_Normal();
                    if (_defapp == "NX") { LAUNCH_NX_MouseEnter("TitelClick", null); }
                    if (_defapp == "TC") { LAUNCH_TC_MouseEnter("TitelClick", null); }
                }
            }
            else
            {
                timer1.Stop();
                SettingsEdit_Click("TitelClick", null);
            }
        }

        /// <summary>
        /// Update the Title bar
        /// </summary>
        private void UpdateTitle()
        {
            if (!(_u == null) && !(_u == "") && !(_u == "_##_clearfromregistry_@@_##_$$"))
            {
                this.Text = "KMWE Teamcenter / " + _u + "   -   ### " + TC_Env + " ###";
            }
            else
            {
                this.Text = "KMWE Teamcenter" + "   -   ### " + TC_Env + " ###";
            }
        }
    }
}
