using UnityEngine;
using System.Collections;

public class SphereManager : MonoBehaviour {

	private Vector3 initialPosition;

	void Start () {
		initialPosition = this.transform.position;	
	}

	void Initialize() {
		this.transform.position = initialPosition;
		this.GetComponent<Rigidbody>().velocity = Vector3.zero;
	}

	void Update () {
		if (this.transform.position.y < -10) {
			Initialize();
		}
	}
}
