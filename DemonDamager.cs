//Author: Adam Smith
//System: HTC Vive
//Platform : Unity
//This script allows a gameobject to do damage, also has the object rotating to apply force damage

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonDamager : MonoBehaviour {
	float speed = 200f;
	float damage = 5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * speed); // on collision with deltatime to regulate the speed per frame
	}
	void OnTriggerEnter(Collider other)
	{
		//VictimHealthManager.cur_health -= 20;
		other.gameObject.GetComponent<VictimHealthManager> ().TakeDamage (damage);// here add that damage  given on colliding with another colliding object
	}
}
