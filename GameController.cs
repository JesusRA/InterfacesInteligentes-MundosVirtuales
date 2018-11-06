using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public delegate void PlayerEvents();
    public static event PlayerEvents CambioLuz;
	public static event PlayerEvents AumentoDinero;
	public static event PlayerEvents ReduccionDisparo;
	public static event PlayerEvents AumentoTamA;

    void Update()
    {   if (Input.GetKeyDown(KeyCode.L))
        {
            CambioLuz();
        }
		if (Input.GetKeyDown (KeyCode.O)) {
			ReduccionDisparo ();
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			AumentoDinero ();
		}

    }

	public static void AumentarTamA()
    {
		if (AumentoTamA != null)
        {
			AumentoTamA();
        }
    }
}
