using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    public GameObject zombiePrefab;
    public Transform SpawnPosition;
    int enemyPerRound = 5;
    int enemyCount;
    int round;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount < enemyPerRound) {
                SpawnZombies();
        }
    }

    public void SpawnZombies()
    {
        GameObject zombie = Instantiate(zombiePrefab , SpawnPosition);
        enemyCount++;
        
    }
}
