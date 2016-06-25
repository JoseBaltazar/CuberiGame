﻿using UnityEngine;
using UnityEngine.SceneManagement;

/*Clase desarrollada para otorgar movimiento a un objeto.
 * dotarlo de un salto simulado, llevarlo a su posición inicial 
 * y con posibilidad de controlarlo mediante teclas o entrada tactil
 */

public class Player : MonoBehaviour {

    Vector3 inicio; /*Obtiene la posicion donde se encuentra actualmente el objeto*/

    public int downTime; /*Define cuanto tiempo demora en bajar el objeto*/
    public int upTime; /*Define cuanto tiempo demora en subir*/
    public int contador; /*Define el movimiento en X del objeto dependiendo de su valor*/

    public float speed; /*Variable que otorga velocidad constante al objeto*/

    public bool stop; /*Controla si el objeto puede moverse o no*/
    public bool canJump = false; /*Controla si el metodo JumpCode() se ejecuta o no*/
    public bool inTutorial; /*Define las acciones que puede hacer el objeto como desplazamiento o salto*/


    void Start()
    {
        /*Se inicializan las variables para impedir el desplazamiento del objeto desde el inicio*/
        stop = true;

        /*Igualamos la variable inicio a la posicion acutal del objeto*/
        inicio = transform.position;

        upTime = 20;

    }

    void Update()
    {
        /*Comprobamos los booleanos para realizar las acciones de movimieno o salto*/

        if (stop == false)
        {
            MovRun();

        }
        if (canJump == true)
        {
            jumpCode();
        }

    }

    /*Permite el movimiento del objeto cuando se ejecuta*/
    public void GoRun()
    {
        stop = false;
    }

    /*Utilizado para desplazar el objeto en X cuando se ejecute*/
    void MovRun()
    {
        gameObject.transform.Translate(1 * Time.deltaTime * speed, 0, 0);
    }

    /*Simula el salto y caída del objeto*/
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
        if (upTime == 0 && downTime < 20)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
            downTime++;
            if (downTime == 20)
            {
                canJump = false;
                upTime = 20;
            }
        }
    }

    /*Metodos para controlar movimiento derecha-izquierda*/
    public void MoveRight()
    {
        if (contador < 1 && inTutorial == false)
        {
            contador++;
            gameObject.transform.Translate(0, 0, -2);
        }
    }
    public void MoveLeft()
    {
        if (contador > -1 && inTutorial == false)
        {
            contador--;
            gameObject.transform.Translate(0, 0, 2);
        }
    }

    /*Convierte el valor del bool a verdadero*/
    public void Jump()
    {
        canJump = true;
    }

    /*Recarga de la escena al morir*/
    public void Death()
    {
        SceneManager.LoadScene("Test Level");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Obstacle1")
        {
            Death();
        }
    }
}
