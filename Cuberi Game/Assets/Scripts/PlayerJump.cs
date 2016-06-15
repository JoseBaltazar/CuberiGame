using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {
    public float Pspeed;
    float speed = 5f;
    bool isGrounded;

    public float Fsalto = 10.0f;
    float appliedVerticalSpeed = 0;

	// Use this for initialization
	void Start () {
        speed *= Pspeed;	
	}
	
	// Update is called once per frame
	void Update () {
     Vector3 resultantVelocity = Genericphysincs.ApplyHorizontalVelocity(Vector3.right, speed);
        resultantVelocity = Genericphysincs.ApplyGravity(resultantVelocity, ref appliedVerticalSpeed);
        transform.Translate(resultantVelocity * Time.deltaTime);

        CheckGround();
        CheckJump(isGrounded);

    }

   

    void CheckGround()
    {
        if (transform.position.y <= 0)
        {
            isGrounded = true;
            ResetVerticalPosition();

        }
    }

    void CheckJump(bool jumpEnabled)
    {
        if (jumpEnabled && Input.GetKeyDown(KeyCode.Space))
        {
            appliedVerticalSpeed = Fsalto;
            isGrounded = false;
        }
    }

    void ResetVerticalPosition()
    {
        Vector3 temp = transform.position;
        temp.y = 0;
        transform.position = temp;
        appliedVerticalSpeed = 0;
    }
}
