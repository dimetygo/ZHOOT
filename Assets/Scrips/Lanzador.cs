using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzador : MonoBehaviour
{
    public GameObject bombaPrefab;
    public Transform spawnPoint;
    public float bombaVel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {



        if (Input.GetButtonDown("Fire1"))
        {
            Disparo2();
        }
    }
    private void Disparo2()
    {
        GameObject cBom = Instantiate(bombaPrefab, spawnPoint.position, bombaPrefab.transform.rotation);
        Rigidbody rigi = cBom.GetComponent<Rigidbody>();

        rigi.AddForce(spawnPoint.forward * bombaVel, ForceMode.Impulse);
    }
}
