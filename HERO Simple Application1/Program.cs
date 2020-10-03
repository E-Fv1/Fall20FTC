using System;
using System.Threading;
using CTRE.Phoenix.MotorControl;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

namespace HERO_Simple_Application1
{
    public class Program
    {


        private int driveTalon1ID = 0;
        private int driveTalon2ID = 0;

        public static void Main()
        {
            //robotInit();
            int driveTalonNeutralMode = 0; // 0 Coast -=- 1 Brake

            CTRE.Phoenix.MotorControl.CAN.TalonSRX driveTalon1 = new CTRE.Phoenix.MotorControl.CAN.TalonSRX(0);
            CTRE.Phoenix.MotorControl.CAN.TalonSRX driveTalon2 = new CTRE.Phoenix.MotorControl.CAN.TalonSRX(0);

            switch (driveTalonNeutralMode)
            {
                case 0:
                    driveTalon1.SetNeutralMode(NeutralMode.Coast);
                    driveTalon2.SetNeutralMode(NeutralMode.Coast);
                    break;
                case 1:
                    driveTalon1.SetNeutralMode(NeutralMode.Brake);
                    driveTalon2.SetNeutralMode(NeutralMode.Brake);
                    break;
                default:
                    break;
            }

            Intake intake = new Intake();
            Conveyor conveyor = new Conveyor();

            /* simple counter to print and watch using the debugger */
            int counter = 0;
            /* loop forever */
            while (true)
            {
                /* print the three analog inputs as three columns */
                Debug.Print("Counter Value: " + counter);

                /* increment counter */
                ++counter; /* try to land a breakpoint here and hover over 'counter' to see it's current value.  Or add it to the Watch Tab */

                /* wait a bit */
                System.Threading.Thread.Sleep(100);

                //TeleopStateMachine.moveRight();
            }
        }

        //private static Array robotInit()
        //{

            
        //    return [intake];
        //}
    }
}
