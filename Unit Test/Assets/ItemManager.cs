using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

    public GameObject[] Coinx5, Coinx10, Coinx20;
    public int cx5Value, cx10Value, cx20Value;
    public float c5sRot, c10sRot, c20sRot;

    public int temp1;

	void Start () {

        Coinx5 = GameObject.FindGameObjectsWithTag("Coinx5");
        Coinx10 = GameObject.FindGameObjectsWithTag("Coinx10");
        Coinx20 = GameObject.FindGameObjectsWithTag("Coinx20");

    }

    void Update () {

        ItemFunction();
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
}
