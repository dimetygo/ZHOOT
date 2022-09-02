using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vidEn;
    public GameManager gameManager;
    public int valor = 1;
    public Transform jugador;
    private NavMeshAgent agent;
    [SerializeField] private Slider eneSha;




    private void Start()
    {
        //gameManager = GetComponent<GameManager>();
         agent = GetComponent<NavMeshAgent>();
       
        
    }
    private void Update()
    {

        eneSha.value = vidEn;

        agent.destination = jugador.position;
    }
    public void TomarDaño(float daño)
    {
       
        vidEn -= daño;
        
        if (vidEn <= 0)
        {
            gameManager.SumarPuntos(valor);
            
            Muerte();
        }

    }

   

    private void Muerte()
    {
        //Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }
}
