using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            // spawn a random animal in a random place
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
