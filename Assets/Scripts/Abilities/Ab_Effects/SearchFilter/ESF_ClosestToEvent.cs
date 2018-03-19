﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "ClosestToEvent", menuName = "Abilities/Effects/SearchFilters/Closest to event", order = 37)]
public class ESF_ClosestToEvent : EffectSearchFilter {

	public int maxAmountOfTargets = 1;

	public override List<GameUnit> SearchFilter (List<GameUnit> targets, GameUnit caster, Vector3 target, EventCaster eventCaster)
	{
		if (targets.Count <= maxAmountOfTargets)
		{
			return targets;
		}

		List<TargetUnit> sortableList = new List<TargetUnit>();

		foreach (GameUnit unit in targets)
		{
			sortableList.Add (new TargetUnit (unit, GetMinusSqrDist(eventCaster.transform.position, unit.transform.position)));
		}
		sortableList.Sort();

		List<GameUnit> filteredList = new List<GameUnit>();

		int amount = Mathf.Clamp (sortableList.Count, 1, maxAmountOfTargets);

		for (int i = 0; i < amount; i++)
		{
			filteredList.Add(sortableList[i].unit);
		}

		return filteredList;
	}

}
