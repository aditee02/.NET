using System;

class MedicalBot
{
    public const string BotName = "Bob";

    public static string GetBotName()
    {
        return BotName;
    }

    public static void PrescribeMedication(Patient patient)
    {
        string prescription = "";
        switch (patient.GetSymptoms().ToLower())
        {
            case "headache":
                prescription = "ibuprofen " + GetDosage("ibuprofen", patient.GetAge());
                break;
            case "skin rashes":
                prescription = "diphenhydramine " + GetDosage("diphenhydramine", patient.GetAge());
                break;
            case "dizziness":
                prescription = patient.GetMedicalHistory().ToLower().Contains("diabetes") ?
                              "metformin 500 mg" : "dimenhydrinate " + GetDosage("dimenhydrinate", patient.GetAge());
                break;
            default:
                prescription = "Unknown symptoms, please consult a doctor.";
                break;
        }

        patient.SetPrescription(prescription);
    }

    private static string GetDosage(string medicineName, int age)
    {
        switch (medicineName.ToLower())
        {
            case "ibuprofen":
                return age < 18 ? "400 mg" : "800 mg";
            case "diphenhydramine":
                return age < 18 ? "50 mg" : "300 mg";
            case "dimenhydrinate":
                return age < 18 ? "50 mg" : "400 mg";
            default:
                return "500 mg";
        }
    }
}

class Patient
{
    private string name;
    private int age;
    private string gender;
    private string medicalHistory;
    private string symptomCode;
    private string prescription;

    public string GetName() { return name; }

    public bool SetName(string name, out string errorMessage)
    {
        if (!string.IsNullOrEmpty(name) && name.Length >= 2)
        {
            this.name = name;
            errorMessage = "";
            return true;
        }
        else
        {
            errorMessage = "Name should contain at least two or more characters.";
            return false;
        }
    }

    public int GetAge() { return age; }

    public bool SetAge(int age, out string errorMessage)
    {
        if (age >= 0 && age <= 100)
        {
            this.age = age;
            errorMessage = "";
            return true;
        }
        else
        {
            errorMessage = "Age should be between 0 and 100.";
            return false;
        }
    }

    public string GetGender() { return gender; }

    public bool SetGender(string gender, out string errorMessage)
    {
        if (gender.ToLower() == "male" || gender.ToLower() == "female" || gender.ToLower() == "other")
        {
            this.gender = gender;
            errorMessage = "";
            return true;
        }
        else
        {
            errorMessage = "Gender should be either Male, Female or Other.";
            return false;
        }
    }

    public string GetMedicalHistory() { return medicalHistory; }

    public void SetMedicalHistory(string medicalHistory)
    {
        this.medicalHistory = medicalHistory;
    }

    public bool SetSymptomCode(string symptomCode, out string errorMessage)
    {
        if (symptomCode.ToLower() == "s1" || symptomCode.ToLower() == "s2" || symptomCode.ToLower() == "s3")
        {
            this.symptomCode = symptomCode;
            errorMessage = "";
            return true;
        }
        else
        {
            errorMessage = "Symptom Code should be S1, S2, or S3.";
            return false;
        }
    }

    public string GetSymptoms()
    {
        switch (symptomCode.ToLower())
        {
            case "s1":
                return "Headache";
            case "s2":
                return "Skin rashes";
            case "s3":
                return "Dizziness";
            default:
                return "Unknown";
        }
    }

    public string GetPrescription() { return prescription; }

    public void SetPrescription(string prescription)
    {
        this.prescription = prescription;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, I'm " + MedicalBot.GetBotName() + ". I'm here to help you in your medication.");
        Console.WriteLine("Enter your (patient) details:");

        Patient patient = new Patient();

        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();
        string errorMessage;
        while (!patient.SetName(name, out errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter Patient Name: ");
            name = Console.ReadLine();
        }

        Console.Write("Enter Patient Age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || !patient.SetAge(age, out errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter Patient Age: ");
        }

        Console.Write("Enter Patient Gender: ");
        string gender = Console.ReadLine();
        while (!patient.SetGender(gender, out errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter Patient Gender: ");
            gender = Console.ReadLine();
        }

        Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None: ");
        string medicalHistory = Console.ReadLine();
        patient.SetMedicalHistory(medicalHistory);

        Console.WriteLine($"\nWelcome, {patient.GetName()}, {patient.GetAge()}.");

        Console.WriteLine("Which of the following symptoms do you have:");
        Console.WriteLine("S1. Headache");
        Console.WriteLine("S2. Skin rashes");
        Console.WriteLine("S3. Dizziness");
        Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
        string symptomCode = Console.ReadLine();
        while (!patient.SetSymptomCode(symptomCode, out errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
            symptomCode = Console.ReadLine();
        }

        MedicalBot.PrescribeMedication(patient);

        Console.WriteLine("\nYour prescription based on your age, symptoms and medical history:\n" + patient.GetPrescription());
        Console.WriteLine("\nThank you for coming.");
        Console.ReadKey();
    }
}


