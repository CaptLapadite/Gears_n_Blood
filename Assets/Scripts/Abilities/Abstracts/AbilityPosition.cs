﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityPosition : ScriptableObject {

	public abstract Vector3 eventPos (GameUnit caster, Vector3 target);

}