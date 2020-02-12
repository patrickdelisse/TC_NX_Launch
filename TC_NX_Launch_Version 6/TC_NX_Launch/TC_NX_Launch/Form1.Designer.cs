namespace TC_NX_Launch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelEnv = new System.Windows.Forms.Label();
            this.ListGroup = new System.Windows.Forms.ListBox();
            this.ListApp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelselect = new System.Windows.Forms.Panel();
            this.Nxlaunch_label = new System.Windows.Forms.LinkLabel();
            this.Nx_icon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paneloverview = new System.Windows.Forms.Panel();
            this.LAUNCH_NX = new System.Windows.Forms.Button();
            this.LbL_NX_environment = new System.Windows.Forms.Label();
            this.Lbl_NX_versie = new System.Windows.Forms.Label();
            this.labelVerise = new System.Windows.Forms.Label();
            this.label_nxenv = new System.Windows.Forms.Label();
            this.Foldup = new System.Windows.Forms.PictureBox();
            this.paneltc = new System.Windows.Forms.Panel();
            this.LBL_Fixed_NX = new System.Windows.Forms.Label();
            this.LAUNCH_TC = new System.Windows.Forms.Button();
            this.LBL_TC_Server = new System.Windows.Forms.Label();
            this.Lbl_tcserver = new System.Windows.Forms.Label();
            this.Lbl_TC_versie = new System.Windows.Forms.Label();
            this.label_tc_ver = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_AppVersion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_grouperror = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SettingsEdit = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Folddown = new System.Windows.Forms.PictureBox();
            this.NXbar = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.Button_Credits = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Check_HideInterFace = new System.Windows.Forms.CheckBox();
            this.Check_FocusTC = new System.Windows.Forms.RadioButton();
            this.Check_FocusNX = new System.Windows.Forms.RadioButton();
            this.doku = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkMail = new System.Windows.Forms.LinkLabel();
            this.SettingsOpen = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelselect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nx_icon)).BeginInit();
            this.paneloverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foldup)).BeginInit();
            this.paneltc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Folddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NXbar)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelEnv
            // 
            this.LabelEnv.AutoSize = true;
            this.LabelEnv.BackColor = System.Drawing.Color.Transparent;
            this.LabelEnv.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEnv.ForeColor = System.Drawing.Color.Yellow;
            this.LabelEnv.Location = new System.Drawing.Point(170, 12);
            this.LabelEnv.Name = "LabelEnv";
            this.LabelEnv.Size = new System.Drawing.Size(94, 19);
            this.LabelEnv.TabIndex = 62;
            this.LabelEnv.Text = "Environment";
            // 
            // ListGroup
            // 
            this.ListGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListGroup.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListGroup.ForeColor = System.Drawing.Color.Green;
            this.ListGroup.FormattingEnabled = true;
            this.ListGroup.ItemHeight = 19;
            this.ListGroup.Location = new System.Drawing.Point(174, 34);
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.Size = new System.Drawing.Size(225, 99);
            this.ListGroup.TabIndex = 61;
            this.toolTip1.SetToolTip(this.ListGroup, "Predefined environments for NX");
            this.ListGroup.SelectedIndexChanged += new System.EventHandler(this.ListGroup_SelectedIndexChanged);
            // 
            // ListApp
            // 
            this.ListApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListApp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListApp.FormattingEnabled = true;
            this.ListApp.ItemHeight = 19;
            this.ListApp.Location = new System.Drawing.Point(24, 34);
            this.ListApp.Name = "ListApp";
            this.ListApp.Size = new System.Drawing.Size(115, 99);
            this.ListApp.TabIndex = 60;
            this.toolTip1.SetToolTip(this.ListApp, "Installed versions of NX");
            this.ListApp.SelectedIndexChanged += new System.EventHandler(this.ListApp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "NX Version";
            // 
            // panelselect
            // 
            this.panelselect.BackColor = System.Drawing.Color.Maroon;
            this.panelselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelselect.Controls.Add(this.label1);
            this.panelselect.Controls.Add(this.LabelEnv);
            this.panelselect.Controls.Add(this.ListGroup);
            this.panelselect.Controls.Add(this.ListApp);
            this.panelselect.Location = new System.Drawing.Point(15, 373);
            this.panelselect.Name = "panelselect";
            this.panelselect.Size = new System.Drawing.Size(429, 146);
            this.panelselect.TabIndex = 66;
            this.toolTip1.SetToolTip(this.panelselect, "Close selection panel");
            // 
            // Nxlaunch_label
            // 
            this.Nxlaunch_label.Location = new System.Drawing.Point(0, 0);
            this.Nxlaunch_label.Name = "Nxlaunch_label";
            this.Nxlaunch_label.Size = new System.Drawing.Size(100, 23);
            this.Nxlaunch_label.TabIndex = 0;
            // 
            // Nx_icon
            // 
            this.Nx_icon.Location = new System.Drawing.Point(0, 0);
            this.Nx_icon.Name = "Nx_icon";
            this.Nx_icon.Size = new System.Drawing.Size(100, 50);
            this.Nx_icon.TabIndex = 0;
            this.Nx_icon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(115, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 45);
            this.label2.TabIndex = 87;
            this.label2.Text = "TEAMCENTER";
            this.label2.Click += new System.EventHandler(this.TitleClick);
            // 
            // paneloverview
            // 
            this.paneloverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneloverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneloverview.Controls.Add(this.LAUNCH_NX);
            this.paneloverview.Controls.Add(this.LbL_NX_environment);
            this.paneloverview.Controls.Add(this.Lbl_NX_versie);
            this.paneloverview.Controls.Add(this.labelVerise);
            this.paneloverview.Controls.Add(this.label_nxenv);
            this.paneloverview.Location = new System.Drawing.Point(15, 180);
            this.paneloverview.Name = "paneloverview";
            this.paneloverview.Size = new System.Drawing.Size(210, 146);
            this.paneloverview.TabIndex = 88;
            // 
            // LAUNCH_NX
            // 
            this.LAUNCH_NX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LAUNCH_NX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LAUNCH_NX.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.LAUNCH_NX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.LAUNCH_NX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LAUNCH_NX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAUNCH_NX.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAUNCH_NX.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LAUNCH_NX.Image = global::TC_NX_Launch.Properties.Resources.NX_Icon;
            this.LAUNCH_NX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LAUNCH_NX.Location = new System.Drawing.Point(9, 74);
            this.LAUNCH_NX.Name = "LAUNCH_NX";
            this.LAUNCH_NX.Size = new System.Drawing.Size(190, 61);
            this.LAUNCH_NX.TabIndex = 2;
            this.LAUNCH_NX.Text = "NX Manager";
            this.LAUNCH_NX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LAUNCH_NX.UseVisualStyleBackColor = false;
            this.LAUNCH_NX.Click += new System.EventHandler(this.LAUNCH_NX_Click);
            this.LAUNCH_NX.MouseEnter += new System.EventHandler(this.LAUNCH_NX_MouseEnter);
            // 
            // LbL_NX_environment
            // 
            this.LbL_NX_environment.AutoSize = true;
            this.LbL_NX_environment.BackColor = System.Drawing.Color.Transparent;
            this.LbL_NX_environment.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_NX_environment.ForeColor = System.Drawing.Color.Lime;
            this.LbL_NX_environment.Location = new System.Drawing.Point(106, 48);
            this.LbL_NX_environment.Name = "LbL_NX_environment";
            this.LbL_NX_environment.Size = new System.Drawing.Size(14, 19);
            this.LbL_NX_environment.TabIndex = 85;
            this.LbL_NX_environment.Text = "-";
            // 
            // Lbl_NX_versie
            // 
            this.Lbl_NX_versie.AutoSize = true;
            this.Lbl_NX_versie.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NX_versie.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NX_versie.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_NX_versie.Location = new System.Drawing.Point(106, 18);
            this.Lbl_NX_versie.Name = "Lbl_NX_versie";
            this.Lbl_NX_versie.Size = new System.Drawing.Size(14, 19);
            this.Lbl_NX_versie.TabIndex = 84;
            this.Lbl_NX_versie.Text = "-";
            // 
            // labelVerise
            // 
            this.labelVerise.AutoSize = true;
            this.labelVerise.BackColor = System.Drawing.Color.Transparent;
            this.labelVerise.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerise.ForeColor = System.Drawing.Color.Yellow;
            this.labelVerise.Location = new System.Drawing.Point(7, 18);
            this.labelVerise.Name = "labelVerise";
            this.labelVerise.Size = new System.Drawing.Size(81, 19);
            this.labelVerise.TabIndex = 65;
            this.labelVerise.Text = "NX Version";
            // 
            // label_nxenv
            // 
            this.label_nxenv.AutoSize = true;
            this.label_nxenv.BackColor = System.Drawing.Color.Transparent;
            this.label_nxenv.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nxenv.ForeColor = System.Drawing.Color.Yellow;
            this.label_nxenv.Location = new System.Drawing.Point(7, 48);
            this.label_nxenv.Name = "label_nxenv";
            this.label_nxenv.Size = new System.Drawing.Size(94, 19);
            this.label_nxenv.TabIndex = 62;
            this.label_nxenv.Text = "Environment";
            // 
            // Foldup
            // 
            this.Foldup.BackColor = System.Drawing.Color.White;
            this.Foldup.Image = global::TC_NX_Launch.Properties.Resources.border_up;
            this.Foldup.Location = new System.Drawing.Point(203, 132);
            this.Foldup.Name = "Foldup";
            this.Foldup.Size = new System.Drawing.Size(22, 22);
            this.Foldup.TabIndex = 90;
            this.Foldup.TabStop = false;
            this.toolTip1.SetToolTip(this.Foldup, "Close selection window");
            this.Foldup.Visible = false;
            this.Foldup.Click += new System.EventHandler(this.Foldup_Click);
            // 
            // paneltc
            // 
            this.paneltc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneltc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltc.Controls.Add(this.LBL_Fixed_NX);
            this.paneltc.Controls.Add(this.LAUNCH_TC);
            this.paneltc.Controls.Add(this.LBL_TC_Server);
            this.paneltc.Controls.Add(this.Lbl_tcserver);
            this.paneltc.Controls.Add(this.Lbl_TC_versie);
            this.paneltc.Controls.Add(this.label_tc_ver);
            this.paneltc.Location = new System.Drawing.Point(234, 180);
            this.paneltc.Name = "paneltc";
            this.paneltc.Size = new System.Drawing.Size(210, 146);
            this.paneltc.TabIndex = 93;
            // 
            // LBL_Fixed_NX
            // 
            this.LBL_Fixed_NX.AutoSize = true;
            this.LBL_Fixed_NX.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Fixed_NX.ForeColor = System.Drawing.Color.Red;
            this.LBL_Fixed_NX.Location = new System.Drawing.Point(69, 4);
            this.LBL_Fixed_NX.Name = "LBL_Fixed_NX";
            this.LBL_Fixed_NX.Size = new System.Drawing.Size(136, 26);
            this.LBL_Fixed_NX.TabIndex = 4;
            this.LBL_Fixed_NX.Text = "Fixed NX in TC";
            this.LBL_Fixed_NX.Visible = false;
            // 
            // LAUNCH_TC
            // 
            this.LAUNCH_TC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LAUNCH_TC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LAUNCH_TC.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LAUNCH_TC.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.LAUNCH_TC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.LAUNCH_TC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LAUNCH_TC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAUNCH_TC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAUNCH_TC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LAUNCH_TC.Image = global::TC_NX_Launch.Properties.Resources.TC_Icon;
            this.LAUNCH_TC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LAUNCH_TC.Location = new System.Drawing.Point(9, 74);
            this.LAUNCH_TC.Name = "LAUNCH_TC";
            this.LAUNCH_TC.Size = new System.Drawing.Size(190, 61);
            this.LAUNCH_TC.TabIndex = 1;
            this.LAUNCH_TC.Text = "TEAMCENTER Portal";
            this.LAUNCH_TC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LAUNCH_TC.UseVisualStyleBackColor = false;
            this.LAUNCH_TC.Click += new System.EventHandler(this.LAUNCH_TC_Click);
            this.LAUNCH_TC.MouseEnter += new System.EventHandler(this.LAUNCH_TC_MouseEnter);
            // 
            // LBL_TC_Server
            // 
            this.LBL_TC_Server.AutoSize = true;
            this.LBL_TC_Server.BackColor = System.Drawing.Color.Transparent;
            this.LBL_TC_Server.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TC_Server.ForeColor = System.Drawing.Color.Lime;
            this.LBL_TC_Server.Location = new System.Drawing.Point(96, 48);
            this.LBL_TC_Server.Name = "LBL_TC_Server";
            this.LBL_TC_Server.Size = new System.Drawing.Size(14, 19);
            this.LBL_TC_Server.TabIndex = 86;
            this.LBL_TC_Server.Text = "-";
            // 
            // Lbl_tcserver
            // 
            this.Lbl_tcserver.AutoSize = true;
            this.Lbl_tcserver.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_tcserver.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tcserver.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl_tcserver.Location = new System.Drawing.Point(7, 48);
            this.Lbl_tcserver.Name = "Lbl_tcserver";
            this.Lbl_tcserver.Size = new System.Drawing.Size(71, 19);
            this.Lbl_tcserver.TabIndex = 85;
            this.Lbl_tcserver.Text = "Database";
            // 
            // Lbl_TC_versie
            // 
            this.Lbl_TC_versie.AutoSize = true;
            this.Lbl_TC_versie.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_TC_versie.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TC_versie.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_TC_versie.Location = new System.Drawing.Point(96, 18);
            this.Lbl_TC_versie.Name = "Lbl_TC_versie";
            this.Lbl_TC_versie.Size = new System.Drawing.Size(14, 19);
            this.Lbl_TC_versie.TabIndex = 84;
            this.Lbl_TC_versie.Text = "-";
            // 
            // label_tc_ver
            // 
            this.label_tc_ver.AutoSize = true;
            this.label_tc_ver.BackColor = System.Drawing.Color.Transparent;
            this.label_tc_ver.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tc_ver.ForeColor = System.Drawing.Color.Yellow;
            this.label_tc_ver.Location = new System.Drawing.Point(7, 18);
            this.label_tc_ver.Name = "label_tc_ver";
            this.label_tc_ver.Size = new System.Drawing.Size(77, 19);
            this.label_tc_ver.TabIndex = 83;
            this.label_tc_ver.Text = "TC Version";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 154);
            this.panel1.TabIndex = 97;
            this.panel1.Click += new System.EventHandler(this.TitleClick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::TC_NX_Launch.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(15, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(429, 92);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.TitleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LBL_AppVersion
            // 
            this.LBL_AppVersion.AutoSize = true;
            this.LBL_AppVersion.BackColor = System.Drawing.Color.Transparent;
            this.LBL_AppVersion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AppVersion.ForeColor = System.Drawing.Color.Gray;
            this.LBL_AppVersion.Location = new System.Drawing.Point(29, 6);
            this.LBL_AppVersion.Name = "LBL_AppVersion";
            this.LBL_AppVersion.Size = new System.Drawing.Size(12, 14);
            this.LBL_AppVersion.TabIndex = 99;
            this.LBL_AppVersion.Text = "v";
            this.LBL_AppVersion.Click += new System.EventHandler(this.SettingsEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.LBL_grouperror);
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.SettingsEdit);
            this.panel2.Controls.Add(this.help);
            this.panel2.Controls.Add(this.LBL_AppVersion);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(5, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 25);
            this.panel2.TabIndex = 101;
            // 
            // LBL_grouperror
            // 
            this.LBL_grouperror.AutoSize = true;
            this.LBL_grouperror.BackColor = System.Drawing.Color.Yellow;
            this.LBL_grouperror.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_grouperror.ForeColor = System.Drawing.Color.Red;
            this.LBL_grouperror.Location = new System.Drawing.Point(66, 4);
            this.LBL_grouperror.Name = "LBL_grouperror";
            this.LBL_grouperror.Size = new System.Drawing.Size(287, 19);
            this.LBL_grouperror.TabIndex = 100;
            this.LBL_grouperror.Text = "Selected Group is not availible on Server";
            this.LBL_grouperror.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Cancel.Location = new System.Drawing.Point(359, -2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(58, 25);
            this.Cancel.TabIndex = 89;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SettingsEdit
            // 
            this.SettingsEdit.BackColor = System.Drawing.Color.Transparent;
            this.SettingsEdit.Image = global::TC_NX_Launch.Properties.Resources.settingsicon;
            this.SettingsEdit.Location = new System.Drawing.Point(3, 3);
            this.SettingsEdit.Name = "SettingsEdit";
            this.SettingsEdit.Size = new System.Drawing.Size(20, 20);
            this.SettingsEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsEdit.TabIndex = 96;
            this.SettingsEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.SettingsEdit, "Show the settingspanel");
            this.SettingsEdit.Click += new System.EventHandler(this.SettingsEdit_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.Image = global::TC_NX_Launch.Properties.Resources.Information;
            this.help.Location = new System.Drawing.Point(423, 3);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(20, 20);
            this.help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help.TabIndex = 98;
            this.help.TabStop = false;
            this.toolTip1.SetToolTip(this.help, "Opens documentation");
            this.help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Violet;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Image = global::TC_NX_Launch.Properties.Resources.border_bar;
            this.label4.Location = new System.Drawing.Point(241, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 14);
            this.label4.TabIndex = 95;
            this.label4.Text = "TEAMCENTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Violet;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Image = global::TC_NX_Launch.Properties.Resources.border_bar;
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 14);
            this.label3.TabIndex = 94;
            this.label3.Text = "NX";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TC_NX_Launch.Properties.Resources.border_bar;
            this.pictureBox5.Location = new System.Drawing.Point(234, 160);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(210, 22);
            this.pictureBox5.TabIndex = 92;
            this.pictureBox5.TabStop = false;
            // 
            // Folddown
            // 
            this.Folddown.BackColor = System.Drawing.Color.White;
            this.Folddown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Folddown.Image = global::TC_NX_Launch.Properties.Resources.border_down;
            this.Folddown.Location = new System.Drawing.Point(203, 160);
            this.Folddown.Name = "Folddown";
            this.Folddown.Size = new System.Drawing.Size(22, 22);
            this.Folddown.TabIndex = 89;
            this.Folddown.TabStop = false;
            this.toolTip1.SetToolTip(this.Folddown, "Select the installed NX version and or Group environment");
            this.Folddown.Click += new System.EventHandler(this.Folddown_Click);
            // 
            // NXbar
            // 
            this.NXbar.Image = global::TC_NX_Launch.Properties.Resources.border_bar;
            this.NXbar.Location = new System.Drawing.Point(15, 160);
            this.NXbar.Name = "NXbar";
            this.NXbar.Size = new System.Drawing.Size(188, 22);
            this.NXbar.TabIndex = 91;
            this.NXbar.TabStop = false;
            this.NXbar.Click += new System.EventHandler(this.NXbar_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SettingsPanel.Controls.Add(this.Button_Credits);
            this.SettingsPanel.Controls.Add(this.button1);
            this.SettingsPanel.Controls.Add(this.Check_HideInterFace);
            this.SettingsPanel.Controls.Add(this.Check_FocusTC);
            this.SettingsPanel.Controls.Add(this.Check_FocusNX);
            this.SettingsPanel.Controls.Add(this.doku);
            this.SettingsPanel.Controls.Add(this.label5);
            this.SettingsPanel.Controls.Add(this.linkMail);
            this.SettingsPanel.Controls.Add(this.SettingsOpen);
            this.SettingsPanel.Location = new System.Drawing.Point(15, 526);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(429, 149);
            this.SettingsPanel.TabIndex = 102;
            this.toolTip1.SetToolTip(this.SettingsPanel, "Close Settings");
            this.SettingsPanel.Visible = false;
            this.SettingsPanel.Click += new System.EventHandler(this.Settingspanel_Click);
            // 
            // Button_Credits
            // 
            this.Button_Credits.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Credits.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button_Credits.Image = global::TC_NX_Launch.Properties.Resources.user_business_add;
            this.Button_Credits.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Credits.Location = new System.Drawing.Point(155, 21);
            this.Button_Credits.Name = "Button_Credits";
            this.Button_Credits.Size = new System.Drawing.Size(53, 58);
            this.Button_Credits.TabIndex = 10;
            this.Button_Credits.Text = "Login";
            this.Button_Credits.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.Button_Credits, "Allows you to enter your credentials for faster launch off TC and NX (will be sto" +
        "red encrypted)");
            this.Button_Credits.UseVisualStyleBackColor = true;
            this.Button_Credits.Click += new System.EventHandler(this.Button_Credits_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(397, -5);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Settingspanel_Click);
            // 
            // Check_HideInterFace
            // 
            this.Check_HideInterFace.AutoSize = true;
            this.Check_HideInterFace.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_HideInterFace.ForeColor = System.Drawing.Color.White;
            this.Check_HideInterFace.Location = new System.Drawing.Point(12, 101);
            this.Check_HideInterFace.Name = "Check_HideInterFace";
            this.Check_HideInterFace.Size = new System.Drawing.Size(235, 22);
            this.Check_HideInterFace.TabIndex = 8;
            this.Check_HideInterFace.Text = "Hide Full interface on next launch";
            this.toolTip1.SetToolTip(this.Check_HideInterFace, resources.GetString("Check_HideInterFace.ToolTip"));
            this.Check_HideInterFace.UseVisualStyleBackColor = true;
            // 
            // Check_FocusTC
            // 
            this.Check_FocusTC.AutoSize = true;
            this.Check_FocusTC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Check_FocusTC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_FocusTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Check_FocusTC.Location = new System.Drawing.Point(309, 111);
            this.Check_FocusTC.Name = "Check_FocusTC";
            this.Check_FocusTC.Size = new System.Drawing.Size(98, 22);
            this.Check_FocusTC.TabIndex = 7;
            this.Check_FocusTC.Text = "Focus on TC";
            this.toolTip1.SetToolTip(this.Check_FocusTC, "TC button recieves the focus. \r\n<enter> or <space> will launch TC");
            this.Check_FocusTC.UseVisualStyleBackColor = true;
            // 
            // Check_FocusNX
            // 
            this.Check_FocusNX.AutoSize = true;
            this.Check_FocusNX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Check_FocusNX.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_FocusNX.ForeColor = System.Drawing.Color.OrangeRed;
            this.Check_FocusNX.Location = new System.Drawing.Point(306, 83);
            this.Check_FocusNX.Name = "Check_FocusNX";
            this.Check_FocusNX.Size = new System.Drawing.Size(101, 22);
            this.Check_FocusNX.TabIndex = 6;
            this.Check_FocusNX.Text = "Focus on NX";
            this.toolTip1.SetToolTip(this.Check_FocusNX, "NX button recieves the focus. \r\n<enter> or <space> will launch NX");
            this.Check_FocusNX.UseVisualStyleBackColor = true;
            // 
            // doku
            // 
            this.doku.FlatAppearance.BorderSize = 0;
            this.doku.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doku.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.doku.Image = global::TC_NX_Launch.Properties.Resources.Information;
            this.doku.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.doku.Location = new System.Drawing.Point(90, 21);
            this.doku.Name = "doku";
            this.doku.Size = new System.Drawing.Size(59, 58);
            this.doku.TabIndex = 4;
            this.doku.Text = "Info";
            this.doku.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.doku, "Opens the documentation");
            this.doku.UseVisualStyleBackColor = true;
            this.doku.Click += new System.EventHandler(this.Doku_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(241, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Request support:";
            // 
            // linkMail
            // 
            this.linkMail.AutoSize = true;
            this.linkMail.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkMail.Location = new System.Drawing.Point(241, 41);
            this.linkMail.Name = "linkMail";
            this.linkMail.Size = new System.Drawing.Size(171, 18);
            this.linkMail.TabIndex = 1;
            this.linkMail.TabStop = true;
            this.linkMail.Text = "TEAMCENTER@kmwe.com";
            this.toolTip1.SetToolTip(this.linkMail, "Report any bugs, requests or other questions");
            this.linkMail.Click += new System.EventHandler(this.LinkMail_Click);
            // 
            // SettingsOpen
            // 
            this.SettingsOpen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsOpen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SettingsOpen.Image = global::TC_NX_Launch.Properties.Resources.settingsicon;
            this.SettingsOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SettingsOpen.Location = new System.Drawing.Point(12, 21);
            this.SettingsOpen.Name = "SettingsOpen";
            this.SettingsOpen.Size = new System.Drawing.Size(72, 58);
            this.SettingsOpen.TabIndex = 0;
            this.SettingsOpen.Text = "Settings";
            this.SettingsOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.SettingsOpen, "Modify the settings file.\r\n(Need RW access to the file)");
            this.SettingsOpen.UseVisualStyleBackColor = true;
            this.SettingsOpen.Click += new System.EventHandler(this.SettingsOpen_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 600;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 687);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Folddown);
            this.Controls.Add(this.Foldup);
            this.Controls.Add(this.NXbar);
            this.Controls.Add(this.panelselect);
            this.Controls.Add(this.paneloverview);
            this.Controls.Add(this.paneltc);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KMWE Teamcenter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Settingspanel_Click);
            this.panelselect.ResumeLayout(false);
            this.panelselect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nx_icon)).EndInit();
            this.paneloverview.ResumeLayout(false);
            this.paneloverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foldup)).EndInit();
            this.paneltc.ResumeLayout(false);
            this.paneltc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Folddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NXbar)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        internal System.Windows.Forms.Label LabelEnv;
        internal System.Windows.Forms.ListBox ListGroup;
        internal System.Windows.Forms.ListBox ListApp;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelselect;
        private System.Windows.Forms.PictureBox Nx_icon;
        private System.Windows.Forms.LinkLabel Nxlaunch_label;
        private System.Windows.Forms.Panel paneloverview;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label labelVerise;
        internal System.Windows.Forms.Label label_nxenv;
        internal System.Windows.Forms.PictureBox Folddown;
        internal System.Windows.Forms.PictureBox Foldup;
        internal System.Windows.Forms.PictureBox NXbar;
        internal System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel paneltc;
        internal System.Windows.Forms.Label label_tc_ver;
        internal System.Windows.Forms.Label LbL_NX_environment;
        internal System.Windows.Forms.Label Lbl_NX_versie;
        internal System.Windows.Forms.Label Lbl_TC_versie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox SettingsEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_AppVersion;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label LBL_TC_Server;
        internal System.Windows.Forms.Label Lbl_tcserver;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button LAUNCH_TC;
        private System.Windows.Forms.Button LAUNCH_NX;
        private System.Windows.Forms.Label LBL_grouperror;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkMail;
        private System.Windows.Forms.Button SettingsOpen;
        private System.Windows.Forms.Label LBL_Fixed_NX;
        private System.Windows.Forms.Button doku;
        private System.Windows.Forms.RadioButton Check_FocusTC;
        private System.Windows.Forms.RadioButton Check_FocusNX;
        private System.Windows.Forms.CheckBox Check_HideInterFace;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Credits;
    }
}

