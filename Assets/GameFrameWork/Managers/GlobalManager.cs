using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour {

	public static GlobalManager _instance;
	public static GlobalManager instance
	{
		get
		{
			if (null == _instance)
			{
				_instance = FindObjectOfType(typeof(GlobalManager))	as GlobalManager;
			}
			return _instance;
		}
	}
	public void PrintMyWord()
	{
		Debug.Log("<color>ME!!!<color>");
	}
}
