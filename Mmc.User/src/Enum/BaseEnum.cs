namespace Mmc.User.Enum;

public class BaseEnum
{
    protected BaseEnum(int id, string? value)
    {
        Id = id;
        Value = value;
    }

    public int Id { get; set; }
    public string Value { get; set; }

    public string ToString()
    {
        return Value;
    }
}