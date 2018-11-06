using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectB : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // GameController.ReduccionPoder += ReducirPoder;
		GameController.AumentoDinero += CambiarColor;
    }

    /*private void ReducirPoder()
    {
        transform.localScale += new Vector3(0, 0.5F, 0);
    }*/

	private void CambiarColor()
	{
		Renderer rend = GetComponent<Renderer> ();
		int numero = UnityEngine.Random.Range (0, 3);
		switch (numero)
		{
			case 0: rend.material.color = Color.blue; break;
			case 1: rend.material.color = Color.yellow; break;
			case 2: rend.material.color = Color.red; break;
		}
	}

    // Update is called once per frame
    void Update()
    {

    }

    /* private void OnTriggerEnter(Collider other)
    {
        GameController.ReducirPoder();
    } */

	private void OnCollisionEnter (Collision collision) {
		GameController.AumentarTamA ();
	}
}
