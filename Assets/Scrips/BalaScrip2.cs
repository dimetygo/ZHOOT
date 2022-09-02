using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaScrip2 : MonoBehaviour
{
    [SerializeField] private float daño;
    [SerializeField] private GameObject efecto;
    [SerializeField] private ContactPoint contacto;
    [SerializeField] private Quaternion rota;
    [SerializeField] private Vector3 pos;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), rota);
           

            other.GetComponent<Enemigo>().TomarDaño(daño);
            

            Destroy(gameObject);
        }
        else if (other.CompareTag("Muros"))
        {
            Destroy(gameObject);
        }
    }

    


}
