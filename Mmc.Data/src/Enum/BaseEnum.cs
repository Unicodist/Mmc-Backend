namespace Mmc.Data.Enum;

public class BaseEnum : IComparable
{
    public BaseEnum(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int CompareTo(object? obj) => Id.CompareTo(((BaseEnum) obj).Id);
}