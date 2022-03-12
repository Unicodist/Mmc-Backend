using Mmc.Blog.ViewModel;

namespace Mmc.Core.Entity;

public class UserCredentials
{
    public int UserCredentialsId { get; set; }
    public string UserCredentialsEmail { get; set; } = null!;
    public string UserCredentialsPassword { get; private set; } = null!;
    
    public virtual long UserCredentialsUserId { get; set; }

    public virtual UserMaster UserCredentialsUser { get; set; } = null!;

    public void SetPassword(string password)
    {
        UserCredentialsPassword = password;
    }
    public bool MatchCredentials(UserCredentialsViewModel model)
    {
        return UserCredentialsEmail.Equals(model.Email) && UserCredentialsPassword.Equals(model.Password);
    }
}