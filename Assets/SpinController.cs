using UnityEngine;
using System.Collections;

public class SpinController : MonoBehaviour {
	class KeyPush {
		public void reset() {
			right = false;
			left = false;
			forward = false;
			back = false;
			rightSpin = false;
			leftSpin = false;
		}
		public bool right;
		public bool left;
		public bool forward;
		public bool back;
		public bool rightSpin;
		public bool leftSpin;

	}
	private KeyPush keyPush;
	private const float ANGLE = 1.0f;

	[SerializeField]
	private GameObject globe;

	void Start() {
		keyPush = new KeyPush();
		Validate();
	}

	void Validate() {
		Debug.Assert(globe != null);
	}

	void Reset() {
		globe.transform.localRotation = new Quaternion();
	}

	void Update () {
		keyPush.reset();

		if (Input.GetKey(KeyCode.RightArrow)) {
			keyPush.right = true;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			keyPush.left = true;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			keyPush.forward = true;
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			keyPush.back = true;
		}
		if (Input.GetKey(KeyCode.Z)) {
			keyPush.leftSpin = true;
		}
		if (Input.GetKey(KeyCode.X)) {
			keyPush.rightSpin = true;
		}
		if (Input.GetKey(KeyCode.R)) {
			Reset();
		}

		if (keyPush.right) {
			globe.transform.Rotate(new Vector3(0, 1, 0), -ANGLE);
		}
		if (keyPush.left) {
			globe.transform.Rotate(new Vector3(0, 1, 0), ANGLE);
		}
		if (keyPush.forward) {
			globe.transform.Rotate(new Vector3(0, 0, 1), ANGLE);
		}
		if (keyPush.back) {
			globe.transform.Rotate(new Vector3(0, 0, 1), -ANGLE);
		}
		if (keyPush.leftSpin) {
			globe.transform.Rotate(new Vector3(1, 0, 0), -ANGLE);
		}
		if (keyPush.rightSpin) {
			globe.transform.Rotate(new Vector3(1, 0, 0), ANGLE);
		}

    
	}
}
