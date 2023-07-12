using AnimalEntities.DBEntities;
using AnimalEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBusinessLogic.Interface
{
    public interface IAnimalBL
    {
        List<AnimalDto> GetAll();
        List<AnimalDto> Search(AnimalDto dto);
        bool Insert(AnimalDto objAnimal);
        bool Update(List<AnimalDto> lstAnimals);
        bool Delete(int animalId);
    }
}
