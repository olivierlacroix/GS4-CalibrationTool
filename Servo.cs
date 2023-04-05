using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace GS4_Calibration_Utility
{
    internal class Servo
    {
        Board _board;
        
        int _servoId;
        int _currentPosition=0;
        bool _isEnabled = false;

        public const int MAX_POSITION = 16383;
        public const int DEFAULT_CENTER_POSITION = 8000;
        public const int MAX_RANGE = 6000;
        public const int MIN_RANGE = 6000;


        public int CurrentPosition
        {
            get { return _currentPosition; }   
        }


        public Servo(Board board, int currentServoId)
        {
            _board = board;
            _servoId = currentServoId;

        }

        public int ID { get { return _servoId; } }

        public void Enable()
        {
            
            Module1.ServoEnable(_board.ComPort, _board.BoardNumber, _servoId);
            _isEnabled = true;

        }

        public void Disable()
        {
            if( _isEnabled )
            {
                
                Module1.ServoDisable(_board.ComPort, _board.BoardNumber, _servoId);
                _isEnabled = false;
            }
            

        }

        public void MovePercent(float percent)
        {
            Module1.QuickMovePercent(_board.ComPort, _board.BoardNumber, _servoId, percent);
            Module1.GetCurrentPositionRaw(_board.ComPort, _board.BoardNumber, _servoId, ref _currentPosition);
        }

        public void Move(int increment)
        {
            if (_currentPosition + increment < MAX_POSITION && _currentPosition + increment > 0) 
            { 
                _currentPosition = _currentPosition + increment;
                Module1.QuickMoveRaw(_board.ComPort, _board.BoardNumber, _servoId, _currentPosition);
            }
        }

        public void MoveMin()
        {
            int minPos = 0;
            Module1.GetMinPosition(_board.ComPort, _board.BoardNumber, _servoId, ref minPos);
            Module1.QuickMoveRaw(_board.ComPort, _board.BoardNumber, _servoId, minPos);
            Module1.GetCurrentPositionRaw(_board.ComPort, _board.BoardNumber, _servoId, ref _currentPosition);
            Console.WriteLine(_currentPosition);
        }

        public void MoveMax()
        {
            int maxPos = 0;
            Module1.GetMaxPosition(_board.ComPort, _board.BoardNumber, _servoId, ref maxPos);
            Module1.QuickMoveRaw(_board.ComPort, _board.BoardNumber, _servoId, maxPos);
            Module1.GetCurrentPositionRaw(_board.ComPort, _board.BoardNumber, _servoId, ref _currentPosition);
            Console.WriteLine(_currentPosition);
        }

        public void MoveCenter()
        {
            int startPos = 0;
            Module1.GetStartPosition(_board.ComPort, _board.BoardNumber, _servoId, ref startPos);
            Module1.QuickMoveRaw(_board.ComPort, _board.BoardNumber, _servoId, startPos);
            Module1.GetCurrentPositionRaw(_board.ComPort, _board.BoardNumber, _servoId, ref _currentPosition);
            Console.WriteLine(_currentPosition);

        }

        public void SetMaxCurrentPosition()
        { Module1.SetMaxCurrent(_board.ComPort, _board.BoardNumber, _servoId); }

       

        public void SetMinCurrentPosition()
        { Module1.SetMinCurrent(_board.ComPort, _board.BoardNumber, _servoId); }

        public void SetStart()
        { Module1.SetStartCurrent(_board.ComPort, _board.BoardNumber, _servoId); }

        public void SetPosition()
        {

            int relativeMaxPosition;
            int relativeMinPosition;

            Module1.GetCurrentPositionRaw(_board.ComPort, _board.BoardNumber, _servoId, ref _currentPosition);

            if(_currentPosition + MAX_RANGE > MAX_POSITION) { relativeMaxPosition = MAX_POSITION; } else { relativeMaxPosition = _currentPosition + MAX_RANGE; }
            if(_currentPosition - MIN_RANGE < 0) { relativeMinPosition = 0; } else { relativeMinPosition = _currentPosition - MIN_RANGE; }

            Module1.SetMax(_board.ComPort, _board.BoardNumber, _servoId, relativeMaxPosition);
            Module1.SetMin(_board.ComPort, _board.BoardNumber, _servoId, relativeMinPosition);
            Module1.SetStart(_board.ComPort, _board.BoardNumber, _servoId, _currentPosition);
            
            Module1.ServoDisable(_board.ComPort, _board.BoardNumber, _servoId);
            
            //this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
            //Module1.ServoEnable(_board.ComPort, _board.BoardNumber, _servoId);
            //Module1.QuickMoveRaw(_board.ComPort, _board.BoardNumber, _servoId, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
           
        }

    }
}
