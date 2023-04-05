using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GS4_Calibration_Utility
{
    public partial class Calibration : Form
    {
        private Board board;
        private Servo selectedServo;
        private Servo sisterServo;
        private Panel.PanelType panelTypeToTest;
        private Panel panelToTest;

        public Calibration()
        {
            InitializeComponent();

            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           

            

        }

        private void MoveSisterServoMAX_Click(object sender, EventArgs e)
        {
            sisterServo.Enable();
            sisterServo.MoveMax();

        }

        private void MoveSisterServoMIN_Click(object sender, EventArgs e)
        {
            sisterServo.Enable();
            sisterServo.MoveMin();
        }

        

        private void btnConnectPanelTest_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectBoard_Click(object sender, EventArgs e)
        {
            board = new Board(Convert.ToInt32(comPort.Text));

            board.Connect();

            tabModes.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           panelToTest = new Panel(panelTypeToTest, board);

        }

        private void cboPanelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelTypeToTest = (Panel.PanelType)(cboPanelList.SelectedIndex + 1);
        }

        private void scrollPanelToTest_Scroll(object sender, ScrollEventArgs e)
        {
            panelToTest.MovePercent(scrollPanelToTest.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSetMAX_Click(object sender, EventArgs e)
        {
            selectedServo.SetMaxCurrentPosition();

        }

        private void btnSetMin_Click(object sender, EventArgs e)
        {
            selectedServo.SetMinCurrentPosition();
            
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            //selectedServo.MoveCenter();
            //sisterServo.MoveCenter();
            board.CommitSettings();

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            board.Disconnect();
            tabModes.Enabled = false;
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            selectedServo = new Servo(board, Convert.ToInt32(selectedServoID.Text));
            sisterServo = new Servo(board, Convert.ToInt32(sisterServoID.Text));

            selectedServo.Enable();
            sisterServo.Enable();


        }

        private void Calibration_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            if (board != null) { board.Disconnect(); }

        }

        private void btnMoveMAX_Click(object sender, EventArgs e)
        {
            panelToTest.MoveMax();
        }

        private void btnMoveCenter_Click(object sender, EventArgs e)
        {
            panelToTest.MoveCenter();
        }

        private void btnMoveMin_Click(object sender, EventArgs e)
        {
            panelToTest.MoveMin();     
        }

        private void btnFineDecrease_Click(object sender, EventArgs e)
        {
            selectedServo.Move(-25);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            selectedServo.Move(25);
        }

        private void btnDecreaseFast_Click(object sender, EventArgs e)
        {
            selectedServo.Move(-150);
        }

        private void btnIncreaseFast_Click(object sender, EventArgs e)
        {
            selectedServo.Move(150);
        }

        private void btnMoveServoToCalibrateMAX_Click(object sender, EventArgs e)
        {
            selectedServo.Enable();
            selectedServo.MoveMax();
        }

        private void btnMoveServoToCalibrateMIN_Click(object sender, EventArgs e)
        {
            selectedServo.Enable();
            selectedServo.MoveMin();
        }

        private void MoveSisterServoCENTER_Click(object sender, EventArgs e)
        {
            sisterServo.Enable();
            sisterServo.MoveCenter();

            
        }

        private void btnMoveServoToCalibrateCENTER_Click(object sender, EventArgs e)
        {
            selectedServo.Enable();
            selectedServo.MoveCenter();

            

        }

        private void SetSTART_Click(object sender, EventArgs e)
        {
            selectedServo.SetStart();
        }

        private void SETPOS_Click(object sender, EventArgs e)
        {
            selectedServo.SetPosition();
        }
    }
}
