using System.Reflection;

namespace Mmc.Core.Enums;

public class BaseEnum : IComparable
{
    public BaseEnum(int id, string name)
    {
        Id = id;
        Name = name;
    }

    protected int Id { get; set; }
    protected string Name { get; set; }
    public string ToString() => Name;
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