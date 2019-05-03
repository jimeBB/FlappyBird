using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	float x =0;
	public GameObject pipe;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update ()
	{

			x++;

			if (x == 50) {
				x = 0;
				Instantiate (pipe, new Vector3 (3, Random.Range (-1.1f, 3.7f), 0), Quaternion.identity);
			}
		}

}
