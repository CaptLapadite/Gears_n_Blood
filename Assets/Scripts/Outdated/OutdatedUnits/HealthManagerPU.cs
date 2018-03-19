﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagerPU : HealthManager {

	void Start ()
	{
		unit = GetComponent<Unit> ();
	}

	public override void Damage (float damage, DamageBehavior dmgBehavior)
	{
		dmgBehavior.DealDamage (this, damage);

		if (health <= 0f)
		{
			unit.DestroyUnit ();
			unit.uiSquadDisplay.gameObject.SetActive (false);
			return;
		}

		UpdateDisplay ();
	}

	public override void UpdateDisplay ()
	{
		//Update healthbar



		//Update player's hud
		unit.uiSquadDisplay.UpdateHealth ();
	}
}