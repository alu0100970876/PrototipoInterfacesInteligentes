using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public static int llavesRec = 0;
	public Text contador;


	//Se actualiza la interfaz de usiario y se controla la escena de la aplicación en la que debe estar según el numero de llaves que haya cogido
	void Update(){
		contador.text = "Llaves: " + llavesRec;
		if (Input.GetKeyDown ("escape")) {
			//SceneManager.LoadScene ("menu");
			Application.LoadLevel("menu");
		}
		if (llavesRec >= 12) {
			creditos ();
		}
	}

	public void creditos(){
		//SceneManager.LoadScene ("Creditos");
		Application.LoadLevel("Creditos");
	}

	public void juego(){
		//SceneManager.LoadScene ("EscenaVR");
		Application.LoadLevel("EscenaVR");
	}

}
