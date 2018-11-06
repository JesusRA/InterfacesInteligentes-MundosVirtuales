using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    public int poder = 0;
	public int dinero = 0;
	public Text textoDinero;
	public Text textoPoder;

    // Use this for initialization
    void Start () {
		GameController.AumentoDinero += AumentarDinero;
		GameController.ReduccionDisparo += ReducirPoder;
		textoDinero.text = "Dinero: " + dinero;
		textoPoder.text = " Intensidad: " + poder;
    }

	public void ComprarPoder () {
		if (dinero >= 5) {
			dinero -= 5;
			poder++;
		}
		else
			Debug.Log ("No tiene suficiente dinero, cada aumento cuesta 5");
		textoDinero.text = "Dinero: " + dinero;
		textoPoder.text = " Intensidad: " + poder;
	}

    private void ReducirPoder()
    {
        poder--;
		textoPoder.text = " Intensidad: " + poder;
    }

	private void AumentarDinero()
	{
		dinero++;
		textoDinero.text = "Dinero: " + dinero;

	}

    // Update is called once per frame
    void Update () {
		
	}
}
