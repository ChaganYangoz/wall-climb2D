using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void Update()
    {
        transform.position=new Vector3(transform.position.x,player.transform.position.y,-10);
    }
}
