using EMSCA.Application.Interfaces;
// using EMSCA.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace EMSCA.WebAPI.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService vendorService;
        public VendorController(IVendorService _VendorService)
        {
            vendorService = _VendorService;
        }


        [HttpPost("SearchInitialize")]
        public async Task<IActionResult> SearchInitialize(JObject input)
        {
            try
            {
                return Ok(await vendorService.SearchInitialize(input));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("CreateInitialize")]
        public async Task<IActionResult> CreateInitialize(JObject input)
        {
            try
            {
                return Ok(await vendorService.CreateInitialize(input));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] string input, IFormFile accountFiles,IFormFile documentFiles)
        {
            try
            {
                var vendor = JObject.Parse(input);
                return Ok(await vendorService.Create(vendor, accountFiles, documentFiles));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // [HttpPost("Update")]
        // public async Task<IActionResult> Update([FromForm] string input,[FromForm] IFormFile accountFiles,[FromForm] IFormFile documentFiles)
        // {
        //     try
        //     {
        //         var vendor = JObject.Parse(input);
        //         return Ok(await vendorService.Update(vendor,accountFiles,documentFiles));
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(new { message = ex.Message });
        //     }
        // }



        // [HttpPost("Delete")]
        // public async Task<IActionResult> Delete(JObject input)
        // {
        //     try
        //     {
        //         return Ok(await vendorService.Delete(input));
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(new { message = ex.Message });
        //     }
        // }

    }
}
