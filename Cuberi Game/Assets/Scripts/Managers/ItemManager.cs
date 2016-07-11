using UnityEngine;

public class ItemManager : Item {

    public GameObject[] Coinx5, Coinx10, Coinx20, Rot0, Rot1, Rot2, Rot3, Rot4;
   

	void Start () {

        Coinx5 = GameObject.FindGameObjectsWithTag("Coinx5");
        Coinx10 = GameObject.FindGameObjectsWithTag("Coinx10");
        Coinx20 = GameObject.FindGameObjectsWithTag("Coinx20");

        Rot0 = GameObject.FindGameObjectsWithTag("Rot0");
        Rot1 = GameObject.FindGameObjectsWithTag("Rot1");
        Rot2 = GameObject.FindGameObjectsWithTag("Rot2");
        Rot3 = GameObject.FindGameObjectsWithTag("Rot3");
        Rot4 = GameObject.FindGameObjectsWithTag("Rot4");


    }

    void Update () {

        //ItemFunction();
        ActivateRots();
	}

    public void ItemFunction()
    {
        foreach (GameObject obj in Coinx5)
        {
            obj.transform.Rotate(0, 1 * c5sRot * Time.deltaTime, 0);
        }
        foreach (GameObject obj in Coinx10)
        {
            obj.transform.Rotate(0, 1 * c10sRot * Time.deltaTime, 0);
        }
        foreach (GameObject obj in Coinx20)
        {
            obj.transform.Rotate(0, 1 * c20sRot * Time.deltaTime, 0);
        }
    }

    public void ActivateRots()
    {
        if (GameObject.Find("Player").GetComponent<Player>().isDead == true)
        {
            foreach (GameObject objR in Rot0)
            {
                objR.gameObject.SetActive(true);
            }
            foreach (GameObject objR1 in Rot1)
            {
                objR1.gameObject.SetActive(true);
            }
            foreach (GameObject objR2 in Rot2)
            {
                objR2.gameObject.SetActive(true);
            }
        }
    }
}
