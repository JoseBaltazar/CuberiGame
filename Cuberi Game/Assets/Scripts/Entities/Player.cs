using UnityEngine;
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
        yield return new WaitForSeconds(0.5f);
        if (inLevelT==true)
        {
            this.gameObject.transform.position = spawnT.transform.position;
            this.gameObject.transform.rotation = spawnT.transform.rotation;

        }
        if (inLevel1 == true)
        {
            this.gameObject.transform.position = spawnL1.transform.position;
            this.gameObject.transform.rotation = spawnL1.transform.rotation;
        }
        if (inLevel2 == true)
        {
            this.gameObject.transform.position = spawnL2.transform.position;
            this.gameObject.transform.rotation = spawnL2.transform.rotation;
        }
        if (inLevel3 == true)
        {
            this.gameObject.transform.position = spawnL3.transform.position;
            this.gameObject.transform.rotation = spawnL3.transform.rotation;
        }

        isDead = false;
        upTime = 30;
        downTime = 0;
        contador = 0;
    }
   
   
}
