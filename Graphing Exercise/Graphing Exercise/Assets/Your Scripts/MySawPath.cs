using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySawPath : MonoBehaviour {

    private float x;
    private float y;
    public float speed;

    private void Start(){
        this.transform.Rotate(new Vector3(-45, 0, 0));
        speed = .5f;
    }
    // Update is called once per frame
    void Update () {
        x = transform.position.x;
        y = transform.position.y;

        this.transform.position = new Vector3(x + Time.deltaTime * speed, y + Time.deltaTime * speed);
        
        if(this.transform.position.y > 1)
        {
            this.transform.position = new Vector3(x, -1);
        }
	}
}
