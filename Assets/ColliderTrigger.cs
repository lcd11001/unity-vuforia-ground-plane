using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour {

	private void OnTriggerEnter(Collider other) {
		Debug.Log("OnTriggerEnter " + other.name);
		Rigidbody rb = other.GetComponent<Rigidbody>();
		if (rb) {
			rb.constraints |= RigidbodyConstraints.FreezePositionY;
		}
	}
}
