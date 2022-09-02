using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManipularVida : MonoBehaviour
{
    ControlVida controlVida;
    public int cantidad;
    public float dañoTiempo;
    float tiempoModVida;
    public GameObject regeneradorVida;
    public Image ganaste;
    public bool boxFinal;
  
    
    // Start is called before the first frame update
    void Start()
    {
        ganaste.enabled = false;
        
        
        controlVida = GameObject.FindWithTag("Player").GetComponent<ControlVida>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(regeneradorVida.CompareTag("Player"))
        {
            boxFinal = true;
            ganaste.enabled = true;
        }
    }

    private void OnTriggerStay (Collider other)
    {
        if(other.tag == "Player")
        {

            tiempoModVida += Time.deltaTime;
            if(tiempoModVida > dañoTiempo)
            {
                controlVida.vida += cantidad;
                tiempoModVida = 0.0f;
            }
           
            
        }
        
    }
}
