using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal() {
        // spawn a random animal in a random place
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}