using UnityEngine;
using System.Collections;

public class ButtonsMan : MonoBehaviour {

    public GameObject StartBot;
    public GameObject OptionsBot;

    public GameObject RightBut, LeftBut;
    public GameObject JumpBut1;

    public GameObject PauseBut;

    public GameObject volUpBut;
    public GameObject volLowBut;

    public GameObject briUpBut;
    public GameObject briLowBut;

    public GameObject GoNextLevelBut;

    public bool inOptions;
    public bool inPlay;
    public bool isPaused;
    public bool activeJump;
    public bool activeDirections;
    public bool GoNextLevel;

	void Start () {

        inOptions = false;

        isPaused = true;

        PauseBut.SetActive(false);

        RightBut.SetActive(false);
        LeftBut.SetActive(false);

        JumpBut1.SetActive(false);

        volUpBut.SetActive(false);
        volLowBut.SetActive(false);

        briUpBut.SetActive(false);
        briLowBut.SetActive(false);

        GoNextLevelBut.SetActive(false);
    }
	
	void Update () {

        CheckPause();
        CheckOptions();
        CheckPlay();
        CheckTutorial();
        CheckEndLevel();
	}

    public void CheckEndLevel()
    {
        if (GameObject.Find("Player").GetComponent<Player>().hasEnd == true)
        {
            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);

            StartBot.SetActive(false);

            PauseBut.SetActive(false);

            GoNextLevelBut.SetActive(true);
        }

        if (GameObject.Find("Player").GetComponent<Player>().hasEnd == false)
        {
            GoNextLevelBut.SetActive(false);
        }

    }


    public void CheckTutorial()
    {
        if (GameObject.Find("Player").GetComponent<Player>().inTutorial==true)
        {
            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);
          
        }

        if (activeJump==true)
        {
            JumpBut1.SetActive(true);
        }

        if (activeDirections == true)
        {
            RightBut.SetActive(true);
            LeftBut.SetActive(true);
            GameObject.Find("Player").GetComponent<Player>().inTutorial =false;
        }
    }

    public void CheckPause()
    {
        if (isPaused == true)
        {
            StartBot.SetActive(true);
            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);
            
        }
        if (isPaused == false)
        {
            StartBot.SetActive(false);
            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);
            
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
        }

        if (inPlay == false && isPaused == true)
        {
            StartBot.SetActive(true);
            PauseBut.SetActive(false);

            RightBut.SetActive(false);
            LeftBut.SetActive(false);

            JumpBut1.SetActive(false);
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

    public void GoLevel()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        GameObject.Find("Player").GetComponent<Player>().hasEnd = false;
        yield return new WaitForSeconds(1);
        GameObject.Find("LevelManager").GetComponent<LevelManager>().l1Active = true;
    }
}
