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

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Destroy(gameObject, 3);
    }


}
