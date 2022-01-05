using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
	[SerializeField] private Transform followObject;
	[SerializeField] private float VelocityLookObject = 2;

    void Start()
    {
		FindPlayer();
	}

    void Update()
    {
		if(followObject == null)
		{
			FindPlayer();
			return;
		}

		transform.position = new Vector3(
			transform.position.x + ((followObject.position.x - transform.position.x) / (VelocityLookObject)),
			transform.position.y + ((followObject.position.y - transform.position.y) / (VelocityLookObject)),
			transform.position.z);

	}

	private void FindPlayer()
	{
		if (followObject == null)
			followObject = GameObject.FindGameObjectWithTag("Player").transform;
	}
}
