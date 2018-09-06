using System.Collections;
using System;
using UnityEngine;
using System.Collections.Generic;

public class Prefabs : MonoBehaviour {

    public GameObject cube;

    private List<GameObject> cubes;
    private RotateAround script;

	void Start ()
    {
        MakeCubes();

        SetRotationTargets();
	}

    void MakeCubes()
    {
        cubes = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            Instantiate(cube, new Vector3(-5 + i, 0, 1), Quaternion.identity);
            cubes.Add(cube);
        }
    }
    void SetRotationTargets()
    {
        System.Random rnd = new System.Random();
        float speed;
        Vector3 location;
        GameObject c;

        for(int i = 0; i < 10; i++)
        {
            speed = rnd.Next(25,65);

            location = new Vector3( -5, 0, 1);
            c = cubes[i];
            c.GetComponent<RotateAround>().speed = speed;
            c.GetComponent<RotateAround>().target = location;

        }
    }
	
}
