using System.Reflection;

namespace Mmc.User.Enum;

public class BaseEnum : IComparable
{
    protected BaseEnum(int id, string? value)
    {
        Value = value;
    }

    private int Id { get; set; }
    public string Value { get; set; }

    public string ToString()
    {
        return Value;
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<T> GetAll<T>() where T : BaseEnum =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
            .Select(f => f.GetValue(null))
            .Cast<T>();
}