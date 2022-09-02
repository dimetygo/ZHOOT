using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    //Agregan punto de inicio de donde la bala saldra.
   // public GameObject BalaInicio;
    public GameObject balaPrefab;
    public Transform spawPoint;
    public float balaVel;
  


    //GameManager gameManager;

    private void Update()
    {
       
       

        if (Input.GetButtonDown("Fire1"))
        {
            Disparo();
        }
    }
    private void Disparo()
    {
        GameObject cB = Instantiate(balaPrefab, spawPoint.position, balaPrefab.transform.rotation);
        Rigidbody rig = cB.GetComponent<Rigidbody>();

        rig.AddForce(spawPoint.forward * balaVel, ForceMode.Impulse);
    }

    
}
    

   