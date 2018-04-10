using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour {

	//the total number of balls
	public int BallCount = 15;

	void Update ()
	{		
		//if there are no more balls then load the congratulations screen
		if (BallCount == 0) 
		{
			SceneManager.LoadScene ("CongratulationsScreen");
		}
	}

	public void OnTriggerEnter2D(Collider2D c)
	{
		//once it hit something, stop firing the spike
		SpikeControl.isTriggered = false;

		//if we hit the ball
		if (c.tag == "Ball") 
		{
			//number of balls decreased
			BallCount--;
			//call the splitBall function from the BallMovement script
			c.GetComponent<BallMovement> ().splitBall ();
		}
	}
}
