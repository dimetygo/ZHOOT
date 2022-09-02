using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveScrip : MonoBehaviour
{
    public PuertaScrip puertaAbre;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            puertaAbre.bloqueada = true;
        }
        Destroy(gameObject);
    }
}
