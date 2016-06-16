using UnityEngine;

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
    public bool inPlay;
    public bool isPaused;

	void Start () {

        inOptions = false;

        isPaused = true;

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
        CheckPlay();
	}

    public void CheckPause()
    {
        if (isPaused == true)
        {
            StartBot.SetActive(true);
            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);
            JumpBut2.SetActive(false);
        }
        if (isPaused == false)
        {
            StartBot.SetActive(false);
            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);
            JumpBut2.SetActive(false);
        }

    }

    public void CheckPlay()
    {
        if (inPlay==true && isPaused==false)
        {
            StartBot.SetActive(false);
            PauseBut.SetActive(true);

            RightBut.SetActive(true);
            LeftBut.SetActive(true);

            JumpBut1.SetActive(true);
            JumpBut2.SetActive(true);
        }

        if (inPlay == false && isPaused == true)
        {
            StartBot.SetActive(true);
            PauseBut.SetActive(false);

            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);
            JumpBut2.SetActive(false);
        }
    }

    public void CheckOptions()
    {

        if (inPlay==true)
        {
            volUpBut.SetActive(false);
            volLowBut.SetActive(false);

            briUpBut.SetActive(false);
            briLowBut.SetActive(false);
        }
    }


    public void GoOptions()
    {
        GameObject.Find("Player").GetComponent<Player>().stop = true;
        inOptions = true;
        inPlay = false;
        isPaused = true;

        volUpBut.SetActive(true);
        volLowBut.SetActive(true);

        briUpBut.SetActive(true);
        briLowBut.SetActive(true);
    }

    public void GoPause()
    {
        GameObject.Find("Player").GetComponent<Player>().stop = true;
        isPaused = true;
        inPlay = false;
    }

    public void GoPlay()
    {
        StartBot.SetActive(false);
        isPaused = false;
        inPlay = true;
        inOptions = false;
        GameObject.Find("Player").GetComponent<Player>().stop = false;
    }


}
