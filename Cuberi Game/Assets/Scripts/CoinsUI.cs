using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour {

    public Text coinsText;
    public int coinsNum;

	void Start () {

        coinsNum = GameObject.Find("Player").GetComponent<EntityController>().scoreCoins;
	}
	
	void Update () {

        coinsNum = GameObject.Find("Player").GetComponent<EntityController>().scoreCoins;
        coinsText.text = "" + coinsNum;
    }
  }