using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public Rigidbody2D enemy;
	public float maxSpeed = 5f;
	private float direction = 1f;
	private bool facingRight = true;
	public float jumpForce = 11f;
	public float jumpCooldown = 15f;

	// Use this for initialization
	void Update () {
		enemy.velocity = new Vector2(direction * maxSpeed, enemy.velocity.y);
		if(jumpCooldown < 0f) {
			enemy.velocity = new Vector2(0, jumpForce);
			jumpCooldown = 15f;
		}
		jumpCooldown -= 0.1f;
	}

	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {
		if(col.gameObject.tag == "Player") {
			GameController.EndGame();
		}
		if(col.gameObject.tag == "Wall" || col.gameObject.tag == "Player") {
			Flip();
		}
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		direction *= -1;
	}

}
