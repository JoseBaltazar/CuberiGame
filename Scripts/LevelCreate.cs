using UnityEngine;
using System.Collections;

public class LevelCreate : MonoBehaviour {

    public GameObject block1;

    public int gridWidth;
    public int gridHeight;

    public float spawnSpeed;

	void Start () {

        StartCoroutine(CreateWorld());
	}

    IEnumerator CreateWorld()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            yield return new WaitForSeconds(spawnSpeed);

            for (int z = 0; z < gridHeight; z++)
            {
                yield return new WaitForSeconds(spawnSpeed);

                GameObject block = Instantiate(block1, Vector3.zero, block1.transform.rotation) as GameObject;
                block.transform.parent = transform;
                block.transform.localPosition = new Vector3(x, 0, z);
            }
        }
    }
}
