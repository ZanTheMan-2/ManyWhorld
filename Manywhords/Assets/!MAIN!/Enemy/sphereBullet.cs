using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereBullet : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public float bulletSpeed = 10f; // Speed of the bullet
    public float fireRate = 2f; // Number of bullets per second
    public float bulletLifetime = 3f; // Lifetime of the bullet

    private float fireTimer; // Timer to control the fire rate

    void Update()
    {
        // Check if it's time to shoot
        if (fireTimer <= 0f)
        {
            // Calculate the position to shoot at
            Vector3 shootPosition = transform.position + transform.forward * 2f;

            // Create the bullet
            GameObject bullet = Instantiate(bulletPrefab, shootPosition, Quaternion.identity);

            // Set the velocity of the bullet
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;

            // Destroy the bullet after its lifetime has expired
            Destroy(bullet, bulletLifetime);

            // Reset the fire timer
            fireTimer = 1f / fireRate;
        }
        else
        {
            // Decrement the fire timer
            fireTimer -= Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Destroy the bullet when it hits something
        Destroy(collision.gameObject);
    }
}
