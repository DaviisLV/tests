﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjZ : MonoBehaviour {
    public int speed = 2;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 15f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
