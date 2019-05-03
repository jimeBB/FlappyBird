using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscript : MonoBehaviour {
	public static startscript instance;
	public GameObject spawner;
	bool clicked;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void click(){
		if(clicked==false)	Instantiate (spawner);
		transform.position = new Vector3 (-1000, 1000, 0);

		clicked = true;
	}
}
