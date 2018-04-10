using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour {


	public Vector2 initial;
	public Rigidbody2D rb;
	public GameObject nextBall;

	// Use this for initialization
	void Start () 
	{
		//a force is applied to the rigidbody of the ball
		rb.AddForce (initial, ForceMode2D.Impulse);		
	}

	public void splitBall()
	{
		if (nextBall != null) 
		{
			//brings out 2 copies of the ball; one to the right and one to the left  
			GameObject ball1 = Instantiate (nextBall, rb.position + Vector2.right / 6f, Quaternion.identity);
			GameObject ball2 = Instantiate (nextBall, rb.position + Vector2.left / 6f, Quaternion.identity);

			//when the balls are split, they get a force of 2 on the X axis and 5.5 on the Y axis
			ball1.GetComponent<BallMovement> ().initial = new Vector2 (2f, 5.5f);
			ball2.GetComponent<BallMovement> ().initial = new Vector2 (-2f, 5.5f);
		}

		//destroys the gameobject which is the ball
		Destroy (gameObject);
	}
		
}

