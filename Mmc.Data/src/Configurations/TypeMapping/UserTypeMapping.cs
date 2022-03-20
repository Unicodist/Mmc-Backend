using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmc.Core.Enum;

namespace Mmc.Data.Configurations.TypeMapping;

public class UserTypeMapping : ValueConverter<UserType,string>
{
    public UserTypeMapping():base(
            v=>v.ToString(),
            v=>BaseEnum.GetAll<UserType>().SingleOrDefault(x=>x.ToString().Equals(v))
        ){}
}