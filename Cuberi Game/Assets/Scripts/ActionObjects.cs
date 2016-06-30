using UnityEngine;

public class ActionObjects : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Timmy")
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

            if (this.gameObject.transform.CompareTag("EndLevel"))
            {
                GameObject.Find("Player").GetComponent<Player>().hasEnd = true;
            }
        }
    }
}
