using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerHealth : MonoBehaviour
{
    public AudioSource audioSource;

    public int maxHealth = 5;
    public int currentHealth;

    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
    }

    void Update()
    {
        healthText.SetText("Health: " + currentHealth);


        Debug.Log(currentHealth);
        if (Input.GetKeyDown(KeyCode.H))
            currentHealth -= 10;

        if (currentHealth <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameOver");

        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        audioSource.Play();

    }

}

   

  //play

