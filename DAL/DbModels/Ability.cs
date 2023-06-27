namespace DAL.DbModels;

public class Ability
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Cooldown { get; set; }
}