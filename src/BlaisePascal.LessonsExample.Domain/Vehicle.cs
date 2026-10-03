using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonsExample.Domain
{
    public class Vehicle
    {
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        public int OdometerKm{ get; private set; }

        public double DailyRate { get; private set; }    

        public string LicensePlate { get; private set; }

        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate; //chiamata al private set
        }

        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelPercentage)
        {

        }


    }
}
