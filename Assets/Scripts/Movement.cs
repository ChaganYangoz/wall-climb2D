using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] float speed = 5f;
    float backupSpeed;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        backupSpeed = speed;
        rb2D.velocity = new Vector2(speed, 0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = new Vector2(speed, 0);
        }

        rb2D.velocity=new Vector2(rb2D.velocity.x, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("RightWall"))
        {
            if (backupSpeed == speed)
            {
                speed *= -1;
            }
        }
        if (collision.gameObject.CompareTag("LeftWall"))
        {
            speed = backupSpeed;
        }
    }
}
