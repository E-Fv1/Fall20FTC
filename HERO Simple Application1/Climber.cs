namespace HERO_Simple_Application1
{
    public enum ClimberStates
    {
        STOP_STATE
    }

    public class Climber
    {
        private int climberState = (int)ClimberStates.STOP_STATE;

        public Climber()
        {
        }

        public void stateMachine()
        {
            switch (climberState)
            {
                case (int)ClimberStates.STOP_STATE:
                    Stop();
                    break;

                default:
                    break;
            }
        }

        public void Stop()
        {
        }
    }
}