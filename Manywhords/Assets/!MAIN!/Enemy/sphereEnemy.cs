using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereEnemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootInterval = 2f;
    public float shootSpeed = 10f;

    public Transform target;
    private float timeUntilNextShoot = 2f;

    void Update()
    {
        timeUntilNextShoot -= Time.deltaTime;

        if (target != null)
        {
            transform.LookAt(target);

        }

        if (timeUntilNextShoot <= 0f)
        {
            Shoot();
            timeUntilNextShoot = shootInterval;
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = shootPoint.forward * shootSpeed;
    }
}
