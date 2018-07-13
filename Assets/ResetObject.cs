using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour {
	Vector3 originPos;
	Quaternion originRot;
	void Awake() {
		originPos = gameObject.transform.localPosition;
		originRot = gameObject.transform.localRotation;

		// Fixed: Unity 2018.20f physic object will fall through the ground plane detection
		FreezePostionY(true);
	}
	public void Reset() {
		gameObject.transform.localPosition = originPos;
		gameObject.transform.localRotation = originRot;
	}

	public void FreezePostionY(bool freeze) {
		Rigidbody rb = gameObject.GetComponent<Rigidbody>();
		if (rb) {
			if (freeze) {
				rb.constraints |= RigidbodyConstraints.FreezePositionY;
			} else {
				rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
			}
		}
	}
}
