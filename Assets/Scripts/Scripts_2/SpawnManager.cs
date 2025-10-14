using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 14;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private Vector3 Y = new Vector3(0, 90, 0);
    
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        // Random Spawn Up
        int animalIndex  = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    
    void SpawnLeftRandomAnimal()
    {
        // Random Spawn Left
        int animalIndex  = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-27, 0, Random.Range(3, 16));
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(Y));   
    }
    
    void SpawnRightRandomAnimal()
    {
        // Random Spawn Right
        int animalIndex  = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(27, 0, Random.Range(3, 16));
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(-Y));   
    }
}