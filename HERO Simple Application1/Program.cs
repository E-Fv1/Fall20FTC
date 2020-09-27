﻿using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

namespace HERO_Simple_Application1
{
    public class Program
    {
        public static void Main()
        {
            //robotInit();

            Intake intake = new Intake();

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
