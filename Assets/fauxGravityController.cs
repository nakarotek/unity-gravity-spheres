using UnityEngine;
using System.Collections;

public class fauxGravityController : MonoBehaviour {

	public float moveSpeed = 15;
	private Vector3 moveDir;

	void Update () {
		moveDir = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized;
	}

	void FixedUpdate () {
		rigidbody.MovePosition (rigidbody.position + transform.TransformDirection (moveDir) * moveSpeed * Time.deltaTime);
	}
}
