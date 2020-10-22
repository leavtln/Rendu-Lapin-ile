using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour

{
	void Update()

	{

		Vector3 move = new Vector3();

		if (Input.GetKey(KeyCode.UpArrow))

			move.z += 0.1f;

		if (Input.GetKey(KeyCode.DownArrow))

			move.z -= 0.1f;

		if (Input.GetKey(KeyCode.LeftArrow))

			move.x -= 0.1f;

		if (Input.GetKey(KeyCode.RightArrow))

			move.x += 0.1f;

		transform.position += move;

	}
}