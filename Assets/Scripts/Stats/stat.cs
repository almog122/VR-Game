﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{

	[SerializeField]
	private int baseValue;

	public int getValue()
	{
		return baseValue;
	}

	public void setValue(int value)
	{
		baseValue = value;
	}
}
