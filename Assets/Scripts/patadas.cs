using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patadas : MonoBehaviour {
        
    public GameObject pelota;
    public int fuerza;
    public int fuerzaArriba;    //Al pulsar el botón derecho del raton, se lanza la pelota hacia arriba. Esto establece la fuerza con la que se alza.
    public int distanciaMaxima; //Como de cerca tiene que estar el jugador para poder golpear la pelota

	
	void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if(Vector3.Distance(this.transform.position, pelota.transform.position) < distanciaMaxima)
            {
                pelota.transform.localEulerAngles = new Vector2(0, transform.eulerAngles.y);
                pelota.GetComponent<Rigidbody>().AddRelativeForce(0,0,fuerza);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (Vector3.Distance(this.transform.position, pelota.transform.position) < distanciaMaxima)
            {
                pelota.transform.localEulerAngles = new Vector2(0, transform.eulerAngles.y);
                pelota.GetComponent<Rigidbody>().AddRelativeForce(0, fuerzaArriba, fuerza);
            }
        }
    }
}
