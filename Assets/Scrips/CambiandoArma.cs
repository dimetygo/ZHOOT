using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiandoArma : MonoBehaviour
{
    public GameObject ak;
    public GameObject mano;
    // Start is called before the first frame update
    void Start()
    {
        ak.gameObject.SetActive(true);
        mano.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        CambiadorDeArma();
        
    }
    public void CambiadorDeArma()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ak.gameObject.SetActive(true);
            mano.gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ak.gameObject.SetActive(false);
            mano.gameObject.SetActive(true);

        }

    }
}
