﻿using UnityEngine;
using System.Collections;

public class SnakeBehavior : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Destroy (GetComponent<PolygonCollider2D>());
		gameObject.AddComponent<PolygonCollider2D> ();
		}
	}


