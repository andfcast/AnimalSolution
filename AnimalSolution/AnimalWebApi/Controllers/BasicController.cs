using AnimalEntities.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        // GET: api/<BasicController>
        [HttpGet]
        [Route("GetGenders")]
        public IEnumerable<BasicDto> GetGenders()
        {
            return new List<BasicDto>
            {
                new BasicDto {
                    Id = "F",
                    Name = "Female"

                },
                new BasicDto
                {
                    Id = "M",
                    Name = "Male"

                },

            };
        }
    }
}
