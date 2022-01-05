using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTable : MonoBehaviour
{
	[SerializeField] private GameObject player;
	
	private bool[,] table;
	private GameObject cachedPlayer;


	private void Awake()
	{
		this.table = new bool[10, 10];
	}

	void Start()
    {
		table[0, 0] = true;
		GenerateInitialTable();
	}

	private void Update()
	{
		if(cachedPlayer.transform.position.y <= -8)
		{
			Debug.Log("EXIT CALLED");
		}
	}

	private void GenerateInitialTable()
	{
		for(int a=0; a< table.GetLength(1); a++)
		{
			for(int b=0; b<table.GetLength(0); b++)
			{
				if (table[b, a])
					cachedPlayer = Instantiate(player, new Vector3(b,-a,1), Quaternion.identity, transform);
			}
		}
	}

}
