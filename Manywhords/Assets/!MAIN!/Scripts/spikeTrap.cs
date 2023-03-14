using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTrap : MonoBehaviour
{
    public Transform spikes;
    public AudioSource anim;

    private bool spiky = false;

    public Rigidbody player;

    public void Update()
    {
        if(spiky == true)
        {
          
            // Get the position of the parent object
            Vector3 parentPos = transform.position;

            // Calculate the desired position for the child object
            Vector3 childPos = parentPos + new Vector3(0, 0.33f, 0); // move child object 1 unit to the right of parent

            // Set the child object's position to the calculated position
            spikes.transform.position = childPos;

           
            
        }
        else
        {
            // Get the position of the parent object
            Vector3 parentPos = transform.position;

            // Calculate the desired position for the child object
            Vector3 childPos = parentPos + new Vector3(0, -1.74f, 0); // move child object 1 unit to the right of parent

            // Set the child object's position to the calculated position
            spikes.transform.position = childPos;
        }
            

    }

    private void OnTriggerEnter(Collider other)
    {
        spiky = true;
        StartCoroutine(waiter());
        anim.Play();

    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        spiky = false;

    }

}
