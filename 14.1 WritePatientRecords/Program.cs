using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.IO;

namespace WritePatientRecords
{
    public class Patient
    {
        public int IdNumber { get; set; }
        public required string Name { get; set; }
        public double BalanceDue { get; set; }
    }

    internal class Program
    {
        //Please create a folder in your documents folder called "testFolder" in order for this program to work"
        readonly static string fileName = $"C:\\Users\\{Environment.UserName}\\Documents\\testFolder\\Patients";

        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nEnter using numbered input:\n" +
                                  "1. Add Patient\n" +
                                  "2. View All Patients\n" +
                                  "3. Search Patients\n" +
                                  "4. Exit\n\n");
                Console.Write(">> ");
                string choice = Convert.ToString(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        ViewAllPatients();
                        break;
                    case "3":
                        SearchPatient();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
                
            }
            Console.WriteLine("Program complete. Please press any key to exit");
            Console.ReadKey();

            
            //I referenced your lecture for using Json's. 
            //This was my first time using Lists.
            //if you'd like me to change anything please let me know thanks!
            
            static void AddPatient()
            {
                Console.Write("Enter patient ID#: >> ");
                int patientId;
                while (!int.TryParse(Console.ReadLine(), out patientId))
                {
                    Console.WriteLine("Invalid ID number.\n");
                    Console.Write("Enter patient ID#: >> ");
                }

                Console.Write("Enter patient name: >> ");
                string patientName = Console.ReadLine();
                while (string.IsNullOrEmpty(patientName))
                {
                    Console.WriteLine("Invalid Name");
                    Console.Write("Enter patient name: >> ");
                    patientName = Console.ReadLine();
                }
                if (string.IsNullOrEmpty(patientName))
                {
                    Console.Write("Invalid name.");
                    Console.Write("Enter patient name: >> ");
                }               
                Console.Write("Enter patient balance due: >> ");
                double balanceDue;
                while (!double.TryParse(Console.ReadLine(), out balanceDue))
                {
                    Console.WriteLine("Balance due must be formatted in whole number. Or value rounded to nearest cent.\n\n");
                    Console.Write("Enter patient balance due: >> ");
                }

                Patient newPatient = new()
                {
                    IdNumber = patientId,
                    Name = patientName,
                    BalanceDue = balanceDue
                };

                var patients = ReadPatient();
                patients.Add(newPatient);
                WritePatient(patients);
            }

            static void WritePatient(List<Patient> patients)
            {
                try
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(patients, options);
                    File.WriteAllText(fileName, jsonString);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static List<Patient> ReadPatient()
            {
                List<Patient> patients = new();

                if (File.Exists(fileName))
                {
                    try
                    {
                        string json = File.ReadAllText(fileName);
                        if (!string.IsNullOrWhiteSpace(json)) ;
                        {
                            patients = JsonSerializer.Deserialize<List<Patient>>(json);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                return patients;
            }

            static void ViewAllPatients()
            {
                foreach (Patient patient in ReadPatient())
                {
                    Console.WriteLine($"\nPatient: {patient.Name}\n" +
                                    $"Id Number: {patient.IdNumber}\n" +
                                  $"Balance Due: {patient.BalanceDue.ToString("c")}\n\n");
                }

            }

            static void ViewPatient(Patient patient)
            {
                Console.WriteLine($"\nPatient: {patient.Name}\n" +
                                    $"Id Number: {patient.IdNumber}\n" +
                                  $"Balance Due: {patient.BalanceDue.ToString("c")}");
            }

            static void SearchPatient()
            {
                Console.Write("Patient name: >> ");
                string search = Convert.ToString(Console.ReadLine().Trim());
                List<Patient> patients = ReadPatient();
                bool match = false;
                foreach (Patient patient in patients)
                {
                    if (patient.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
                    {
                        ViewPatient(patient);
                        match = true;
                    }
                }
                if (!match)
                {
                    Console.WriteLine("\nNo patient records found\n");
                }
            }
        }
    }

    
}
