using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace GS4_Calibration_Utility
{
    internal class Panel
    {
        public enum PanelType {
            BackLeft = 1,
            BackRight = 2,
            BottomLeft = 3,
            BottomRight = 4
        }

        private int[] BackLeftServosListId = { 2, 0, 10, 8 };
        private int[] BackRightServosListId = { 1, 3, 9, 11 };
        private int[] BottomRightServosListId = { 7, 5, 15, 13 };
        private int[] BottomLeftServosListId = { 4, 6, 12, 14 };


        private List<Servo> _servos;

        public Panel(PanelType typePanel, Board board)
        {
            int[] servosIds = { -1 };

            switch (typePanel)
            {
                case PanelType.BackLeft:
                    servosIds = BackLeftServosListId;
                    break;
                case PanelType.BackRight:
                    servosIds = BackRightServosListId;
                    break;
                case PanelType.BottomLeft:
                    servosIds = BottomLeftServosListId;
                    break;
                case PanelType.BottomRight:
                    servosIds = BottomRightServosListId;
                    break;
            }

            InitializeServos(servosIds, board);




        }

        public Servo GetServo(int servoId)
        {
            return _servos.Find(x => x.ID == servoId);
        }

        private void InitializeServos(int[] servosIds, Board board)
        {
            _servos = new List<Servo>();
            foreach (int servoId in servosIds)
            {
                _servos.Add(new Servo(board, servoId));
            }
        }

        public void MoveMax()
        {

            EnableServos();

            foreach (Servo servo in _servos)
            {
                servo.MovePercent(100f);

            }

        }

        public void MoveMin()
        {

            EnableServos();

            foreach (Servo servo in _servos)
            {
                servo.MovePercent(0f);

            }

        }

        private void EnableServos()
        {
            foreach (Servo servo in _servos)
            {
                servo.Enable();

            }
        }

        public void MoveCenter()
        {
            EnableServos();


            foreach (Servo servo in _servos)
            {
                servo.MoveCenter();

            }
        }

        public void MovePercent(float percent)
        {
            EnableServos();
            foreach (Servo servo in _servos)
            {
                servo.MovePercent(percent);
            }

        }

      

    }
}
