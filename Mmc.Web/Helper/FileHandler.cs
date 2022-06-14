namespace Mechi.Backend.Helper;

public class FileHandler
{
    public static async Task<string> UploadFile(IFormFile? file)
    {
        var filePath = string.Empty;
        if (file is not {Length: > 0}) return filePath;
        filePath = Path.Combine(Directory.GetCurrentDirectory(), "/Images/", file.FileName);
        await using var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);

        return filePath;
    }
}