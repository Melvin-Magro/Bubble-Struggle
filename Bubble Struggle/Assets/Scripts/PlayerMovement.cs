using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	//The speed at which the player can move at
	public float playerSpeed = 5f;
	SpriteRenderer renderer;

	void Awake()
	{
		renderer = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () 
	{
		//moves the player according to the player speed on the X axis
		float h = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (h, 0, 0) * playerSpeed * Time.deltaTime;
		transform.Translate (movement);

		//image sprite of player will flip on the X axis, making him look as if he is facing right
		if (movement != Vector3.zero) 
		{
			renderer.flipX = movement.x > 0f;
		}
	}

	public void OnCollisionEnter2D(Collision2D c)
	{
		//if a ball hits the player, loads game over scene 
		if (c.collider.tag == "Ball") 
		{
			Debug.Log ("gameover");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
