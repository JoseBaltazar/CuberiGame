using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject level1;
	public GameObject level2;

	public bool l1Active, l2Active;

	void Start () {

		l1Active=false;
		l2Active=false;


		level1= GameObject.FindGameObjectWithTag("Level1");
		level2= GameObject.FindGameObjectWithTag("Level2");

	}
	
	void Update () {

		CheckLevelStatus();
	
	}

	public void CheckLevelStatus()
	{
		if(l1Active==true)
		{
			level1.SetActive(true);
		}
		if(l1Active==false)
		{
			level1.SetActive(false);
		}

	}
}
