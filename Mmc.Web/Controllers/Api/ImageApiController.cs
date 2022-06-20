using Mechi.Backend.Helper;
using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers.Api;

public class ImageApiController : ControllerBase
{
    public async Task<IActionResult> UploadImage(IFormFile image)
    {
        var filename = await FileHandler.UploadFile(image);
        return Ok(new {Name=filename});
    }
}