using System;

namespace ClassicHeist
{
  public class LockSpecialist : Robber, IRobber
  {
    public void PerformSkill(Bank Bank)
    {
      Bank.AlarmScore = Bank.AlarmScore - SkillLevel;
      Console.WriteLine($"{Name} is trying to crack the vault. Decreased security by {SkillLevel}.");
      if (SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has opened the vault!");
      }
    }
    public LockSpecialist(string name, int skillLevel, int percentageCut)
    {
      Name = name;
      SkillLevel = skillLevel;
      PercentageCut = percentageCut;
    }
  }
}