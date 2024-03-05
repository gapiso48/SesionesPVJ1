using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculoFreefall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject contenedor;
    private GameObject obstaculo;
    
    void Start()
    {
       obstaculo = this.gameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c){
        if (c.gameObject.tag == "Player"){
            repetir();
        }
    }
    
    void repetir(){
        Vector3 pos = this.transform.position;
        pos.y = pos.y - 6;
        GameObject a = Instantiate(obstaculo,pos, obstaculo.transform.rotation,contenedor.transform);
        a.name = "obstaculo1";
    }

}
