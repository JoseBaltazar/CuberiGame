using UnityEngine;
using System.Collections;

public class ActionObjects : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Player")
        {
            if (this.gameObject.transform.CompareTag("InTuto"))
            {
                GameObject.Find("Player").GetComponent<Player>().inTutorial = true;
            }

            if (this.gameObject.transform.CompareTag("JumpOn"))
            {
                GameObject.Find("BottonsManager").GetComponent<ButtonsMan>().activeJump = true;
            }

            if (this.gameObject.transform.CompareTag("DirectionsOn"))
            {
                GameObject.Find("BottonsManager").GetComponent<ButtonsMan>().activeDirections = true;
            }
        }
    }
}
