﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckController : MonoBehaviour {

	public GameObject waypointObj; // The parent object of the waypoints the truck should follow
	private Vector3[] waypoints;	// The actual waypoints
	private int currentWaypoint;	// The current waypoint to navigate towards
	private float speed = 0.5f;			// The distance to cover in one frame
	private float rotationSpeed = 1.0f; // The speed at which to rotate

	private bool reverse = true;	// Set to true if the animation of the truck crash should run in reverse

	// Use this for initialization
	void Start () {
		waypoints = new Vector3[7];
		for (int i = 0; i < waypoints.Length; i++) {
			waypoints [i] = waypointObj.transform.GetChild (i).position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (currentWaypoint < waypoints.Length) {
			Vector3 target = waypoints [currentWaypoint];
			Vector3 direction = target - gameObject.transform.position;
			Vector3 unitVector = direction.normalized;
			Vector3 newPos = gameObject.transform.position += speed * unitVector;
			Quaternion rotation = gameObject.transform.rotation;
			Quaternion rotateTowards = Quaternion.LookRotation (unitVector);
			gameObject.transform.SetPositionAndRotation (newPos, rotation);
			gameObject.transform.rotation = Quaternion.Slerp (rotation, rotateTowards, Time.deltaTime * rotationSpeed);

			if (CheckAdvanceWaypoint ()) {
				currentWaypoint++;
			}

		}
	}

	// Checks if the next waypoint should be targeted
	bool CheckAdvanceWaypoint() {
		float distance = Vector3.Distance (gameObject.transform.position, waypoints [currentWaypoint]);
		return distance < 0.5f;
	}
		
}
