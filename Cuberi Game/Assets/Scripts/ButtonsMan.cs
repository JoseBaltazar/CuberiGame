﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class ButtonsMan : MonoBehaviour {

    public GameObject StartBot;
    public GameObject OptionsBot;
    public GameObject RightBut, LeftBut;
    public GameObject JumpBut1,JumpBut2;
    public GameObject OptionsBut;

    public bool isPaused;

	void Start () {

        isPaused = false;

        RightBut.SetActive(false);
        LeftBut.SetActive(false);
	}
	
	void Update () {

        CheckStart();
	}

    public void CheckStart()
    {
        if (GameObject.Find("Player").GetComponent<Player>().stop==false)
        {
            StartBot.SetActive(false);
            RightBut.SetActive(true);
            LeftBut.SetActive(true);
        }
        if (GameObject.Find("Player").GetComponent<Player>().stop==true)
        {
            StartBot.SetActive(true);
            RightBut.SetActive(false);
            LeftBut.SetActive(false);
        }
    }
}
