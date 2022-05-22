using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.User.Enum;

namespace Mmc.Data.TypeConverter;

public class UserTypeConverter : ValueConverter<UserType,string>
{
    public UserTypeConverter():base(u=>u.ToString(),s=>BaseEnum.GetAll<UserType>().SingleOrDefault(x=>x.ToString()==s)){}
}