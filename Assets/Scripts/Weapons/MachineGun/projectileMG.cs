﻿// Name: Samantha Spray
// Project: Cyber-Dino Racing
// Date: 11/29/13

using UnityEngine;
using System.Collections;

public class projectileMG : ProjectileClass {
	
	//Class Variables	
	private RacerHealthClass theRacer; // Used to access variables on a racer.
	
	
	void Start(){
	
		
	}
	
	// Update is called once per frame
	void Update () {
	
		FireProjectileFunc();
		Physics.IgnoreLayerCollision(8, 9);
		
	}
	
	//OnTriggerEnter
    //Purpose: detects when the projectile hits an object with the tag "Racer," the projectile will get the health variable 
	//			from the object and call the DealDamage function then destroy itself.
	//Parameters: Collider other
    //Returns: void
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag == "Weapon"){
			Physics.IgnoreCollision(this.collider, other);
		}
		else if(other.gameObject.tag == "Racer"){
			Debug.Log("Hit Racer");
			theRacer = other.gameObject.GetComponent<RacerHealthClass>();
			theRacer.Health -= DealDamage(theRacer.Armor);
			Destroy(gameObject);
		}
	}
}
