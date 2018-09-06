using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

    private Transform target;
    public float speed;
    private Vector3 rotateLocation;
    void Start ()
    {
        rotateLocation = target.transform.position;
    }
    void Update ()
    {
        this.transform.RotateAround(rotateLocation, Vector3.up, speed * Time.deltaTime);
	}
}
