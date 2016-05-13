using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Vector3 inicio;

    public bool right=false;
    public bool left = false;

    public float speed;
    public int numJump, jumpForce;

    public int contador;

	void Start () {

        inicio = transform.position;
	
	}
	
	void Update () {

        MovRun();
        Jump();

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
        Application.LoadLevel("Test Level");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Obstacle1")
        {
            Death();
        }
    }
}
