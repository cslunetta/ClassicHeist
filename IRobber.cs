namespace ClassicHeist
{
  public interface IRobber
  {
    string Name { get; set; }
    int SkillLevel { get; set; }
    int PercentageCut { get; set; }

    //method
    void PerformSkill(Bank Bank);
  }
}