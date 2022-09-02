using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaScrip : MonoBehaviour
{
    public Transform puerta;
    public float velPuerta;
    Vector3 targetPos;
    float time;
    public bool bloqueada = true; 
    public Transform puertaCerrada;
    public Transform puertaAbierta;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = puertaCerrada.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(bloqueada && puerta.position != targetPos)
        {
            puerta.transform.position = Vector3.Lerp(puerta.transform.position, targetPos, time);
            time += Time.deltaTime * velPuerta;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            targetPos = puertaAbierta.position;
            time = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            targetPos = puertaCerrada.position;
            time = 0;
        }
    }
}
