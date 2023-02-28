using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGun : MonoBehaviour
{

    public Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("conected");
            if (Physics.Raycast(ray, 100))
                print("Hit ");


        }
    }
}