using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

namespace HERO_Simple_Application1
{

    public enum ConveyorStates
    {
        STOP_STATE,
        IN_STATE,
        OUT_STATE
    }

    public class Conveyor
    {

        private int conveyorTalonID = 0;

        private int conveyorState = (int) ConveyorStates.STOP_STATE;
        
        public Conveyor()
        {
            CTRE.Phoenix.MotorControl.CAN.TalonSRX conveyorTalon = new CTRE.Phoenix.MotorControl.CAN.TalonSRX(conveyorTalonID);
        }

        public void stateMachine()
        {
            switch (conveyorState)
            {
                case (int) ConveyorStates.STOP_STATE:
                    break;
                case (int) ConveyorStates.IN_STATE:
                    break;
                case (int) ConveyorStates.OUT_STATE:
                    break;
                default:
                    break;
            }
        }

        private void Stop()
        {

        }

        private void In()
        {

        }

        private void Out()
        {

        }
    }
}