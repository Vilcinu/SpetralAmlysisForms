﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpetralAmlysisForms
{
    public class knobs
    {
        public int positionX;
        int positionY;
        double property1;
        double property2;
        String knobname = "knob";

        public void XY(int input1,int input2)
        {
            //set position
            positionX = input1;
            positionY = input2;
        }

        public int X()
        {
            return positionX;
        }
        public int Y()
        {
            return positionY;
        }

        public void prop1(double input)
        {
            property1 = input;
        }

        public void prop2(double input)
        {
            property2 = input;
        }

        public void setname(String input)
        {
            //set name
            knobname = input;
        }
        public String name()
        {
            return knobname;
        }
    }
}
