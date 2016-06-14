using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

    private float fallDelay = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {

            StartCoroutine(FallDown());
        }
    
    }
    //uso de corrutinas para desactivar kinematic esperando un tiempo en segundos
    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Destroy(gameObject, 3);
    }


}
