using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public GameObject Camera;
    public float X;
    public float Y;
    public float Z;
    void Start()
    {
        
    }

    
    void Update()
    {
        Camera.transform.Rotate(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
    }
}
