﻿using System.Runtime.InteropServices;
using UnityEngine;

namespace _Scripts.ItemDescription
{
	[CreateAssetMenu(fileName = "Tooltips", menuName = "Other/ScriptableDialogue", order = 1)]
	public class ScriptableDialogue : ScriptableObject
	{
		[SerializeField] public uint[] FacesOrder;
		[SerializeField] public Sprite[] Faces;
		[SerializeField] public string[] Speakers;
		[SerializeField] public string[] Speeches;
	}
}
