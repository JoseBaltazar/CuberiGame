using UnityEngine;
using System.Collections;

public class Waypoints : MonoBehaviour
{


	public bool Patron;
	public float speed;
	public Transform[] waypoints;

	private Transform target;
	private int currentTarget = 0;

	public Transform Esfera;
	// Use this for initialization
	void Start()
	{


		transform.position = waypoints[0].position;
		target = waypoints[1];
		currentTarget = 1;
		Patron = true;

	}

	// Update is called once per frame
	void Update()
	{
		if (Patron)
		{

			Esfera.transform.LookAt(target.position);

			float step = speed * Time.deltaTime;

			transform.position = Vector3.MoveTowards(transform.position, target.position, step);

			if (transform.position == target.position)
			{



				if (currentTarget == waypoints.Length - 1)
				{
					currentTarget = -1;
				}
				target = waypoints[currentTarget + 1];
				currentTarget++;



			}

		}
	}




}
