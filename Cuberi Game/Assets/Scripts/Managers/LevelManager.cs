using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject level1;
	public GameObject level2;
    public GameObject tLevel;

	public bool tActive,l1Active, l2Active;

	void Start () {

        tLevel = GameObject.FindGameObjectWithTag("Tutorial");
		level1 = GameObject.FindGameObjectWithTag("Level1");
		level2 = GameObject.FindGameObjectWithTag("Level2");

        tLevel.SetActive(true);
        level1.SetActive(false);
        level2.SetActive(false);

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
        if (l2Active == true)
        {
            level2.SetActive(true);
        }
        if (l2Active == false)
        {
            level2.SetActive(false);
        }
        if (tActive == true)
        {
            tLevel.SetActive(true);
        }
        if (tActive == false)
        {
            tLevel.SetActive(false);
        }
    }
}
