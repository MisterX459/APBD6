namespace WebApplication6;


public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimal(string? orderBy);
    void AddAnimal(AddAnimalRequest animal);
    void UpdateAnimal(int idAnimal, UpdateAnimalRequest animal);
    void DeleteAnimal(int idAnimal);
}