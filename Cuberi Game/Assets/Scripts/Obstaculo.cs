using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {

	int contador=0;
	Vector3 posicion;

	// Use this for initialization
	void Start () {

		posicion=transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		MovimientoObstaculo();
	}

	void MovimientoObstaculo()
	{
		//movimiento arriba-abajo
		if(gameObject.transform.tag=="ObsMovVertA")
		{
			if(contador<60)
			{
				posicion.y+=0.09f;
				this.transform.position=posicion;
				contador++;
			}
			else if(contador<120)
			{
				posicion.y-=0.09f;
				this.transform.position=posicion;
				contador++;
			}
			else
			{
				contador=0;
			}
		}
		//movimiento abajo-arriba
		if(gameObject.transform.tag=="ObsMovVertB")
		{
			if(contador<60)
			{
				posicion.y-=0.09f;
				this.transform.position=posicion;
				contador++;
			}
			else if(contador<120)
			{
				posicion.y+=0.09f;
				this.transform.position=posicion;
				contador++;
			}
			else
			{
				contador=0;
			}
		}
		//movimiento izquierda-derecha
		if(gameObject.transform.tag=="ObsMovHorizA")
		{
			if(contador<60)
			{
				posicion.x+=0.09f;
				this.transform.position=posicion;
				contador++;
			}
			else if(contador<120)
			{
				posicion.x-=0.09f;
				this.transform.position=posicion;
				contador++;
			}
			else
			{
				contador=0;
			}
		}
	}

}
