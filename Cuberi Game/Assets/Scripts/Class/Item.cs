using UnityEngine;

public class Item : MonoBehaviour {

    public int cx5Value, cx10Value, cx20Value;
    public float c5sRot, c10sRot, c20sRot;

    void Start()
    {
        cx5Value = 5;
        cx10Value = 10;
        cx20Value = 20;

        c5sRot = 200;
        c10sRot = 300;
        c20sRot = 400;

    }
}
