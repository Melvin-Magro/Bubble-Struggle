using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	//The speed at which the player can move at
	public float playerSpeed = 5f;

	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (h, 0, 0) * playerSpeed * Time.deltaTime;
		transform.Translate (movement);
	}

	public void OnCollisionEnter2D(Collision2D c)
	{
		if (c.collider.tag == "Ball") 
		{
			Debug.Log ("gameover");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
