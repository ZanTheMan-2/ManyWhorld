using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereEnemy : MonoBehaviour
{
    public Transform target;
    public GameObject bullet;
    public Transform attackPoint;

    bool ready = true;

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);

            if (ready)
            {
                attack();
                ready = false;
            }
                
        }
    }

  IEnumerator waiter()
    {
       
        yield return new WaitForSeconds(3);
        ready = true;
    }
    void attack()
    {
        Debug.Log("attack");
        GameObject currentBullet = Instantiate(bullet);
        currentBullet.transform.position = attackPoint.position;
        StartCoroutine(waiter());
    }
    
}
