using CTRE.Phoenix.Controller;

namespace HERO_Simple_Application1
{
    public enum States
    {
        WAITING_FOR_INPUT_STATE,

        INTAKE_IN_STATE,
        INTAKE_OUT_STATE,
        INTAKE_STOP_STATE,

        CONVEYOR_IN_STATE,
        CONVERYER_OUT_STATE,
        CONVEYERS_STOP_STATE

        //Add climber states, figure them out
    }

    public class TeleopStateMachine
    {
        public Intake intake;
        public Conveyor conveyor;
        public Climber climber;
        public CTRE.Phoenix.Controller.GameController gamepad;

        public int currentButtonInput;

        public int currentState = (int)States.WAITING_FOR_INPUT_STATE;

        public TeleopStateMachine(Intake intake_, Conveyor conveyor_, Climber climber_, GameController gamepad_)
        {
            intake = intake_;
            conveyor = conveyor_;
            climber = climber_;
            gamepad = gamepad_;
        }

        public void getInputs()
        {
            for (int i = 0; i < 12; i++)
            {
                if (gamepad.GetButton((uint)i))
                {
                    currentButtonInput = i;
                }
            }

            currentState = currentButtonInput;
        }

        public void stateMachine()
        {
            switch (currentState)
            {
                case (int)States.WAITING_FOR_INPUT_STATE:
                    //Do Stuff
                    break;

                case (int)States.INTAKE_IN_STATE:
                    //Do Stuff
                    intake.intakeState = (int)IntakeStates.IN_STATE;
                    break;

                case (int)States.INTAKE_OUT_STATE:
                    //Do Stuff
                    intake.intakeState = (int)IntakeStates.OUT_STATE;
                    break;

                case (int)States.INTAKE_STOP_STATE:
                    //Do Stuff
                    intake.intakeState = (int)IntakeStates.STOP_STATE;
                    break;

                case (int)States.CONVEYOR_IN_STATE:
                    //Do Stuff

                    break;

                case (int)States.CONVERYER_OUT_STATE:
                    //Do Stuff

                    break;

                case (int)States.CONVEYERS_STOP_STATE:
                    //Do Stuff

                    break;

                default:
                    break;
            }
        }
    }
}