using UnityEngine;



public class playerAnimations : MonoBehaviour
{

    public Animator timmy;
  



    void Start()
    {       
        timmy = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
    }

    public void runAnim()

    {
        timmy.Play("Run", -1, 0f);
    }

    public void stopAnim()

    {
        timmy.Play("Stop", -1, 0f);
    }

    public void jumpAnim()

    {
            timmy.Play("Jump", -1, 0f);   
    }

    public void leftAnim()

    {
            timmy.Play("Lean Left", -1, 0f);      
    }

    public void rightAnim()

    {
            timmy.Play("Lean Right", -1, 0f);
    }
    /*
   public void OnTriggerEnter(Collider die)

    {
        if (die.transform.tag == "Obstacle1")
        {
            timmy.Play("Death", -1, 0f);
        }
    }*/
}