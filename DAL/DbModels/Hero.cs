namespace DAL.DbModels;

public class Hero
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Ability Abilities { get; set; }
}