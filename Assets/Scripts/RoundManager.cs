using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public static RoundManager Instance { get; private set; }

    [Header("Settings")]
    [SerializeField] private int actionPoints;
    [SerializeField] private int maxStress;

    [Header("Current Status")]
    [SerializeField] private int currentStress;
    [SerializeField] private AnimalData currentAnimal;

    [Header("Database")]
    [SerializeField] private List<AnimalData> animalList;

    public AnimalData CurrentAnimal => currentAnimal; //read only

    void Awake()
    {
        if(Instance == null) Instance = this;
        else Destroy(Instance);
    }

    void Start()
    {
        currentStress = 0;
        RandomAnimal();
    }

    void RandomAnimal()
    {
        if (animalList != null && animalList.Count > 0)
        {
            int randomIndex = Random.Range(0, animalList.Count);
            currentAnimal = animalList[randomIndex];

            //Debug.Log($"The animal is: {currentAnimal.AnimalName}, Species: {currentAnimal.Species}, Temperament: {currentAnimal.Temperament}, Weight: {currentAnimal.Weight} ");
        }
    }

    void ExecuteAction(ActionData action)
    {

    }
}
