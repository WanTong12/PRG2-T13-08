﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_T13_08
{
    class LWTTFlight : Flight
    {
        public double RequestFee {  get; set; }

        public LWTTFlight():base() 
        {
            RequestFee = 500;
        }

        public LWTTFlight(double r, string fn, string o, string d, DateTime e, string s) : base(fn, o, d, e, s)
        {
            RequestFee = r;
        }

        public override double CalculateFees()
        {
            double basefee = 300;
            if (Origin == "Singapore")
            {
                return 800 + basefee + RequestFee;
            }
            else
            {
                return 500 + basefee + RequestFee;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\tRequest Fee: " + RequestFee;
        }
    }
}
