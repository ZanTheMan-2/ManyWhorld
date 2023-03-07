using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugernut : MonoBehaviour
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
              
                ready = false;
            }

        }
    }
}
