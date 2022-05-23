using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.Blog.Enum;

namespace Mmc.Data.TypeConverter.Blog;

public class EnumConverter<T> : ValueConverter<T,string> where T:BaseEnum
{
    public EnumConverter():base(e=>e.ToString(),s=>BaseEnum.GetAll<T>().SingleOrDefault(x=>x.ToString()==s)){}
}