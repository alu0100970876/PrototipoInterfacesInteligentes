Unusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRcaminar : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;

    private CharacterController cc;

	//se declara cual es el controlador del jugador
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // si la camara está a cierto ángulo establecido desde la interfaz de unity, el jugador podrá moverse y se le asigna una velocidad hacia adelante
    void Update()
    {
        if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
    }
}
