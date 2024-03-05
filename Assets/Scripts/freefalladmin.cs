using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freefalladmin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaculo;
    public GameObject contenedor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void repetir(){
        Vector3 pos = obstaculo.transform.position;
        pos.y = pos.y - 6;
        GameObject a = Instantiate(obstaculo,pos, obstaculo.transform.rotation,contenedor.transform);

    }

}
