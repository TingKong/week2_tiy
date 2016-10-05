﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Sky
    {
        private bool clouds = true;
        private bool aliens;
        private int flyingCars;
        private int airplanes;
        private int flyingNakedHumans;

        public Sky(int initialFlyingNakedHumans)
        {
            flyingNakedHumans = initialFlyingNakedHumans;
        }

        public Sky(int initialAirPlanes, int initialFlyingCars)
        {
            Airplanes = initialAirPlanes;
            FlyingCars = initialFlyingCars;
        }

        public bool Clouds

        {
            get
            {
                return clouds;
            }
           
        }

        public bool Aliens

        {
            get
            {
                return aliens;
            }
            set
            {
                aliens = value;
            }
        }

        public int FlyingCars
        {
            get
            {
                return flyingCars;
            }

            set
            {
                if (value < 1)
                {
                    flyingCars = 1;
                }
                else
                {
                    flyingCars = value;
                }
            }
        }

        public int Airplanes
        {
            get
            {
                return airplanes;
            }

            set
            {
                if (value < 1)
                {
                    airplanes = 1;
                }
                else
                {
                    airplanes = value;
                }
            }
        }
        public int FlyingNakedHumans
        {
            get
            {
                return flyingNakedHumans;
            }

            set
            {
                if (value < 1)
                {
                    flyingNakedHumans = 1;
                }
                else
                {
                    flyingNakedHumans = value;
                }
            }
        }


    }
}
