using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public Rigidbody2D bullet;
	public int speed = 20;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("c")) {
			Rigidbody2D clone = Instantiate(bullet, transform.position, transform.rotation);
			clone.velocity = transform.TransformDirection(new Vector2 (speed,0));
			Destroy(clone.gameObject, 1);
		}
	}
}
