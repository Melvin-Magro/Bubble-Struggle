using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D c)
	{
		//once it hit something, stop firing the spike
		SpikeControl.isTriggered = false;

		//if we hit the ball
		if (c.tag == "Ball") 
		{
			//call the splitBall function from the BallMovement script
			c.GetComponent<BallMovement> ().splitBall ();
		}
	}
}
