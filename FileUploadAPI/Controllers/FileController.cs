using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
  
        
        [HttpPost("upload-curriculos")]
        public async Task<IActionResult> UploadArquivos([FromForm] ICollection<IFormFile> files)
        {
            if (files == null || files.Count == 0) 
                return BadRequest("Nenhum arquivo foi enviado");

            List<byte[]> data = new List<byte[]>();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using(var stream = new MemoryStream())
                    {
                        await formFile.CopyToAsync(stream);
                        data.Add(stream.ToArray());
                    }
                }
            }
            return File(data[0], files.FirstOrDefault().ContentType, "Curriculos.pdf");
        }

       

    
    }
}
