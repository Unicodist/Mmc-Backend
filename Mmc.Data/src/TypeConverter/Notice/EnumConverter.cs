using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.Notice.Enum;

namespace Mmc.Data.TypeConverter.Notice;

public class EnumConverter<T> : ValueConverter<T,string> where T:BaseEnum
{
    public EnumConverter():base(e=>e.ToString(),s=>BaseEnum.GetAll<T>().SingleOrDefault(x=>x.ToString()==s)){}
}