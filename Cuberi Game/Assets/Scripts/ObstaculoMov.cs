using UnityEngine;

public class ObstaculoMov : MonoBehaviour {

    Vector3 inicio;
    public int posicionI_Y;
    public float velocidad,posicionF_Y;


    void Start () {

        inicio = transform.position;

	}
	
	void Update () {

        this.gameObject.transform.position=inicio;
        inicio.y = Mathf.PingPong(velocidad * Time.time, posicionF_Y) + posicionI_Y;
	
	}
}
