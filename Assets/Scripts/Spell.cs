using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "Spell")]
public class Spell : ScriptableObject
{

	public new string name;
	public string description;

	public Sprite artwork;

	public string effect;

	public void Print()
	{
		Debug.Log(name + ": " + description + " The spell does " + effect);
	}

}
