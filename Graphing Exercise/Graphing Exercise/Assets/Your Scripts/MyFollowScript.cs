using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFollowScript : MonoBehaviour {

    public GameObject target;
    public float speed;
    public Vector3 dir;
    public float dist;

	// Use this for initialization
	void Start () {
        speed = .5f;
	}
	
	// Update is called once per frame
	void Update () {
        dist = Mathf.Sqrt(Mathf.Pow(this.transform.position.x - target.transform.position.x, 2) + 
            Mathf.Pow(this.transform.position.y - target.transform.position.y, 2));
        dir = target.transform.position - transform.position;
        dir.Normalize();
        this.transform.LookAt(transform.position + dir);
        this.transform.position = this.transform.position + dir * dist *Time.deltaTime;
	}
}
