using UnityEngine;
using System.Collections;

public class Genericphysincs { 

    static float globalGravity = -18.25f;
    static public float gravity { get { return globalGravity; } }

    static public Vector3 ApplyGravity(Vector3 targetForce, ref float verticalSpeed)
    {
        verticalSpeed += globalGravity * Time.deltaTime;
        return new Vector3(targetForce.x, targetForce.y + verticalSpeed, targetForce.z);
    }
    static public Vector3 ApplyHorizontalVelocity(Vector3 targetForce, float speed)
    {
        return new Vector3(targetForce.x * speed, targetForce.y, targetForce.z * speed);
    }
}
