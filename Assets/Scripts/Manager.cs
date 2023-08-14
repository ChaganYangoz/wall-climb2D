using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] List<GameObject> spawnPos;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", 2f, 2f);
    }
    void SpawnObstacle()
    {
        int index;
        index = Random.Range(0, 1);
        Instantiate(prefabs[index], RandomSpawnPos(), prefabs[index].transform.rotation);
        
       

    }

   
    Vector3 RandomSpawnPos()
    {
        int index;
        index = Random.Range(0, 2);
        float spawnPosX = spawnPos[index].transform.position.x;

        if (index == 0)
        {
            spawnPosX = spawnPos[index].transform.position.x + 2f;
        }
        else if (index == 1)
        {
            spawnPosX = spawnPos[index].transform.position.x - 2;
        }


        return new Vector3(spawnPosX, spawnPos[index].transform.position.y + 6, 0);
    }
}
