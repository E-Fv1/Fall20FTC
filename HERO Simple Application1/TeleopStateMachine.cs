﻿using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

namespace HERO_Simple_Application1
{

    public enum States
    {
        WAITING_FOR_INPUT_STATE,

        INTAKE_IN_STATE,
        INTAKE_BACK_STATE,
        INTAKE_OFF_STATE,

        CONVEYOR_IN_STATE,
        CONVERYER_OUT_STATE,
        CONVEYER_OFF_STATE

        //Add climber states, figure them out
    }

    public class TeleopStateMachine
    {

        

        public static int currentState = (int) States.WAITING_FOR_INPUT_STATE;

        public static void getInputs()
        {

        }

        public static void stateMachine()
        {
            switch (currentState)
            {
                case (int) States.WAITING_FOR_INPUT_STATE:
                    //Do Stuff
                    break;
                case (int) States.INTAKE_IN_STATE:
                    //Do Stuff
                    
                    break;
                case (int) States.INTAKE_BACK_STATE:
                    //Do Stuff

                    break;
                case (int) States.INTAKE_OFF_STATE:
                    //Do Stuff

                    break;
                case (int) States.CONVEYOR_IN_STATE:
                    //Do Stuff

                    break;
                case (int) States.CONVERYER_OUT_STATE:
                    //Do Stuff

                    break;
                case (int) States.CONVEYER_OFF_STATE:
                    //Do Stuff

                    break;
                default:
                    break;
            }
        }
    }
}