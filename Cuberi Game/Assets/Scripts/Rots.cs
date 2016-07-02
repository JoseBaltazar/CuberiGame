using UnityEngine;
using System.Collections;

public class Rots : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Rot0")
        {
            gameObject.transform.Rotate(0, -90, 0);
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "Rot1")
        {
            gameObject.transform.Rotate(0, 90, 0);
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "Rot2")
        {
            gameObject.transform.Rotate(0, -90,0 );
            Destroy(other.gameObject);
        }
		if (other.transform.tag == "Rot3")
		{
			gameObject.transform.Rotate(0, 0, 90);
            Destroy(other.gameObject);
        }
		if (other.transform.tag == "Rot4")
		{
			gameObject.transform.Rotate(0, 0, -90);
            Destroy(other.gameObject);
        }
			
    }
}
