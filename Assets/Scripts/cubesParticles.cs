using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubesParticles : MonoBehaviour {
    [Header("Configuriracion")]
    public GameObject cubo;
    public float tiempoGeneracion = 0.2f;

	// Use this for initialization
	void Start () {
        StartCoroutine(cubes());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator cubes()
    {
        for (int i = 0; i < 150; i++)
        {
            GameObject go = Instantiate(cubo, transform.position, Quaternion.identity) as GameObject;
            go.transform.Rotate(new Vector3(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180)));
            
            yield return new WaitForSeconds(tiempoGeneracion);
        }
    }
}
