using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemycountter : MonoBehaviour
{
    public static int enemyCount = 0;
    public static event Action OnAllEnemiesDestroyed;

    void Start()
    {
        enemyCount++;
    }

    void OnDestroy()
    {
        enemyCount--;

        if (enemyCount == 0)
        {
            OnAllEnemiesDestroyed?.Invoke();
        }
    }
}
