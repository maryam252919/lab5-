
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject CurrentCheckpoint;
    public Rigidbody2D trap;

    private Vector2 trapStartPosition;
    private float trapStartRotation;

    void Start()
    {
        CurrentCheckpoint = null;

        if (trap != null)
        {
            trapStartPosition = trap.position;
            trapStartRotation = trap.rotation;
        }
    }

    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        FindObjectOfType<movement>().transform.position =
            CurrentCheckpoint.transform.position;

        if (trap != null)
        {
            trap.velocity = Vector2.zero;
            trap.angularVelocity = 0f;
            trap.position = trapStartPosition;
            trap.rotation = trapStartRotation;
            trap.WakeUp();
        }
    }
}
