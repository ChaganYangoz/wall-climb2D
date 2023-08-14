using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] GameObject border;

    private void Start()
    {
        //InvokeRepeating("SpawnObstacle", 2f, 2f);
    }
    void SpawnObstacle()
    {
        GameObject obstacle = Instantiate(prefabs[0]);
        obstacle.transform.position = new Vector2(RandomSpawnPos().x, border.transform.position.y);
    }

    Vector2 RandomSpawnPos()
    {
        int randomPosX;
        randomPosX = Random.Range(-4, 4);
        return new Vector2(randomPosX, 0);
    }
}
