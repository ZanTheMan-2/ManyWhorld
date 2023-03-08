using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
    }

    void takeDamage()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            // switch to game over screen and reset
        }
    }

  
}
