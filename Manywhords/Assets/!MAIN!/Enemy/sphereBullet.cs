using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereBullet : MonoBehaviour
{
    public Rigidbody Rigid;

    public Transform target;
    public int speed;

    public int damageAmount = 10; // Amount of damage to deal to objects
    public LayerMask damageableLayers;

    private void Start()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (target != null)
        {
            transform.LookAt(target);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (damageableLayers == (damageableLayers | (1 << other.gameObject.layer)))
        {
            Health health = other.gameObject.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(damageAmount);
            }

            Destroy(gameObject);
        }
    }
    void OnEnable()
    {
        Invoke("Destroy", 10f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }

    void OnDisable()
    {
        CancelInvoke();
    }
}
