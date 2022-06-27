using System.Reflection;

namespace Mmc.Core.Enum;

public class BaseEnum : IComparable
{
    public BaseEnum(int id, string value)
    {
        Id = id;
        Value = value;
    }

    protected int Id { get; set; }
    protected string Value { get; set; }
    public string ToString() => Value;
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
    
    public static IEnumerable<T> GetAll<T>() where T : BaseEnum
    {
        return typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
            .Select(f => f.GetValue(null))
            .Cast<T>();
    }
}
