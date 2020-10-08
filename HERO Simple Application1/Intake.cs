namespace HERO_Simple_Application1
{
    public enum IntakeStates
    {
        STOP_STATE,
        IN_STATE,
        OUT_STATE
    }

    public class Intake
    {
        private int intakeTalon1ID = 0;
        private int intakeTalon2ID = 0;

        public int intakeState = (int)IntakeStates.STOP_STATE;

        public Intake()
        {
            CTRE.Phoenix.MotorControl.CAN.TalonSRX intakeTalon1 = new CTRE.Phoenix.MotorControl.CAN.TalonSRX(intakeTalon1ID);
            CTRE.Phoenix.MotorControl.CAN.TalonSRX intakeTalon2 = new CTRE.Phoenix.MotorControl.CAN.TalonSRX(intakeTalon2ID);
        }

        public void stateMachine()
        {
            switch (intakeState)
            {
                case (int)IntakeStates.STOP_STATE:
                    Stop();
                    break;

                case (int)IntakeStates.IN_STATE:
                    In();
                    break;

                case (int)IntakeStates.OUT_STATE:
                    Out();
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