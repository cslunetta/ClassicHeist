using System;

namespace ClassicHeist
{
  public class Hacker : Robber, IRobber
  {
    public void PerformSkill(Bank Bank)
    {
      Bank.AlarmScore = Bank.AlarmScore - SkillLevel;
      Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel}.");
      if (SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has disabled the alarm System!");
      }
    }
    public Hacker(string name, int skillLevel, int percentageCut)
    {
      Name = name;
      SkillLevel = skillLevel;
      PercentageCut = percentageCut;
    }
  }
}