using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private float secondsPerSpawn;
    [SerializeField] private GameObject enemy;
    private float lastSpawnTime;
    [SerializeField] private Transform spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        secondsPerSpawn -= (0.05f * Time.deltaTime);
        if(Time.time - lastSpawnTime >= secondsPerSpawn && FPSPlayer.instance.ShouldSpawn(spawnLocation.position))
        {
            lastSpawnTime = Time.time;
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject enemyPrefab = enemy;
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;

    }
}
