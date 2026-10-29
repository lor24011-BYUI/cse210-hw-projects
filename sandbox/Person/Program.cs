using System;

class Program
{
    
    public static void Main()
    {
        Person myPerson = new Person("jhon", "revelator", 50, 100);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "Bone Saw");
        Console.WriteLine(myDoctor.GetPersonInformation());

        Console.WriteLine(myDoctor.GetDoctorInformation());

        Police myPolice = new Police("Gary", "Steven", 80, 350, "Guns");
        Console.WriteLine(myPolice.GetPoliceInformation());
    }
}