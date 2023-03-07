using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Slider healthBar;
    public GameObject UI;

    public GameObject effects;
    void Start()
    {
        currentHealth = maxHealth;
        UI.SetActive(false);
        effects.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        UI.SetActive(true);
        UpdateHealthBar();
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void UpdateHealthBar()
    {
        healthBar.value = (float)currentHealth / maxHealth;
    }

    void Die()
    {
        StartCoroutine(waiter());
        Destroy(gameObject);
    }
    IEnumerator waiter()
    {
        effects.SetActive(true);
        yield return new WaitForSeconds(0.2f);
    }
}
