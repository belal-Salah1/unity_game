using UnityEngine;

public class spawnSystem : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    int randomSpawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0, 1.5f);
    }

    void spawnEnemy(){
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[randomSpawnPoint].position, Quaternion.identity);
    }

}
