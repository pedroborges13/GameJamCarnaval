using UnityEngine;

//All animals
public enum Species { Cat, Dog, Snake}
public enum Age { Baby, Adult }
public enum Temperament { Docile, Restless, Agressive, Scared } //Cats and Dogs
//public enum Weight { Light, Medium, Heavy}

//Specific to cats
public enum CatColor { Orange, Black, Hairless}

//Specific to dogs
public enum DogBreed { Caramelo, Pinscher, Golden}

//Specific to snakes
public enum SnakeType { Coral, Cascavel}

public abstract class AnimalData : ScriptableObject
{
    [Header("Identity")]
    [SerializeField] private string animalName;
    [SerializeField] private Species species;
    [SerializeField] private Age age;

    public string AnimalName => animalName;
    public Species Species => species;
    public Age Age => age;  
}

[CreateAssetMenu(fileName = "NewCat", menuName = "Animal/CatData")]
public class CatData : AnimalData
{
    [Header("Cat Specifics")]
    [SerializeField] private CatColor catColor;
    [SerializeField] private Temperament temperament;

    public CatColor CatColor => catColor;
    public Temperament Temperament => temperament;
}

[CreateAssetMenu(fileName = "NewDog", menuName = "Animal/DogData")]
public class DogData : AnimalData
{
    [Header("Dog Specifics")]
    [SerializeField] private DogBreed dogBreed;
    [SerializeField] private Temperament temperament;

    public DogBreed DogBreed => dogBreed;
    public Temperament Temperament => temperament;
}

[CreateAssetMenu(fileName = "NewSnake", menuName = "Animal/SnakeData")]
public class SnakeData : AnimalData
{
    [Header("Snake Specifics")]
    [SerializeField] private SnakeType snakeType;
    [SerializeField] private bool isPoisonous;

    public SnakeType SnakeType => snakeType;
    public bool IsPoisonous => isPoisonous;
}


