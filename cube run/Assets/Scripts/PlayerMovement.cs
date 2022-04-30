using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;
	public float forwardForce;
	public float slideForce;
	public float jumpForce;
	public float backwardForce;
	public int var;

	void FixedUpdate()
	{
		rb.AddForce(0,0,forwardForce * Time.deltaTime);
		if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(slideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-slideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("s"))
		{
			rb.AddForce(0,0,-1*backwardForce*Time.deltaTime);
		}
		if (Input.GetKey("w")||Input.GetKey("space"))
		{
			rb.AddForce(0,jumpForce*Time.deltaTime,0);
		}
		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
