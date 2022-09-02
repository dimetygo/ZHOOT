using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
   public void ReiniciarElJuego()
    {
        SceneManager.LoadScene("Main");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
