using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStraightPath : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(transform.position.x + 1 * Time.deltaTime, 0);
	}
}
