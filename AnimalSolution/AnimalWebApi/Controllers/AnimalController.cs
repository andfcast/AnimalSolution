using AnimalBusinessLogic.Interface;
using AnimalEntities.DBEntities;
using AnimalEntities.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalBL _animalBL;

        public AnimalController(IAnimalBL animalBL)
        {
            _animalBL = animalBL;
        }


        // GET: api/<AnimalController>
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<AnimalDto> Get()
        {
            return _animalBL.GetAll();
        }

        [HttpGet]
        [Route("Search")]
        public IEnumerable<AnimalDto> Search([FromBody]AnimalDto dto)
        {
            return _animalBL.Search(dto);
        }        
       
        // POST api/<AnimalController>
        [HttpPost]
        [Route("CreateNew")]
        public void CreateNew([FromBody] AnimalDto objAnimal)
        {
            _animalBL.Insert(objAnimal);
        }

        // PUT api/<AnimalController>/5
        //[HttpPut("{id}")]
        [HttpPut]
        [Route("Update")]
        public void Update([FromBody] List<AnimalDto> lstAnimals)
        {
            _animalBL.Update(lstAnimals);
        }

        // DELETE api/<AnimalController>/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _animalBL.Delete(id);
        }
    }
}
