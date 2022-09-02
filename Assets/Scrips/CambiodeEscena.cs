using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{

    // Start is called before the first frame update
    public void Inicio()
    {
        SceneManager.LoadScene("Game");
    }

    public void Salir()
    {
        Debug.Log("Cerramos el Juego");
        Application.Quit();
    }
}
