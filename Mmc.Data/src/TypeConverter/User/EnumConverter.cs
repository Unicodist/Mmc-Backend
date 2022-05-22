using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.User.Enum;

namespace Mmc.Data.TypeConverter;

public class EnumConverter<T> : ValueConverter<T,string> where T:BaseEnum
{
    public EnumConverter():base(e=>e.ToString(),s=>BaseEnum.GetAll<T>().SingleOrDefault(x=>x.ToString()==s)){}
}