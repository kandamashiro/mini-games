﻿using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

    public GameObject ballPrefab;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1)) {
            Instantiate(ballPrefab);
        }	
	}
}
