namespace Mmc.Blog.BaseType;

public class GuidType
{
    private string Value { get; init; }

    public GuidType()
    {
        Value = new Guid().ToString();
    }

    public override string ToString()
    {
        return Value;
    }

    public GuidType(string value)
    {
        Value = value;
    }

    public static implicit operator string(GuidType x) => x.Value;
}