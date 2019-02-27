using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMove : MonoBehaviour {

    public GameObject player;
    public float speed;
    
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = Random.Range(1f,3f);
	}
	
	void Update () {
        if (player != null)
        {
            transform.forward = player.transform.position;

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
	}    
}
