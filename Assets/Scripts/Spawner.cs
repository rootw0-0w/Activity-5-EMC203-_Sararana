using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform[] spawnPoints;
    public float spawnInterval = 3f;

    float timer = 0f;
    float survivalTime = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        survivalTime += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnWave();
        }
    }

    void SpawnWave()
    {
        int count = 1 + (int)(survivalTime / 10f); //count increases spawned enemies at every 10 seconds

        for (int i = 0; i < count; i++)
        {
            Transform sp = spawnPoints[i];
            Instantiate(missilePrefab, sp.position, Quaternion.identity);
        }
    }    
}
