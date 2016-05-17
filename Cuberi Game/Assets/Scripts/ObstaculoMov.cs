using UnityEngine;

public class ObstaculoMov : MonoBehaviour {

    Vector3 inicio;
    public int posicionF_Y;
    public float velocidad,posicionI_Y;


    void Start () {

        inicio = transform.position;

	}
	
	void Update () {

        this.gameObject.transform.position=inicio;
        inicio.y = Mathf.PingPong(velocidad * Time.time, posicionI_Y) + posicionF_Y;
	
	}
}
