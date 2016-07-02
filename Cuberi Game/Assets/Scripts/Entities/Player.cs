﻿using UnityEngine;
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
    }

    IEnumerator Die()
    {
        stop = true;
        canJump = false;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Test Level");

    }
   
   
}