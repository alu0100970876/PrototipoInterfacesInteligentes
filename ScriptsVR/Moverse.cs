using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse : MonoBehaviour{

    public int velocidad;
    
    void Start(){
        
    }

    
    void Update(){
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * velocidad * Time.deltaTime;
        }
        
    }
}
