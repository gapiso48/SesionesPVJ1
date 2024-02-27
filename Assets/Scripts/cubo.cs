using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cubo : MonoBehaviour
{
    // Start is called before the first frame update
    public int puntaje; //puntos que da el cubo

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c){
        Debug.Log("Choque tipo trigger");
        GameObject.Find("GameManager").GetComponent<GameManager>().sumarPuntos(puntaje);
    }
}
