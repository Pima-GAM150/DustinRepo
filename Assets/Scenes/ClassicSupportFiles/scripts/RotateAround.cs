using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

    public float speed;
    public Vector3 target;
    

    void Update ()
    {
        this.transform.RotateAround(target, Vector3.up, speed * Time.deltaTime);
	}

}
