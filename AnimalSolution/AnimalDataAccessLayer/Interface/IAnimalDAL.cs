using AnimalEntities.DBEntities;
using AnimalEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDataAccessLayer.Interface
{
    public interface IAnimalDAL
    {
        List<AnimalDto> GetAll();
        List<AnimalDto> Search(AnimalDto dto);
        bool Insert(AnimalDto objAnimal);
        bool Update(List<AnimalDto> lstAnimals);
        bool Delete(int animalId);
    }
}
