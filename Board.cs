using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GS4_Calibration_Utility
{
    internal class Board
    {
        const int BOARD_NUMBER = 1;
        const int BAUD_RATE = 115200;
        int _comPort;
        bool _isConnected = false;

        public Board(int comPort)
        {
            _comPort = comPort;
        }

        public int BoardNumber
        {
            get { return BOARD_NUMBER; }

        }

        public int ComPort
        {
            get { return _comPort; }

        }

        public int BaudRate
        { get { return BAUD_RATE; } }

        public void Connect()
        {
            if (!_isConnected)
            {
                Yeisrvo.InitPort(_comPort, BAUD_RATE);
                Thread.Sleep(1000);
                _isConnected = true;
            }

        }



        public void CommitSettings()
        {

            Module1.CommitSettings(_comPort, BOARD_NUMBER);
        }

        public void Disconnect()
        {
            if (_isConnected)
            {
                CallServoDisable();
                Module1.CloseAllComs();
                _isConnected = false;
            }
        }

        private void CallServoDisable()
        {
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 0);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 1);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 2);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 3);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 4);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 5);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 6);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 7);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 8);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 9);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 10);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 11);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 12);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 13);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 14);
            Module1.ServoDisable(_comPort, BOARD_NUMBER, 15);
        }


    }
}
