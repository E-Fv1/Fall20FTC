using CTRE.Phoenix.MotorControl.CAN;
using System;

namespace HERO_Simple_Application1
{
    public enum ClimberStates
    {
        STOP_STATE,
        LIFT_ARM_STATE,
        LOWER_ARM_STATE,
        RAISE_HANGER_STATE,
        LOWER_HANGER_STATE
    }

    public class Climber
    {
        private int climberState = (int)ClimberStates.STOP_STATE;

        private TalonSRX armTalon;
        private TalonSRX winchTalon;

        private DateTime currTime = new DateTime();
        private DateTime startTime = new DateTime();

        public Climber(TalonSRX armTalon_, TalonSRX winchTalon_)
        {

            armTalon = armTalon_;
            winchTalon = winchTalon_;

            startTime = DateTime.UtcNow;

        }

        public void stateMachine()
        {
            switch (climberState)
            {
                case (int)ClimberStates.STOP_STATE:
                    Stop();
                    break;

                case (int)ClimberStates.LIFT_ARM_STATE:
                    LiftArm();
                    break;

                case (int)ClimberStates.LOWER_ARM_STATE:
                    LowerArm();
                    break;

                case (int)ClimberStates.RAISE_HANGER_STATE:
                    RaiseHanger();
                    break;

                case (int)ClimberStates.LOWER_HANGER_STATE:
                    LowerHanger();
                    break;

                default:
                    break;
            }
        }

        public void Stop()
        {
            armTalon.Set(CTRE.Phoenix.MotorControl.ControlMode.PercentOutput, 0);
            winchTalon.Set(CTRE.Phoenix.MotorControl.ControlMode.PercentOutput, 0);

        }

        public void LiftArm()
        {
            startTime = DateTime.UtcNow;
            while(DateTime.UtcNow - startTime < TimeSpan.FromTicks(TimeSpan.TicksPerSecond * 10)){} //tbh i should just make a wait function to do this for me
            armTalon.Set(CTRE.Phoenix.MotorControl.ControlMode.PercentOutput, 1);
        }

        public void LowerArm()
        {

        }

        public void RaiseHanger()
        {

        }

        public void LowerHanger()
        {

        }

        private void WaitForSeconds(int s)
        {
            DateTime sTime = DateTime.UtcNow;
            while (DateTime.UtcNow - startTime < TimeSpan.FromTicks(TimeSpan.TicksPerSecond * s)) { }
        }
    }
}