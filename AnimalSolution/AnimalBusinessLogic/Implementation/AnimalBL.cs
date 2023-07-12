using AnimalBusinessLogic.Interface;
using AnimalDataAccessLayer.Interface;
using AnimalEntities.DBEntities;
using AnimalEntities.DTO;

namespace AnimalBusinessLogic.Implementation
{
    public class AnimalBL : IAnimalBL
    {
        private readonly IAnimalDAL _animalDAL;

        public AnimalBL(IAnimalDAL animalDAL)
        {
            _animalDAL = animalDAL;
        }

        public List<AnimalDto> GetAll() { 
            return _animalDAL.GetAll(); ;
        }

        public List<AnimalDto> Search(AnimalDto dto) { 
            return _animalDAL.Search(dto);
        }

        public bool Insert(AnimalDto objAnimal) {
            return _animalDAL.Insert(objAnimal);
        }
        public bool Update(List<AnimalDto> lstAnimals) {
            return _animalDAL.Update(lstAnimals);
        }
        public bool Delete(int animalId) {
            return _animalDAL.Delete(animalId);
        }
    }
}