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
    public partial class TestForm : Form
    {
        private short scboard = 1;
		private int scbaud = 115200;
        private Int32 scComPort = -1;
        private Int32 scServoNumSelected = -1;
        private bool scServoBoardConnected = false;
        public TestForm()
        {
            InitializeComponent();
        }



        private void CalServoDisable()
        {
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 0);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 1);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 2);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 3);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 4);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 5);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 6);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 7);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 8);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 9);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 10);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 11);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 12);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 13);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 14);
            Yeisrvo.ServoDisable(Convert.ToInt32(scComPort), this.scboard, 15);
        }

        private void CalServoEnable()
        {
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 0);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 1);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 2);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 3);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 4);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 5);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 6);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 7);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 8);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 9);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 10);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 11);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 12);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 13);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 14);
            Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, 15);
        }

        private void ConnectServosBoard()
        {
            Yeisrvo.InitPort(Convert.ToInt32(scComPort), this.scbaud);
            
            Thread.Sleep(1000);
            //Yeisrvo.ServoEnable(Convert.ToInt32(scComPort), this.scboard, this.Rev2CurrentServo);
            //Yeisrvo.QuickMoveRaw(Convert.ToInt32(scComPort), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
        }


        private void TestForm_Load(object sender, EventArgs e)
        {
            btnOnOff.Enabled = false;

        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CalServoDisable();
            Yeisrvo.CloseAllComs();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (btnOnOff.Text == "OFF")
            {
               
                if (scComPort < 0)
                {
                    MessageBox.Show("Not a valid COM port", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (!scServoBoardConnected)
                    {
                        ConnectServosBoard();
                        scServoBoardConnected = true;
                    }
                    btnOnOff.Text = "ON";
                    btnOnOff.BackColor = Color.Green;
                    txtComPort.Enabled = false;
                    CalServoEnable();
                    grpIndividualTest.Enabled = true;

                }
                

            }
            else
            {
                btnOnOff.Text = "OFF";
                btnOnOff.BackColor = Color.Red;
                txtComPort.Enabled = true;
                CalServoDisable();
                cboServoNumber.SelectedItem = null;
                grpIndividualTest.Enabled = false;
            }

        }

        private void txtComPort_TextChanged(object sender, EventArgs e)
        {
            int comPort;
            if (Int32.TryParse(txtComPort.Text, out comPort))
            {
                scComPort = comPort;
                lblportwarning.Visible = false;
                btnOnOff.Enabled = true;
            }
            else
            {
                lblportwarning.Visible = true;
                btnOnOff.Enabled = false;
            }

        }

        private void cboServoNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int servoNum;
            if (cboServoNumber.SelectedItem != null && Int32.TryParse(cboServoNumber.SelectedItem.ToString(), out servoNum))
            {
                scServoNumSelected = servoNum;
                scrollServo.Value = 50;
                scrollServo.Enabled = true;
                Yeisrvo.QuickMovePercent(scComPort, scboard, scServoNumSelected, scrollServo.Value);
                
            }
            else
            {
                scServoNumSelected = -1;
                scrollServo.Enabled = false;
            }
           
        }

        private void scrollServo_Scroll(object sender, ScrollEventArgs e)
        {
            Yeisrvo.CompactMovePercent(scComPort, scboard, scServoNumSelected, scrollServo.Value, 100f);
        }
    }
}
