using System;

namespace ClassicHeist
{
  public class Muscle : Robber, IRobber
  {
    public void PerformSkill(Bank Bank)
    {
      Bank.AlarmScore = Bank.AlarmScore - SkillLevel;
      Console.WriteLine($"{Name} is Throwing down with the Security Guards. Decreased security by {SkillLevel}.");
      if (SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has taken out the Security Guards!");
      }
    }
    public Muscle(string name, int skillLevel, int percentageCut)
    {
      Name = name;
      SkillLevel = skillLevel;
      PercentageCut = percentageCut;
    }
  }
}