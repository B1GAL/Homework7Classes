﻿using System;

namespace Homework7Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient();
            p1.FirstName = "Alex";
            p1.MidInitial = 'W';
            p1.LastName = "Upton";
            p1.ID = 0;
            p1.FluVaccineYN = false;
            p1.Weights.Add(DateTime.Now, 180.6);
            p1.Weights.Add(DateTime.Now.AddDays(-450), 155);
            p1.Weights.Add(DateTime.Now.AddDays(-780), 190);
            p1.AppointmentHistory.Add("Yearly Checkup");
            p1.AppointmentHistory.Add("Physical");
            Console.WriteLine(p1);
            Console.WriteLine();
            p1.AdministerVaccine();
            Console.WriteLine(p1);

            Patient p2 = new Patient();
            p2.FirstName = "Lane";
            p2.MidInitial = 'M';
            p2.LastName = "Bones";
            p2.ID = 999;
            p2.FluVaccineYN = false;
            p2.Weights.Add(DateTime.Now, 180.6);
            p2.Weights.Add(DateTime.Now.AddDays(-450), 155);
            p2.Weights.Add(DateTime.Now.AddDays(-780), 190);
            p2.AppointmentHistory.Add("Yearly Checkup");
            p2.AppointmentHistory.Add("Physical");
            Console.WriteLine(p2);



        }
    }
}
