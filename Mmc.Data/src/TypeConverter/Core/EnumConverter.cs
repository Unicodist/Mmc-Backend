using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.Core.Enum;

namespace Mmc.Data.TypeConverter.Core;

public class EnumConverter<T> : ValueConverter<T,string> where T:BaseEnum
{
    public EnumConverter():base(e=>e.ToString(),s=>BaseEnum.GetAll<T>().SingleOrDefault(x=>x.ToString()==s)){}
}
