using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Player : EntityController {


    void Update()
    {
        

        if (stop == false)
        {
            if (hasEnd==false)
            {
                ObjectRun();
            }
        }
        if (canJump == true)
        {
            jumpCode();
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Obstacle1")
        {
            isDead = true;
            StartCoroutine(Die());
        }

        if (other.transform.tag == "Coinx5")
        {
            scoreCoins += GameObject.Find("ItemManager").GetComponent<Item>().cx5Value;
            Destroy(other.gameObject);
        }
    }

    IEnumerator Die()
    {
        stop = true;
        canJump = false;
        yield return new WaitForSeconds(3);
        if (inLevelT==true)
        {
            this.gameObject.transform.position = spawnT.transform.position;
        }
        if (inLevel1 == true)
        {
            this.gameObject.transform.position = spawnL1.transform.position;
        }

        isDead = false;
    }
   
   
}
