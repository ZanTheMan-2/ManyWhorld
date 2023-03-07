using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    [SerializeField]
    //private TextMeshPro textMeshPro;
    //355.8472
    public AudioSource audioSource;
    public AudioSource emty;

    public Color[] colors;
    public Transform gun;


    public int ammo = 12;
    public int shootSpeed = 1;
    public int reloudTime = 2;
    public int Damage = 20;
    public int attackDamage = 10;

    public Animator anim;

    public bool shoot = true;
    public TextMeshProUGUI ammoText;

    void Start()
    {
        anim = GetComponent<Animator>();
        int currentColor = Random.Range(0, colors.Length);
        GetComponentInChildren<Material>().color = colors[currentColor];
    }

    void Update()
    {
        ammoText.SetText("Ammo: " + ammo);

     
       /* if (gun.eulerAngles.x == 355.8472f)
            shoot = true;
        else
            shoot = false;*/


        if (Input.GetKeyDown(KeyCode.R) && shoot)
        {


            shoot = false;
            ammo = 12;
            anim.Play("gun spin");

            StartCoroutine(ReloadDelay());
        }
        //  textMeshPro.text = " ";

        if (shoot == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

                
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



                if (ammo >= 1)
                {
                    anim.Play("recoil");

                    audioSource.Play();

                    ammo -= 1;

                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.tag == "damagePlus")
                        {
                            attackDamage += 10;
                        }
                        if (hit.transform.tag == "ammoPlus")
                        {
                            ammo += 10;
                        }


                        if (hit.transform.tag == "Enemy")
                        {
                            Damage();
                        }
                    }

                }
                else
                {
                    emty.Play();

                }



                void Damage()
                {
                   
                    Debug.Log("Damaged");

                    if (hit.collider.gameObject.CompareTag("Enemy"))
                    {
                        hit.collider.gameObject.GetComponent<enemyHealth>().TakeDamage(attackDamage);
                    }


                }
            }


        }
        else
        {

        }
    }

    IEnumerator ReloadDelay()
    {
        yield return new WaitForSeconds(0.8f);
        shoot = true;
    }
}