using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
	public float jumpforce =4.1f; 
	bool added;
	public GameObject playbut;
	Rigidbody2D mybody; 
	Animator myanim;


	// Use this for initialization
	void Start () {
		myanim = GetComponent<Animator> ();
		mybody = GetComponent<Rigidbody2D> ();

	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

			if (added == false) {
				//gameObject.AddComponent<Rigidbody2D> ();
	
				added = true;
			}
			float angel;  
			if (mybody.velocity.y > 0) {
				angel =	Mathf.Lerp (0, 90, mybody.velocity.y / 7);
				transform.rotation = Quaternion.Euler (0, 0, angel);
			} else if (mybody.velocity.y <= 0) {
				angel = Mathf.Lerp (0, -90, -mybody.velocity.y / 7);
				transform.rotation = Quaternion.Euler (0, 0, angel);
			}

	}
	public void birdjump(){
		mybody.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;

			if (myanim.GetBool ("died") == false) {

				mybody.velocity = new Vector2 (mybody.velocity.x, jumpforce);
				 
			}

	
		}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "space") {
			
			gameeditor.instance.score++;

		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "pipe") {
			if (myanim.GetBool ("died") == false) {
			
			}
			myanim.SetBool ("died", true);
			Instantiate(playbut);

		}
	}

}
