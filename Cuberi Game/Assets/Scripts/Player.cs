using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour {

    Vector3 inicio;

    public bool canJump = false;
    public int downTime;
    public int upTime;

    public bool right=false;
    public bool left=false;
    public bool stop;
    public float speed;
    public int contador;
    

	void Start () {

        inicio = transform.position;
        stop = true;
	
	}
	
	void Update () {

        if (stop==false)
        {
            MovRun();
            Jump();

        }
     
      

    }

    public void GoRun()
    {
        stop = false;
    }




    void MovRun() {
        gameObject.transform.Translate(1*Time.deltaTime*speed, 0, 0);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }

        if (canJump == true && upTime > 0)
        {
            transform.Translate(0, 10 * (Time.deltaTime), 0);
            upTime--;
            if (upTime == 0)
            {
                downTime = 0;
            }

        }
        if (upTime == 0 && downTime < 20)
        {
            transform.Translate(0, -10 * (Time.deltaTime), 0);
            downTime++;
            if (downTime == 20)
            {
                canJump = false;
                upTime = 20;
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
