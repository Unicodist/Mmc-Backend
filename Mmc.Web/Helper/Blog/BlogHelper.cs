namespace Mechi.Backend.Helper.Blog;

public class BlogHelper
{
    public static async Task<string> UploadFile(IFormFile? file, IWebHostEnvironment webHostEnvironment)
    {
        var filePath = "/Assets/Thumbnail/first.jpg";
        if (file is not {Length: > 0}) return filePath;
        var root = Directory.GetCurrentDirectory();
        filePath = Path.Combine(root,"wwwroot/Assets/Notices",file.FileName);
        await using var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);

        return filePath;
    }
}
