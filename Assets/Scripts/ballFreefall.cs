using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFreefall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 velocidadBola = this.GetComponent<Rigidbody>().velocity;
        if (Input.GetKey(KeyCode.LeftArrow))
            {
                velocidadBola.x=-2.0f;
            }
        if (Input.GetKey(KeyCode.RightArrow))
            {
                velocidadBola.x = 2.0f;
            }
        this.GetComponent<Rigidbody>().velocity = velocidadBola;

    }

    void OnCollisionEnter(Collision c){
        //Debug.Log("Colision");

    }
}
