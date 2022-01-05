using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		CheckInput();
		
    }

	private void CheckInput()
	{
		if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
			transform.position += Vector3.up;

		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
			transform.position += Vector3.left;

		if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
			transform.position += Vector3.down;

		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
			transform.position += Vector3.right;


		if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Comma))
			transform.Rotate(Vector3.forward * 90);

		if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Colon))
			transform.Rotate(Vector3.back * 90);
	}
}
