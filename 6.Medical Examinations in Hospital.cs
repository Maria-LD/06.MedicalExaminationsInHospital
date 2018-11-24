using System;
namespace MedicalExaminationsInHospital
{
    class MedicalExaminationsInHospital
    {
        public static void Main(string[] args)
        {
            try
            {
                //first input and checking if it's valid
                Console.Write("Enter the period you want to make calculations for: ");
                int period = int.Parse(Console.ReadLine());
                while (period < 1 || period > 1000)
                {
                    Console.Write("Invalid input! Period must be in range 1 - 1000 days: ");
                    period = int.Parse(Console.ReadLine());
                }

                int treatedPatients = 0;
                int untreatedPatients = 0;
                int numberOfDoctors = 7;

                for (int day = 1; day <= period; day++)
                {

                    //second input and checking if it's valid
                    Console.Write($"Enter number of patients for day {day}: ");
                    int currentPatients = int.Parse(Console.ReadLine());
                    while (currentPatients < 0 || currentPatients > 10000)
                    {
                        Console.Write("Invalid input! Patients must be between 0 and 10000: ");
                        currentPatients = int.Parse(Console.ReadLine());
                    }

                    if (day % 3 == 0 && (untreatedPatients > treatedPatients))
                    {
                        numberOfDoctors++;
                    }

                    if (currentPatients > numberOfDoctors)
                    {
                        treatedPatients += numberOfDoctors;
                        untreatedPatients += currentPatients - numberOfDoctors;
                    }
                    else
                    {
                        treatedPatients += currentPatients;
                    }
                }

                Console.Write($"Treated patients: {treatedPatients}.\n");
                Console.Write($"Untreated patients: {untreatedPatients}.\n");

            }
            catch
            {
                Console.Write("Invalid input! Start from the beginning!!!");
            }
        }
    }
}