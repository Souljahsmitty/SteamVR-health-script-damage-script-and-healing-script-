//Author: Adam Smith
//System: HTC Vive
//Platform : Unity
//This script allows the player or another gameobject set to do so , to receive health

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLSscript : MonoBehaviour {
	float revive = 30f;


	// On colliding with victim health is restored
	void OnTriggerEnter(Collider other)
	{
		other.gameObject.GetComponent<VictimHealthManager> ().GetHealth (revive);// On collision with player some health is restored each time 
	}
}