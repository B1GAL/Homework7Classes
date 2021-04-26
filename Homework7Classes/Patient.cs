using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Classes
{
    public class Patient
    {
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime, double> Weights { get; set; }
        public List<string> AppointmentHistory { get; set; }

        public Patient()
        {
            FirstName = string.Empty;
            MidInitial = '\0';
            LastName  = string.Empty;
            ID  = 0;
            FluVaccineYN  = false;
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
        }

        public Patient(int patID)
        {
            FirstName = string.Empty;
            MidInitial = '\0';
            LastName = string.Empty;
            ID = 0;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
        }

        public Patient(string firstName, char midInit, string lastName)
        {
            FirstName = firstName;
            MidInitial = midInit;
            LastName = lastName;
            ID = 0;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
        }

        public override string ToString()
        {
            string output = $"{LastName}, {FirstName} {MidInitial}. ({ID}) Flu Vaccine: ";

            if (FluVaccineYN)
            {
                output += "Yes";
            }
            else
            {
                output += "No";
            }

            return output;
        }

        public double CalculateMaxWeight()
        {
            double maxWeight = -50;

            foreach (double weight in Weights.Values)
            {
                if (maxWeight < weight)
                {
                    maxWeight = weight;
                }
            }

            return maxWeight;
        }

        public void DisplayApptHist()
        {
            foreach (string appointment in AppointmentHistory)
            {
                Console.WriteLine(appointment);
            }
        }

        public void AdministerVaccine()
        {
            if (FluVaccineYN)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Patient has already been administered the vaccine.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patient has been administered vaccine.");
                FluVaccineYN = true;
            }











        }   




    }
}
