//Author: Adam Smith
//System: HTC Vive
//Platform : Unity
//This script manages player health, allows player to receive damage, controls position of animated player, 
//so the player is not falling through the floor , destroys the damaging object and allows player to receive health.
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class VictimHealthManager : MonoBehaviour {
	public Image healthBar;//here make public the Image which will be the healthbar
	public GameObject player;//Make public the gameobject for the player
	public GameObject Demon;// Make public the gameobject that will damage the player
	public GameObject gameobj;//This public gameobject is to control the position of the player when animated
	public float max_health = 100f;//Set the maximum health to 100 as a float
	public float cur_health = 0f;//Set current health
	public bool alive = true;// set true or false for if player is alive

	// Use this for initialization of health bar script
	void Start () {
		cur_health = max_health;
		SetHealthBar ();

	}
	public void TakeDamage(float amount)// so player is able to take damage
	{
		if (!alive) {
			return;
		}
		if (cur_health <= 0)
		{
			
			player.GetComponent<Animator>().SetTrigger("isdead");// here animation that will be played if player's health is 0 and less 
			Destroy (Demon);// make the gameobject causing the damage to disappear
		}

		cur_health -= amount;
		SetHealthBar ();

	}
	public void GetHealth(float amount)
	{
		if (!alive) {
			return;
		}
		if (cur_health >= 20)
		{
			
			player.transform.position = gameobj.transform.position; // Here we access the gameobject that will be = to position of player
			player.GetComponent<Animator>().SetTrigger("isStanding");// Aniamtion is played for player once health is restored

		}

		cur_health += amount;
		SetHealthBar ();

	}

	public void SetHealthBar () {
		float my_health = cur_health / max_health;
		healthBar.transform.localScale = new Vector3 (Mathf.Clamp (my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z); // here controls the healthbar attached to player
	}
}