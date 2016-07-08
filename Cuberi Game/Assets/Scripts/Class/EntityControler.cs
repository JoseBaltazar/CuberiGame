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

    public int scoreCoins;

    void Start()
    {

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
