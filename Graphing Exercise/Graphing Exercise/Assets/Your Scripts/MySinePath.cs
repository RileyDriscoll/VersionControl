using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySinePath : MonoBehaviour {
    private float x;
	// Update is called once per frame
	void Update () {
        x = this.transform.position.x + .3175f * Time.deltaTime;

        this.transform.position = new Vector3(x, Mathf.Sin(x*Mathf.PI));

        Vector3 diff = new Vector3(x + Time.deltaTime, Mathf.Sin((x + Time.deltaTime) * Mathf.PI));

        this.transform.LookAt(diff);
    }
}
