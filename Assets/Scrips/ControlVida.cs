using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVida : MonoBehaviour

{
    public float vida = 100;
    public Image barraVida;
    

    public GameObject reinicio;
    public Image gameOver;
    

    private void Start()
    {
        gameOver.enabled = false;
        
        reinicio.gameObject.SetActive(false);

    }

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);

        barraVida.fillAmount = vida / 100;
        if (vida == 0)
        {
            Muerte();
        }
        
    }

    

   

    private void Muerte()
    {
        //Destroy(this.gameObject,0.9f);
        reinicio.gameObject.SetActive (true);
        gameOver.enabled = true;

    }
}
