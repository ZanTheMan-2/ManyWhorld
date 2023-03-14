using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereBullet : MonoBehaviour
{
    public int damageAmount = 10;

    public AudioSource audioSource;

    void OnTriggerEnter(Collider collision)
    {
        this.gameObject.SetActive(false);
        {

            if (collision.gameObject.tag == "Player")
            {

                playerHealth healthScript = collision.gameObject.GetComponent<playerHealth>();
                if (healthScript != null)
                {
                    healthScript.TakeDamage(damageAmount);
                    audioSource.Play();
                }
            }
        }
    }
}
