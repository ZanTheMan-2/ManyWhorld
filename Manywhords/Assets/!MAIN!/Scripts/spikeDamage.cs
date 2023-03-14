using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeDamage : MonoBehaviour
{


    public int damageAmount = 10;
    void OnTriggerEnter(Collider collision)
    {
        {

            if (collision.gameObject.tag == "Player")
            {
                playerHealth healthScript = collision.gameObject.GetComponent<playerHealth>();
                if (healthScript != null)
                {
                    healthScript.TakeDamage(damageAmount);
                }
            }
        }
    }
}


