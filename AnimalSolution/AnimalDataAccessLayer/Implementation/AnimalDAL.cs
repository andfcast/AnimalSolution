using AnimalDataAccessLayer.Interface;
using AnimalEntities.DBEntities;
using AnimalEntities.DTO;

namespace AnimalDataAccessLayer.Implementation
{
    public class AnimalDAL : IAnimalDAL
    {
        private readonly AnimalDbContext _context;
        public AnimalDAL(AnimalDbContext context) { 
            _context = context;
        }
        public List<AnimalDto> GetAll() {
            List<AnimalDto> lstAnimals = new List<AnimalDto>();
            foreach (Animal animal in _context.Animals.ToList()) {
                lstAnimals.Add((AnimalDto)animal);
            }
            return lstAnimals;
        }

        public List<AnimalDto> Search(AnimalDto dto) {
            List<AnimalDto> lstAnimals = GetAll(); 
            if (!string.IsNullOrEmpty(dto.Name)) { 
                lstAnimals = (List<AnimalDto>)lstAnimals.Where(x => x.Name.Contains(dto.Name));
            }
            if (!string.IsNullOrEmpty(dto.Breed))
            {
                lstAnimals = (List<AnimalDto>)lstAnimals.Where(x => x.Breed.Contains(dto.Breed));
            }
            if (dto.Price > 0)
            {
                lstAnimals = (List<AnimalDto>)lstAnimals.Where(x => x.Price == dto.Price);
            }
            if (!string.IsNullOrEmpty(dto.Sex)) {
                lstAnimals = (List<AnimalDto>)lstAnimals.Where(x => x.Sex == dto.Sex);
            }
            return lstAnimals;
        }

        public bool Insert(AnimalDto objAnimal) {
            try
            {
                _context.Animals.Add(objAnimal); ;
                _context.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        public bool Update(List<AnimalDto> lstAnimals) {
            try
            {
                _context.Animals.UpdateRange(lstAnimals); ;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int animalId) {
            var animal = _context.Animals.First(x => x.AnimalId == animalId);
            try
            {
                _context.Animals.Remove(animal);
                _context.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}