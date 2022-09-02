using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    public GameObject[] Enemigo;

    public Transform respawnXrigth;
    public Transform respawnXleft;

    public Transform respawnZwidth1;
    public Transform respawnZwidth2;

    public float tiempoSpawn=15;
    public float repeticionSpawn=3;
    public GameManager gameManager;



    // Start is called before the first frame update
    void Start()
    {
        GameObject enemy = Instantiate(Enemigo[0]);

       enemy.GetComponent<Enemigo>().gameManager = gameManager;


        // gameManager = GetComponent<GameManager>();
        InvokeRepeating("SpawnEnemigos", tiempoSpawn, repeticionSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
       
        
    }

    public void SpawnEnemigos ()
    {
        
       
        Vector3 posicionSpawn = new Vector3(0, 0, 0);
        posicionSpawn = new Vector3(Random.Range(respawnXrigth.position.x, respawnXleft.position.x), 1, Random.Range(respawnZwidth1.position.z, respawnZwidth2.position.z));
        
        GameObject enemy = Instantiate(Enemigo[0], posicionSpawn, gameObject.transform.rotation);
        //enemy.GetComponent<Enemigo>().gameManager = gameManager;
        // gameManager = GetComponent<GameManager>();
        //enemy = GameObject.FindGameObjectWithTag("ObjectManager").GetComponent<Enemigo>();

    }
}
