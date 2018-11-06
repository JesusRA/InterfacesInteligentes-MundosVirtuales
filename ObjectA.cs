using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectA : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
		GameController.ReduccionDisparo += ReducirTam;
		GameController.AumentoTamA += AumentarTam;
    }

    // Update is called once per frame
    void Update()
    {

    }

	public void ReducirTam () {
		transform.localScale -= new Vector3(0.2F, 0.2F, 0.2F);
	}

	public void AumentarTam () {
		transform.localScale += new Vector3(0.2F, 0.2F, 0.2F);
	}
}
