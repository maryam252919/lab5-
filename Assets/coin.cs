
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioClip coinSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.score++;

            AudioManager.Instance.PlaySFX(coinSound);

            Destroy(gameObject);
        }
    }
}
