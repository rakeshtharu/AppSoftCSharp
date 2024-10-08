public class Dentist : Person, IMedicine
{
    public string Specialization { get; set; }

    public Dentist(string name, int age, string address, string specialization) : base(name, age, address)
    {
      Specialization = specialization;
    }

    // Implement IMedicine methods
    public void PrescribeMedicine()
    {
        Console.WriteLine("Dentist prescribes dental medicine.");
    }

    public void Treat()
    {
        Console.WriteLine("Dentist is treating a dental issue.");
    }

    // Override base class method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Specialization: {Specialization}");
    }
}
