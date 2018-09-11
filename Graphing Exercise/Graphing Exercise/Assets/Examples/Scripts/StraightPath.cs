using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightPath : MonoBehaviour {

	public Transform arrow;
	public float speed;

	void Update () {
		arrow.position += new Vector3( Time.deltaTime * speed, 0f, 0f );
	}
}
