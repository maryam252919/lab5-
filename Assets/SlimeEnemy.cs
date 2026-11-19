
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : EnemyController
{
    public float chaseRange = 5f;

    private Rigidbody2D rb;
    private Transform player;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        sr.flipX = false;

        FindPlayer();
    }

    void FindPlayer()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    void FixedUpdate()
    {
        if (player == null)
        {
            FindPlayer();
        }

        if (player != null &&
            Vector2.Distance(transform.position, player.position) <= chaseRange)
        {
            if (player.position.x > transform.position.x)
            {
                sr.flipX = true;
                rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            }
            else
            {
                sr.flipX = false;
                rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
            }
        }
        else
        {
            if (sr.flipX == true)
            {
                rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
            }
        }
    }
}
