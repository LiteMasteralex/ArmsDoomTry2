using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Alive") {
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		} else if (col.gameObject.tag == "Player") {
			Debug.Log("End Game");
		} else {
			Destroy(this.gameObject);
		}
	}
}
