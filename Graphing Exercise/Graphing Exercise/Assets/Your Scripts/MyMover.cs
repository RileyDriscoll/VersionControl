using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMover : MonoBehaviour {

    private float x;
    private float y;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {
            this.transform.position = new Vector3(transform.position.x + Time.deltaTime, transform.position.y);
        }

        if (Input.GetKey("a"))
        {
            this.transform.position = new Vector3(transform.position.x - Time.deltaTime, transform.position.y);
        }

        if (Input.GetKey("s"))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime);
        }
    }
}
