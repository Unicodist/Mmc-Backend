namespace Mmc.Notice.BaseType;

public class GuidType
{
    private string Value { get; init; }

    public GuidType()
    {
        Value = Guid.NewGuid().ToString();
    }

    public override string ToString()
    {
        return Value;
    }

    public GuidType(string value)
    {
        Value = value;
    }

    public static implicit operator GuidType(string data)
    {
        return new GuidType(data);
    }
    public static implicit operator string(GuidType data)
    {
        return data.ToString();
    }
}
