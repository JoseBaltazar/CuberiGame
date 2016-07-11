using UnityEngine;

public class ActionObjects : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Timmy")
        {
            if (this.gameObject.transform.CompareTag("InTuto"))
            {
                GameObject.Find("Player").GetComponent<Player>().inTutorial = true;
                GameObject.Find("Player").GetComponent<Player>().inLevelT = true;
                GameObject.Find("Player").GetComponent<Player>().inLevel1 = false;
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
            if (this.gameObject.transform.CompareTag("StartL1"))
            {
                GameObject.Find("Player").GetComponent<Player>().inLevelT = false;
                GameObject.Find("Player").GetComponent<Player>().inTutorial = false;
                GameObject.Find("Player").GetComponent<Player>().inLevel1 = true;
            }
        }
    }
}
