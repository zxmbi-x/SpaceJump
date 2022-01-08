using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	// follow the player only when jumping up
	public Transform target;

	void LateUpdate()
	{
		if (target != null && target.position.y > transform.position.y)
		{
			Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		}

		GameManager.instance.AddScore((int)transform.position.y);
	}
}
