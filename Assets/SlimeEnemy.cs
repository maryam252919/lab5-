
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : EnemyController
{
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.flipX = false;
    }

    void FixedUpdate()
    {
        if (sr.flipX == true)
        {
            GetComponent<Rigidbody2D>().velocity =
                new Vector2(maxSpeed,
                GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity =
                new Vector2(-maxSpeed,
                GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
