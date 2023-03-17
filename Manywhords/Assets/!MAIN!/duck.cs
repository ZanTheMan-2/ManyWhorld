using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck : MonoBehaviour
{
    public AudioSource duck1;
    public AudioSource duck2;

    public AudioSource freeze;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            duck2.Play();
            StartCoroutine(waiter());
            freeze.Stop();
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(3);
        duck1.Play();
    }
}
