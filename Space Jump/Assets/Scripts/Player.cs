using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

	public float movementSpeed = 10f;
	Rigidbody2D rb;
	float movement = 0f;

	// start is for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// update is called once per frame
	void Update()
	{
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}