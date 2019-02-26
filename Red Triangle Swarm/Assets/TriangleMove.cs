﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMove : MonoBehaviour {

    public GameObject player;
    public float speed;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.forward = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
	}
}
