namespace Mmc.Data.Helper;

public static class EntityConversionHelper
{
    public static T Convert<T>(this object source) where T:class, new()
    { 
        var properties = source.GetType().GetProperties();
        var result = new T();
        var newProperties = typeof(T).GetProperties();
        foreach (var item in newProperties)
        {
            properties.FirstOrDefault(x=>x.Name==item.Name)!.SetValue(result,item.GetValue(source));
        }
        return result;
    }
}