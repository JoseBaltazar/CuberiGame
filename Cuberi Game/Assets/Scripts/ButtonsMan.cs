using UnityEngine;
using System.Collections;
using UnityEditor;

public class ButtonsMan : MonoBehaviour {

    public GameObject StartBot;
    public GameObject OptionsBot;

    public GameObject RightBut, LeftBut;
    public GameObject JumpBut1,JumpBut2;

    public GameObject PauseBut;

    public GameObject volUpBut;
    public GameObject volLowBut;

    public GameObject briUpBut;
    public GameObject briLowBut;

    public bool inOptions;

    public bool isPaused;

	void Start () {

        inOptions = false;

        isPaused = false;

        PauseBut.SetActive(false);

        RightBut.SetActive(false);
        LeftBut.SetActive(false);

        JumpBut1.SetActive(false);
        JumpBut2.SetActive(false);

        volUpBut.SetActive(false);
        volLowBut.SetActive(false);

        briUpBut.SetActive(false);
        briLowBut.SetActive(false);
    }
	
	void Update () {

        CheckPause();
        CheckOptions();
	}

    public void CheckPause()
    {
        if (isPaused==true)
        {
            RightBut.SetActive(true);
            LeftBut.SetActive(true);

            JumpBut1.SetActive(true);
            JumpBut2.SetActive(true);
        }
    }

    public void CheckOptions()
    {
        if (inOptions==true)
        {
            Options();
            OptionsBot.SetActive(false);
        }

        if (inOptions==false)
        {
            volUpBut.SetActive(false);
            volLowBut.SetActive(false);

            briUpBut.SetActive(false);
            briLowBut.SetActive(false);
        }
    }

    public void Pause()
    {
        GameObject.Find("Player").GetComponent<Player>().stop = true;
    }

    public void Options()
    {
        GameObject.Find("Player").GetComponent<Player>().stop = true;

        volUpBut.SetActive(true);
        volLowBut.SetActive(true);

        briUpBut.SetActive(true);
        briLowBut.SetActive(true);
    }

    public void GoOptions()
    {
        inOptions = true;
    }

    public void GoPause()
    {
        isPaused = true;
    }

    public void GoPlay()
    {
        GameObject.Find("Player").GetComponent<Player>().stop = false;
    }


}
