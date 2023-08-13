using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTracker : MonoBehaviour
{
    [SerializeField] GameObject border;
    [SerializeField] GameObject player;
    [SerializeField] GameObject anchor;


    private void Awake()
    {
        transform.position=anchor.transform.position;
    }

    private void Update()
    {
        if(player.transform.position.y>border.transform.position.y)
        {
            UpdateWalls();
        }
        if (player.transform.position.y > transform.position.y + 10)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        }
    }





    public void UpdateWalls()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        border.transform.position = new Vector2(transform.position.x, transform.position.y + 10);
    }
}
