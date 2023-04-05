using System.Windows.Forms;

namespace GS4_Calibration_Utility
{
    partial class Calibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibration));
            this.lblComPort = new System.Windows.Forms.Label();
            this.comPort = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabModes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SETPOS = new System.Windows.Forms.Button();
            this.SetSTART = new System.Windows.Forms.Button();
            this.btnMoveServoToCalibrateCENTER = new System.Windows.Forms.Button();
            this.MoveSisterServoCENTER = new System.Windows.Forms.Button();
            this.btnMoveServoToCalibrateMIN = new System.Windows.Forms.Button();
            this.btnMoveServoToCalibrateMAX = new System.Windows.Forms.Button();
            this.btnIncreaseFast = new System.Windows.Forms.Button();
            this.btnDecreaseFast = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFineDecrease = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnSetMin = new System.Windows.Forms.Button();
            this.btnSetMAX = new System.Windows.Forms.Button();
            this.ScrollServoToCalibrate = new System.Windows.Forms.HScrollBar();
            this.MoveSisterServoMIN = new System.Windows.Forms.Button();
            this.MoveSisterServoMAX = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.sisterServoID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedServoID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPanelTesting = new System.Windows.Forms.TabPage();
            this.btnMoveMin = new System.Windows.Forms.Button();
            this.btnMoveCenter = new System.Windows.Forms.Button();
            this.btnMoveMAX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.scrollPanelToTest = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPanelList = new System.Windows.Forms.ComboBox();
            this.btnConnectBoard = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabModes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPanelTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(22, 15);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(86, 20);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port :";
            this.lblComPort.Click += new System.EventHandler(this.label1_Click);
            // 
            // comPort
            // 
            this.comPort.Location = new System.Drawing.Point(119, 12);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(37, 26);
            this.comPort.TabIndex = 1;
            this.comPort.Text = "7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(910, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 466);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabModes
            // 
            this.tabModes.Controls.Add(this.tabPage1);
            this.tabModes.Controls.Add(this.tabPanelTesting);
            this.tabModes.Enabled = false;
            this.tabModes.Location = new System.Drawing.Point(26, 66);
            this.tabModes.Name = "tabModes";
            this.tabModes.SelectedIndex = 0;
            this.tabModes.Size = new System.Drawing.Size(851, 555);
            this.tabModes.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SETPOS);
            this.tabPage1.Controls.Add(this.SetSTART);
            this.tabPage1.Controls.Add(this.btnMoveServoToCalibrateCENTER);
            this.tabPage1.Controls.Add(this.MoveSisterServoCENTER);
            this.tabPage1.Controls.Add(this.btnMoveServoToCalibrateMIN);
            this.tabPage1.Controls.Add(this.btnMoveServoToCalibrateMAX);
            this.tabPage1.Controls.Add(this.btnIncreaseFast);
            this.tabPage1.Controls.Add(this.btnDecreaseFast);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnFineDecrease);
            this.tabPage1.Controls.Add(this.btnCommit);
            this.tabPage1.Controls.Add(this.btnSetMin);
            this.tabPage1.Controls.Add(this.btnSetMAX);
            this.tabPage1.Controls.Add(this.ScrollServoToCalibrate);
            this.tabPage1.Controls.Add(this.MoveSisterServoMIN);
            this.tabPage1.Controls.Add(this.MoveSisterServoMAX);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.sisterServoID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.selectedServoID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servo calibration pair mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SETPOS
            // 
            this.SETPOS.Location = new System.Drawing.Point(620, 222);
            this.SETPOS.Name = "SETPOS";
            this.SETPOS.Size = new System.Drawing.Size(135, 134);
            this.SETPOS.TabIndex = 28;
            this.SETPOS.Text = "SET calibrated servo POSITION baseline";
            this.SETPOS.UseVisualStyleBackColor = true;
            this.SETPOS.Click += new System.EventHandler(this.SETPOS_Click);
            // 
            // SetSTART
            // 
            this.SetSTART.Location = new System.Drawing.Point(215, 341);
            this.SetSTART.Name = "SetSTART";
            this.SetSTART.Size = new System.Drawing.Size(135, 55);
            this.SetSTART.TabIndex = 27;
            this.SetSTART.Text = "Set START";
            this.SetSTART.UseVisualStyleBackColor = true;
            this.SetSTART.Click += new System.EventHandler(this.SetSTART_Click);
            // 
            // btnMoveServoToCalibrateCENTER
            // 
            this.btnMoveServoToCalibrateCENTER.Location = new System.Drawing.Point(398, 341);
            this.btnMoveServoToCalibrateCENTER.Name = "btnMoveServoToCalibrateCENTER";
            this.btnMoveServoToCalibrateCENTER.Size = new System.Drawing.Size(135, 55);
            this.btnMoveServoToCalibrateCENTER.TabIndex = 26;
            this.btnMoveServoToCalibrateCENTER.Text = "Move calibrated servo CENTER";
            this.btnMoveServoToCalibrateCENTER.UseVisualStyleBackColor = true;
            this.btnMoveServoToCalibrateCENTER.Click += new System.EventHandler(this.btnMoveServoToCalibrateCENTER_Click);
            // 
            // MoveSisterServoCENTER
            // 
            this.MoveSisterServoCENTER.Location = new System.Drawing.Point(29, 341);
            this.MoveSisterServoCENTER.Name = "MoveSisterServoCENTER";
            this.MoveSisterServoCENTER.Size = new System.Drawing.Size(135, 55);
            this.MoveSisterServoCENTER.TabIndex = 25;
            this.MoveSisterServoCENTER.Text = "Move sister servo CENTER";
            this.MoveSisterServoCENTER.UseVisualStyleBackColor = true;
            this.MoveSisterServoCENTER.Click += new System.EventHandler(this.MoveSisterServoCENTER_Click);
            // 
            // btnMoveServoToCalibrateMIN
            // 
            this.btnMoveServoToCalibrateMIN.Location = new System.Drawing.Point(398, 266);
            this.btnMoveServoToCalibrateMIN.Name = "btnMoveServoToCalibrateMIN";
            this.btnMoveServoToCalibrateMIN.Size = new System.Drawing.Size(135, 55);
            this.btnMoveServoToCalibrateMIN.TabIndex = 24;
            this.btnMoveServoToCalibrateMIN.Text = "Move calibrated servo MIN";
            this.btnMoveServoToCalibrateMIN.UseVisualStyleBackColor = true;
            this.btnMoveServoToCalibrateMIN.Click += new System.EventHandler(this.btnMoveServoToCalibrateMIN_Click);
            // 
            // btnMoveServoToCalibrateMAX
            // 
            this.btnMoveServoToCalibrateMAX.Location = new System.Drawing.Point(398, 192);
            this.btnMoveServoToCalibrateMAX.Name = "btnMoveServoToCalibrateMAX";
            this.btnMoveServoToCalibrateMAX.Size = new System.Drawing.Size(135, 55);
            this.btnMoveServoToCalibrateMAX.TabIndex = 23;
            this.btnMoveServoToCalibrateMAX.Text = "Move calibrated servo MAX";
            this.btnMoveServoToCalibrateMAX.UseVisualStyleBackColor = true;
            this.btnMoveServoToCalibrateMAX.Click += new System.EventHandler(this.btnMoveServoToCalibrateMAX_Click);
            // 
            // btnIncreaseFast
            // 
            this.btnIncreaseFast.Location = new System.Drawing.Point(569, 110);
            this.btnIncreaseFast.Name = "btnIncreaseFast";
            this.btnIncreaseFast.Size = new System.Drawing.Size(58, 55);
            this.btnIncreaseFast.TabIndex = 22;
            this.btnIncreaseFast.Text = " >>";
            this.btnIncreaseFast.UseVisualStyleBackColor = true;
            this.btnIncreaseFast.Click += new System.EventHandler(this.btnIncreaseFast_Click);
            // 
            // btnDecreaseFast
            // 
            this.btnDecreaseFast.Location = new System.Drawing.Point(325, 110);
            this.btnDecreaseFast.Name = "btnDecreaseFast";
            this.btnDecreaseFast.Size = new System.Drawing.Size(62, 55);
            this.btnDecreaseFast.TabIndex = 21;
            this.btnDecreaseFast.Text = "<<";
            this.btnDecreaseFast.UseVisualStyleBackColor = true;
            this.btnDecreaseFast.Click += new System.EventHandler(this.btnDecreaseFast_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = " >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnFineDecrease
            // 
            this.btnFineDecrease.Location = new System.Drawing.Point(398, 110);
            this.btnFineDecrease.Name = "btnFineDecrease";
            this.btnFineDecrease.Size = new System.Drawing.Size(62, 55);
            this.btnFineDecrease.TabIndex = 19;
            this.btnFineDecrease.Text = "<";
            this.btnFineDecrease.UseVisualStyleBackColor = true;
            this.btnFineDecrease.Click += new System.EventHandler(this.btnFineDecrease_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(29, 417);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(321, 55);
            this.btnCommit.TabIndex = 18;
            this.btnCommit.Text = "Commit settings!";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnSetMin
            // 
            this.btnSetMin.Location = new System.Drawing.Point(215, 266);
            this.btnSetMin.Name = "btnSetMin";
            this.btnSetMin.Size = new System.Drawing.Size(135, 55);
            this.btnSetMin.TabIndex = 17;
            this.btnSetMin.Text = "Set MIN";
            this.btnSetMin.UseVisualStyleBackColor = true;
            this.btnSetMin.Click += new System.EventHandler(this.btnSetMin_Click);
            // 
            // btnSetMAX
            // 
            this.btnSetMAX.Location = new System.Drawing.Point(215, 192);
            this.btnSetMAX.Name = "btnSetMAX";
            this.btnSetMAX.Size = new System.Drawing.Size(135, 55);
            this.btnSetMAX.TabIndex = 16;
            this.btnSetMAX.Text = "Set MAX";
            this.btnSetMAX.UseVisualStyleBackColor = true;
            this.btnSetMAX.Click += new System.EventHandler(this.btnSetMAX_Click);
            // 
            // ScrollServoToCalibrate
            // 
            this.ScrollServoToCalibrate.Location = new System.Drawing.Point(325, 67);
            this.ScrollServoToCalibrate.Name = "ScrollServoToCalibrate";
            this.ScrollServoToCalibrate.Size = new System.Drawing.Size(186, 26);
            this.ScrollServoToCalibrate.TabIndex = 15;
            this.ScrollServoToCalibrate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollServoToCalibrate_Scroll);
            // 
            // MoveSisterServoMIN
            // 
            this.MoveSisterServoMIN.Location = new System.Drawing.Point(29, 266);
            this.MoveSisterServoMIN.Name = "MoveSisterServoMIN";
            this.MoveSisterServoMIN.Size = new System.Drawing.Size(135, 55);
            this.MoveSisterServoMIN.TabIndex = 14;
            this.MoveSisterServoMIN.Text = "Move sister servo MIN";
            this.MoveSisterServoMIN.UseVisualStyleBackColor = true;
            this.MoveSisterServoMIN.Click += new System.EventHandler(this.MoveSisterServoMIN_Click);
            // 
            // MoveSisterServoMAX
            // 
            this.MoveSisterServoMAX.Location = new System.Drawing.Point(29, 192);
            this.MoveSisterServoMAX.Name = "MoveSisterServoMAX";
            this.MoveSisterServoMAX.Size = new System.Drawing.Size(135, 55);
            this.MoveSisterServoMAX.TabIndex = 13;
            this.MoveSisterServoMAX.Text = "Move sister servo MAX";
            this.MoveSisterServoMAX.UseVisualStyleBackColor = true;
            this.MoveSisterServoMAX.Click += new System.EventHandler(this.MoveSisterServoMAX_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(29, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(135, 35);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // sisterServoID
            // 
            this.sisterServoID.FormattingEnabled = true;
            this.sisterServoID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.sisterServoID.Location = new System.Drawing.Point(184, 70);
            this.sisterServoID.Name = "sisterServoID";
            this.sisterServoID.Size = new System.Drawing.Size(82, 28);
            this.sisterServoID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sister Servo ID";
            // 
            // selectedServoID
            // 
            this.selectedServoID.FormattingEnabled = true;
            this.selectedServoID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.selectedServoID.Location = new System.Drawing.Point(184, 28);
            this.selectedServoID.Name = "selectedServoID";
            this.selectedServoID.Size = new System.Drawing.Size(82, 28);
            this.selectedServoID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Servo ID to calibrate";
            // 
            // tabPanelTesting
            // 
            this.tabPanelTesting.Controls.Add(this.btnMoveMin);
            this.tabPanelTesting.Controls.Add(this.btnMoveCenter);
            this.tabPanelTesting.Controls.Add(this.btnMoveMAX);
            this.tabPanelTesting.Controls.Add(this.button1);
            this.tabPanelTesting.Controls.Add(this.scrollPanelToTest);
            this.tabPanelTesting.Controls.Add(this.label3);
            this.tabPanelTesting.Controls.Add(this.cboPanelList);
            this.tabPanelTesting.Location = new System.Drawing.Point(4, 29);
            this.tabPanelTesting.Name = "tabPanelTesting";
            this.tabPanelTesting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPanelTesting.Size = new System.Drawing.Size(843, 522);
            this.tabPanelTesting.TabIndex = 1;
            this.tabPanelTesting.Text = "Panel testing";
            this.tabPanelTesting.UseVisualStyleBackColor = true;
            // 
            // btnMoveMin
            // 
            this.btnMoveMin.Location = new System.Drawing.Point(21, 265);
            this.btnMoveMin.Name = "btnMoveMin";
            this.btnMoveMin.Size = new System.Drawing.Size(135, 35);
            this.btnMoveMin.TabIndex = 20;
            this.btnMoveMin.Text = "Move MIN";
            this.btnMoveMin.UseVisualStyleBackColor = true;
            this.btnMoveMin.Click += new System.EventHandler(this.btnMoveMin_Click);
            // 
            // btnMoveCenter
            // 
            this.btnMoveCenter.Location = new System.Drawing.Point(21, 211);
            this.btnMoveCenter.Name = "btnMoveCenter";
            this.btnMoveCenter.Size = new System.Drawing.Size(135, 35);
            this.btnMoveCenter.TabIndex = 19;
            this.btnMoveCenter.Text = "Move CENTER";
            this.btnMoveCenter.UseVisualStyleBackColor = true;
            this.btnMoveCenter.Click += new System.EventHandler(this.btnMoveCenter_Click);
            // 
            // btnMoveMAX
            // 
            this.btnMoveMAX.Location = new System.Drawing.Point(21, 155);
            this.btnMoveMAX.Name = "btnMoveMAX";
            this.btnMoveMAX.Size = new System.Drawing.Size(135, 35);
            this.btnMoveMAX.TabIndex = 18;
            this.btnMoveMAX.Text = "Move MAX";
            this.btnMoveMAX.UseVisualStyleBackColor = true;
            this.btnMoveMAX.Click += new System.EventHandler(this.btnMoveMAX_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scrollPanelToTest
            // 
            this.scrollPanelToTest.Location = new System.Drawing.Point(189, 90);
            this.scrollPanelToTest.Name = "scrollPanelToTest";
            this.scrollPanelToTest.Size = new System.Drawing.Size(186, 26);
            this.scrollPanelToTest.TabIndex = 16;
            this.scrollPanelToTest.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollPanelToTest_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select panel to test";
            // 
            // cboPanelList
            // 
            this.cboPanelList.FormattingEnabled = true;
            this.cboPanelList.Items.AddRange(new object[] {
            "BackLeft",
            "BackRight",
            "BottomLeft",
            "BottomRight"});
            this.cboPanelList.Location = new System.Drawing.Point(189, 38);
            this.cboPanelList.Name = "cboPanelList";
            this.cboPanelList.Size = new System.Drawing.Size(121, 28);
            this.cboPanelList.TabIndex = 0;
            this.cboPanelList.SelectedIndexChanged += new System.EventHandler(this.cboPanelList_SelectedIndexChanged);
            // 
            // btnConnectBoard
            // 
            this.btnConnectBoard.Location = new System.Drawing.Point(186, 8);
            this.btnConnectBoard.Name = "btnConnectBoard";
            this.btnConnectBoard.Size = new System.Drawing.Size(135, 35);
            this.btnConnectBoard.TabIndex = 13;
            this.btnConnectBoard.Text = "Connect";
            this.btnConnectBoard.UseVisualStyleBackColor = true;
            this.btnConnectBoard.Click += new System.EventHandler(this.btnConnectBoard_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(355, 8);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(135, 35);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 755);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnectBoard);
            this.Controls.Add(this.tabModes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.lblComPort);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calibration";
            this.Text = "Calibration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calibration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabModes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPanelTesting.ResumeLayout(false);
            this.tabPanelTesting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabModes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.HScrollBar ScrollServoToCalibrate;
        private System.Windows.Forms.Button MoveSisterServoMIN;
        private System.Windows.Forms.Button MoveSisterServoMAX;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox sisterServoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectedServoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPanelTesting;
        private System.Windows.Forms.ComboBox cboPanelList;
        private System.Windows.Forms.Button btnConnectBoard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar scrollPanelToTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetMin;
        private System.Windows.Forms.Button btnSetMAX;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnDisconnect;
        private Button btnMoveMAX;
        private Button btnMoveCenter;
        private Button btnMoveMin;
        private Button btnFineDecrease;
        private Button button2;
        private Button btnDecreaseFast;
        private Button btnIncreaseFast;
        private Button btnMoveServoToCalibrateMIN;
        private Button btnMoveServoToCalibrateMAX;
        private Button btnMoveServoToCalibrateCENTER;
        private Button MoveSisterServoCENTER;
        private Button SetSTART;
        private Button SETPOS;
    }
}