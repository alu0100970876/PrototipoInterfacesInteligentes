using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class aplicarTexturas : MonoBehaviour {

    public Material material;
    Renderer rend;
    Component[] children;

	// Use this for initialization
	void Start () {
        cambiarTexturas();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void cambiarTexturas()
    {
        children = GetComponentsInChildren<Renderer>();
        foreach (Renderer joint in children)
        {
            rend = joint.GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = material;
        }
    }
}