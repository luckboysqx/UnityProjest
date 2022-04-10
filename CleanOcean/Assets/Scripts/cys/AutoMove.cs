﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour {
    public float speed = 1f;
    public Vector3 dir = Vector3.right;
	// Update is called once per frame
	void Update () {
        transform.Translate(dir * speed * Time.deltaTime);
        
	}
}
