using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public GameObject ballRespawn;

	void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            this.transform.position = ballRespawn.transform.position;
        }
    }
}
