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
        gameObject.transform.position = anchor.transform.position;
    }
    private void Update()
    {
        if (player.transform.position.y > transform.position.y + 5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
        }
    }
}
