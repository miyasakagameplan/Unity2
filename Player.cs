using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float speed = 3.0f;

	void Update(){
		var dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.z = Input.acceleration.z;

		if(dir.sqrMagnitude > 1){
			dir.Normalize();
		}

		dir *= Time.deltaTime;

		transform.Translate(-dir * speed);
	}
}
