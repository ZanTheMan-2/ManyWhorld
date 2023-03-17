using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManegar : MonoBehaviour
{
    public int enemyCount = 0;
    public GameObject win;
    public GameObject winCanva;

    void Start()
    {
        win.SetActive(false);
        winCanva.SetActive(false);
    }

    void Update()
    {
        // Check how many enemies are currently alive
        int numEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemyCount = numEnemies;

        // Do something if all enemies are dead
        if (enemyCount == 0)
        {
            Debug.Log("All enemies are dead!");
            win.SetActive(true);
            winCanva.SetActive(true);
        }
    }
}

