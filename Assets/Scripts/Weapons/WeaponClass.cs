﻿// Name: Samantha Spray
// Project: Cyber-Dino Racing
// Date: 11/27/13

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponClass : MonoBehaviour {

	// Class Variables and Properties
	
	// Damage Variables
	[SerializeField]
	protected float damage; // The ammount of damage the weapon can cause.
	public float Damage
	{
		get
		{
			return damage;
		}
		set
		{
			damage = value;
		}
	}
	
	protected float damageDeduction; // Do not change this variable in Unity, the ammount of damage the racer's armor will take away from the weapon's total damage.
	public float DamageDeduction
	{
		get
		{
			return damageDeduction;
		}
		set
		{
			damageDeduction = value;
		}
	}
	
	protected float finalDamage; // Do not change this variable in Unity,the ammount of damage that will be dealt to the racer, damage minus damageDeduction.
	public float FinalDamage
	{
		get
		{
			return finalDamage;
		}
		set
		{
			finalDamage = value;
		}
	}
	
	
	//DealDamage
    //Purpose: Takes the float variable armor from a racer object, calculates the final ammount of damage based on the weapon's damage and the racer's armor.
	//Parameters: float armor
    //Returns: float finalDamage
	public float DealDamage(float rArmor){
		FinalDamage = Damage;
		DamageDeduction = rArmor * Damage;
		FinalDamage -= DamageDeduction;
		return FinalDamage;
	}
}
