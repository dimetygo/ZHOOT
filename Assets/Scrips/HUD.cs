using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI puntos;
    //public TextMeshProUGUI[] vidaEne;
  
    public TextMeshProUGUI niveldeJuego;

    // Update is called once per frame
    void Update()
    {
        //vidaEne.text = gameManager 
        niveldeJuego.text = gameManager.Nivel.ToString();
        puntos.text = gameManager.PuntosTotales.ToString();
        //vidaEne[10].text = gameManager.Daño.ToString();
    }
}
