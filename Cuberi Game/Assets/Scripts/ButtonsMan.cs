using UnityEngine;
using System.Collections;

public class ButtonsMan : MonoBehaviour {

    public GameObject StartBot;
    public GameObject OptionsBot;

	void Start () {
	}
	
	void Update () {

        CheckStart();
	}

    public void CheckStart()
    {
        if (GameObject.Find("Player").GetComponent<Player>().stop==false)
        {
            StartBot.SetActive(false);
        }
        if (GameObject.Find("Player").GetComponent<Player>().stop == true)
        {
            StartBot.SetActive(true);
        }
    }
}
