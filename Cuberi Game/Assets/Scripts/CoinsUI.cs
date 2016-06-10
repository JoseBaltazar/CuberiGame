using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinsUI : MonoBehaviour {

    public Text coinsText;
    public int coinsNum;

	void Start () {

        coinsNum = GameObject.Find("Player").GetComponent<Player>().coins;
	}
	
	void Update () {

        coinsNum = GameObject.Find("Player").GetComponent<Player>().coins;
        coinsText.text = "" + coinsNum;
    }
}
