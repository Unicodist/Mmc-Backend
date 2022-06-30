using Mmc.Blog.BaseType;

namespace Mechi.Backend.Helper.Blog;

public class BlogHelper
{
    public static async Task<string> UploadFile(IFormFile? file, IWebHostEnvironment webHostEnvironment)
    {
        var filePath = "/Assets/Thumbnail/first.jpg";
        if (file is not {Length: > 0}) return filePath;

        var relative = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        string guid = Guid.NewGuid().ToString();
        var physical = Path.Combine("Assets/Thumbnail",$"{guid}{Path.GetExtension(file.FileName)}");
        filePath = Path.Combine(relative, physical);
        var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);
        return physical;
    }
}
