using Mmc.Core.Enum;
using Mmc.User.Entity;
using Xunit;

namespace Mmc.Tests.Mmc.Core.Entity;

public class UserMasterEntityTest
{
    private const long _id = 5;
    private const string _name = "Ashish Neupane";
    private const string _email = "ashishneupane999@gmail.com";
    private string _password = "MySecret123$%^";
    private UserType _userType = UserType.ADMIN;

    [Fact]
    public void Test_ProvidedData_Constructor_CreatesUserWithCorrectValues()
    {
        UserMasterEntity userMasterEntity = new()
        {
            UserMasterName = _name,
            Email = _email,
            Password = _password,
            UserMasterId = _id,
            UserType = _userType
        };
        Assert.Equal(userMasterEntity.UserMasterName,_name);
        Assert.Equal(userMasterEntity.UserMasterId,_id);
        Assert.Equal(userMasterEntity.Email,_email);
        Assert.Equal(userMasterEntity.Password,_password);
        Assert.Equal(userMasterEntity.UserType,_userType);
    }
}