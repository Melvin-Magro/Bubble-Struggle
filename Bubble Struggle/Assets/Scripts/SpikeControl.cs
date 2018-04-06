using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeControl : MonoBehaviour {

	public Transform player;
	public static bool isTriggered = false;
	public float speedSpike = 0.8f;	

	// Use this for initialization
	void Start () 
	{
		isTriggered = false;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("space")) 
		{
			isTriggered = true;
		}
		if (isTriggered) 
		{
			//if the spike is triggered (by pressing space), then the spike will start to go up gradually on the Y axis
			transform.localScale = transform.localScale + Vector3.up * speedSpike * Time.deltaTime;
		} 

		else 
		{
			transform.position = player.position;
			transform.localScale = new Vector3 (1f, 0f, 1f);
		}
		
	}
}
