using UnityEngine;
using System.Collections;

public class CameraMov : MonoBehaviour {

    public GameObject objetivo;
    public Vector3 ofset;
    public Vector3 posInicial;
    public float smooth;

    void Start()
    {

        transform.position = objetivo.transform.position;
    }

    void Update()
    {

        MovimientoCamara();
    }

    void MovimientoCamara()
    {
        posInicial = new Vector3(objetivo.transform.position.x + ofset.x, objetivo.transform.position.y + ofset.y,objetivo.transform.position.z+ofset.z -11f);
        transform.position = Vector3.Lerp(transform.position, posInicial, smooth);
    }
}
