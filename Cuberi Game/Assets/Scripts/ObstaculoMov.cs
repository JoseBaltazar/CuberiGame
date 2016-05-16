using UnityEngine;
using System.Collections;

public class ObstaculoMov : MonoBehaviour {

    Vector3 inicio;
    public int posicionY, velocidad, tiempo;

	void Start () {

        inicio = transform.position;

	}
	
	void Update () {

        transform.position = inicio;
        inicio.y = Mathf.PingPong(velocidad * Time.time, tiempo) + posicionY;
	
	}
}
