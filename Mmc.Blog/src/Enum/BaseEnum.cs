using System.Reflection;

namespace Mmc.Blog.Enum;

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
    public static IEnumerable<T> GetAll<T>() where T : BaseEnum =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
            .Select(f => f.GetValue(null))
            .Cast<T>();
}