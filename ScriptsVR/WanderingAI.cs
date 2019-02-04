using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine;
public class WanderingAI : MonoBehaviour {
	
	public float wanderRadius;
	public float wanderTimer;
	private Transform target;
	private NavMeshAgent agent;
	private float timer;

	// Use this for initialization
	void OnEnable () {
		agent = GetComponent<NavMeshAgent> (); // se le asigna al agente un NavMesh activo
		timer = wanderTimer;
	}

	static GameObject dummy;
	void Start(){
		dummy = new GameObject ();
	}

	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;
		//el agente realiza una direccion aleatoria con cada ciclo del timer
		if (timer >= wanderTimer) {
			//se crea la nueva posicion aleatoria
			RandomNavCircle(transform.position, wanderRadius);
			//se le indica al agente que se mueva a esa posicion
			agent.SetDestination (dummy.transform.position);
			//el timer se pone a 0 para reiniciar la cuenta
			timer = 0;
		}
	}

	// Con este metodo se establece una posición aleatoria en torno a un v3 de origen
	public static void RandomNavCircle(Vector3 origin, float dist) {
		Vector3 randDirection = Random.insideUnitSphere * dist;
		randDirection.x += origin.x;
		randDirection.z += origin.z;
		randDirection.y = origin.y;
		dummy.transform.position = randDirection;
	}
}