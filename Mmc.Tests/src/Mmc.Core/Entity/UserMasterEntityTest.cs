using Mmc.Core.Enum;
using Mmc.Data.Model.User;
using Mmc.User.Entity;
using Xunit;

namespace Mmc.Tests.Mmc.Core.Entity;

public class UserMasterEntityTest
{
    private const long _id = 5;
    private const string _name = "Ashish Neupane";
    private const string _email = "ashishneupane999@gmail.com";
    private string _password = "MySecret123$%^";
    private UserType _userType = UserType.Admin;
}