using CTRE.Phoenix.Controller;
using CTRE.Phoenix.MotorControl;
using CTRE.Phoenix.MotorControl.CAN;

namespace HERO_Simple_Application1
{
    public class Drive
    {
        private TalonSRX leftTalon;
        private TalonSRX rightTalon;
        private GameController controller;

        private int rightXAxis = 2;
        private int rightYAxis = 5;

        private double xAxisDeadzone = 0.25;
        private double yAxisDeadzone = 0.05;
        private double appliedRightPercent = 0.0;
        private double appliedLeftPercent = 0.0;
        private double rightMultiplier = 1.0;
        private double leftMultiplier = 1.0;

        private bool isTurning = false;
        private bool isFowardBack = true;

        public bool isCoast = true;
        public bool basicControl = true;

        public Drive(TalonSRX leftTalon_, TalonSRX rightTalon_, GameController controller_)
        {
            leftTalon = leftTalon_;
            rightTalon = rightTalon_;
            controller = controller_;
            initMotors();
        }

        private void initMotors()
        {
            leftTalon.ConfigFactoryDefault();
            rightTalon.ConfigFactoryDefault();

            switch (isCoast)
            {
                case true:
                    leftTalon.SetNeutralMode(NeutralMode.Coast);
                    rightTalon.SetNeutralMode(NeutralMode.Coast);
                    break;

                case false:
                    leftTalon.SetNeutralMode(NeutralMode.Brake);
                    rightTalon.SetNeutralMode(NeutralMode.Brake);
                    break;

                default:
                    break;
            }
        }

        public void motorControl()
        {
        }

        private void pidControl()
        {
            //IF I HAD ENCODERS LOL HAHAHAHAHHAHAHAHHAH
        }

        private void simpleControls()
        {
            updateTurning();
            if (isTurning)
            {
                appliedLeftPercent += controller.GetAxis((uint)rightXAxis) * leftMultiplier;
                appliedRightPercent += controller.GetAxis((uint)rightXAxis) * rightMultiplier;
            }

            if (isFowardBack)
            {
                appliedLeftPercent += controller.GetAxis((uint)rightYAxis);
                appliedRightPercent += controller.GetAxis((uint)rightYAxis);
            }
        }

        private void updateTurning()
        {
            if (Abs(controller.GetAxis((uint)rightXAxis)) >= xAxisDeadzone)
            {
                isTurning = true;
            }
            else
            {
                isTurning = false;
            }

            if (Abs(controller.GetAxis((uint)rightYAxis)) >= yAxisDeadzone)
            {
                isFowardBack = true;
            }
            else
            {
                isFowardBack = false;
            }
        }

        //private void reducePercentages() //Shouldn't even need, and if you do just reduce to 1.0
        //{
        //    while(appliedLeftPercent > 1 || appliedRightPercent > 1)
        //    {
        //        appliedLeftPercent -= 0.01;
        //        appliedRightPercent -= 0.01;
        //    }
        //}

        public double Abs(double inputValue)
        {
            double result = inputValue;
            if (inputValue < 0)
            {
                result *= -1;
            }
            return result;
        }
    }
}