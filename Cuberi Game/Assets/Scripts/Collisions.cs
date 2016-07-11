using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Rot0")
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.Rotate(0, -90, 0);
            other.gameObject.SetActive(false);
        }
        if (other.transform.tag == "Rot1")
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.Rotate(0, 90, 0);
            other.gameObject.SetActive(false);
        }
        if (other.transform.tag == "Rot2")
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.Rotate(0, -90, 0);
            other.gameObject.SetActive(false);
        }
        if (other.transform.tag == "Rot3")
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.Rotate(0, 0, 90);
            other.gameObject.SetActive(false);
        }
        if (other.transform.tag == "Rot4")
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.Rotate(0, 0, -90);
            other.gameObject.SetActive(false);
        }
    }
}
