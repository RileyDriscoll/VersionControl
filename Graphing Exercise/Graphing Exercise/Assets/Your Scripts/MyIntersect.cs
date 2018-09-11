using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIntersect : MonoBehaviour {

    public GameObject target;
    public float speed;
    private float x;
    private float y;
    private Vector3 dir;

	// Use this for initialization
	void Start () {
        speed = Random.Range(.5f, 30f);

	}
	
	// Update is called once per frame
	void Update () {
		if(target != null)
        {
            x = target.transform.position.x;
            y = target.transform.position.y;
        }

        dir = new Vector3(x, y) - this.transform.position;
        dir.Normalize();

    }


}
