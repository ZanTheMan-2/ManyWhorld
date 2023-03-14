using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManegar : MonoBehaviour
{
    void Start()
    {
        Enemycountter.OnAllEnemiesDestroyed += OnAllEnemiesDefeated;
    }

    void OnAllEnemiesDefeated()
    {
        Debug.Log("All enemies defeated!");
        // Add code here to trigger whatever behavior you want
    }

    void OnDestroy()
    {
        Enemycountter.OnAllEnemiesDestroyed -= OnAllEnemiesDefeated;
    }

}
