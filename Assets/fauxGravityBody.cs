using UnityEngine;
using System.Collections;

public class fauxGravityBody : MonoBehaviour {

	public fauxGravityAttractor attractor;
	private Transform myTransform;
	
	void Start () {
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		rigidbody.useGravity = false;
		myTransform = transform;

	
	}
	
	void Update () {
		attractor.Attract(myTransform);

	}
}
