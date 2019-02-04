using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarLLave : MonoBehaviour
{

    public float spinForce;

	//Este metodo hace que la llave este perpetuamente rotando
    void Update()
    {
        transform.Rotate(0, spinForce * Time.deltaTime, 0);
    }

	// este metodo destruye el objeto y aumenta la cantidad de llaves totales
    public void Destruir()
    {
		GameController.llavesRec += 1;
        Destroy(gameObject,1);
    }

}