﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour {

    Vector3 inicio;

    public bool right=false;
    public bool left=false;
    public bool stop;

    public float speed;
    public int numJump, jumpForce;

    public int contador;

	void Start () {

        inicio = transform.position;
        stop = true;
	
	}
	
	void Update () {

        if (stop==false)
        {
            MovRun();
        }
        Jump();

	}

    public void GoRun()
    {
        stop = false;
    }

    void MovRun() {
        gameObject.transform.Translate(1*Time.deltaTime*speed, 0, 0);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numJump += 1;
            if (numJump==1||numJump==2)
            {
                GetComponent<Rigidbody>().AddForce(0, jumpForce, 0);
            }
        }
    }

    public void MoveRight()
    {
        if (contador<1)
        {
            contador++;
            gameObject.transform.Translate(0, 0, -2);
        }
    }
    public void MoveLeft()
    {
        if (contador>-1)
        {
            contador--;
            gameObject.transform.Translate(0, 0, 2);
        }
    }

    public void Death()
    {
        SceneManager.LoadScene("Test Level");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Obstacle1")
        {
            Death();
        }
    }
}
