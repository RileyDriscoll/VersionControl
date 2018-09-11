using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceRandomly : MonoBehaviour {

	public Transform objectToPlace;

	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;

	void Awake() {
		float x = Random.Range( xMin, xMax );
		float y = Random.Range( yMin, yMax );

		objectToPlace.position = new Vector3( x, y, 0f );
	}
}
