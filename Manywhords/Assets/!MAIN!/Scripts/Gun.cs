using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource audioSource;

    public GameObject something;

    public int ammo = 12;
    public int shootSpeed = 1;
    public int reloudTime = 2;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

       

        if(ammo >= 0)
            {


                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "Enemy")
                    {
                        Damage();
                    }
                }

            }
            else
            {
                
            }


            void Damage()
            {
                something.gameObject.SetActive(false);
                Debug.Log("Damaged");
            }
        }
    }
}