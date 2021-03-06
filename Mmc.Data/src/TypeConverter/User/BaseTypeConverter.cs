using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mmc.Data.TypeConverter.User;

public class BaseTypeStringConverter<T> : ValueConverter<T,string>
{
    public BaseTypeStringConverter():base(t=>t.ToString(),s=>(T)Activator.CreateInstance(typeof(T),s)){}
}