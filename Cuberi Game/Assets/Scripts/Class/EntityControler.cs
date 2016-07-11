using UnityEngine;

public class EntityController : MonoBehaviour {

    public int downTime;
    public int upTime;
    public int contador;

    public float movSpeed;

    public bool isDead;
    public bool canJump;
    public bool inTutorial;
    public bool hasEnd;
    public bool stop;
    public bool inLevelT;
    public bool inLevel1;
    public bool inLevel2;
    public bool inLevel3;
    public bool inLevel4;

    public int scoreCoins;

    public Vector3 inicio;
    public GameObject spawnT;
    public GameObject spawnL1;
    public GameObject spawnL2;
    public GameObject spawnL3;
    public GameObject spawnL4;


    void Start()
    {
        if (inLevelT == true)
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.position = spawnT.transform.position;
        }

        if (inLevel1 == true)
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.position = spawnL1.transform.position;
        }

        if (inLevel2 == true)
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.position = spawnL2.transform.position;
        }

        if (inLevel3 == true)
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.position = spawnL3.transform.position;
        }

        if (inLevel4 == true)
        {
            GameObject.Find("Player").GetComponent<Transform>().transform.position = spawnL4.transform.position;
        }

        isDead = false;
        canJump = false;
        stop = true;
        hasEnd = false;

        upTime = 30;
        scoreCoins = 0;

    }

    public void ObjectRun()
    {
        gameObject.transform.Translate(1 * Time.deltaTime * movSpeed, 0, 0);
    }

    public void jumpCode()
    {

        if (upTime > 0)
        {

            transform.Translate(0, 10 * Time.deltaTime, 0);
            upTime--;
            if (upTime == 0)
            {
                downTime = 0;
            }

        }
        if (upTime == 0 && downTime < 10)
        {
            transform.Translate(0, -30 * Time.deltaTime, 0);
            downTime++;
            if (downTime == 10)
            {
                canJump = false;
                upTime = 30;
            }
        }
    }

    public void MoveRight()
    {
        if (contador < 1 && inTutorial == false && isDead == false)
        {
            contador++;
            gameObject.transform.Translate(0, 0, -2);
        }
    }
    public void MoveLeft()
    {
        if (contador > -1 && inTutorial == false && isDead == false)
        {
            contador--;
            gameObject.transform.Translate(0, 0, 2);
        }
    }

    public void Jump()
    {
        if (isDead == false)
        {
            canJump = true;
        }
    }



}
