using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float SpawnRange = 9;
    void Start()
    {
        Instantiate(enemyPrefabs, GenerateSpawnPosition(), enemyPrefabs.transform.rotation);
    }
         private Vector3 GenerateSpawnPosition()
         {
            float spawnPosX = Random.Range(-SpawnRange,SpawnRange);
            float spawnPosZ = Random.Range(-SpawnRange,SpawnRange);
            Vector3 randomPos = new Vector3(spawnPosX,0,spawnPosZ);
            return randomPos;
         }

    // Update is called once per frame
    void Update()
    {
        
    }
}
