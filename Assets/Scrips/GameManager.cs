using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;

    public int Nivel { get { return nivel; } }
    private int nivel;

    public int vidaEne { get { return vidaRes; } }
    private int vidaRes;

    





    private void Start()
    {
         //nombre = GameObject.FindGameObjectWithTag("ObjectManager").GetComponent<Enemigo>();
    }

    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Debug.Log(puntosTotales);
        if (puntosTotales == + 11)
        {
            puntosTotales += 1;
            SubirNivel();
            
        }

    }
    public void SubirNivel()
    {
        puntosTotales = 0;
        nivel += 1;
    }

    

}
