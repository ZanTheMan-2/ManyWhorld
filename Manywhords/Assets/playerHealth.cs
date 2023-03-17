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

    public TextMeshProUGUI healthtext;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
    }

   
    private void Update()
    {
        healthtext.SetText("Health: " + currentHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Destroy(other.gameObject);
            currentHealth -= 10;
            audioSource.Play();
        }
    }
}
