using System;
using System.Collections.Generic;

namespace ClassicHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Hacker Barry = new Hacker("Barry", 50, 10);
      LockSpecialist Christina = new LockSpecialist("Christina", 50, 17);
      Muscle Christine = new Muscle("Christine", 75, 15);
      Hacker Christopher = new Hacker("Christopher", 25, 10);
      LockSpecialist Joshua = new LockSpecialist("Joshua", 75, 20);
      Muscle Pazia = new Muscle("Pazia", 100, 25);
      Hacker Rickie = new Hacker("Rickie", 75, 25);
      LockSpecialist Ryan = new LockSpecialist("Ryan", 25, 15);

      List<IRobber> rolodex = new List<IRobber>()
      {
        Barry,
        Christina,
        Christine,
        Christopher,
        Joshua,
        Pazia,
        Rickie,
        Ryan
      };
      Console.WriteLine($"There are currently {rolodex.Count} associates in the Rolodex.");
      Console.WriteLine("");
      string Name = Console.ReadLine();
      Console.WriteLine("");
      string Specialty = Console.ReadLine();
      Console.WriteLine("");
      string SkillInput = Console.ReadLine();
      int SkillLevel = int.Parse(SkillInput);
      Console.WriteLine("");
      string Cut = Console.ReadLine();
      Console.WriteLine("");
    }
  }
}
