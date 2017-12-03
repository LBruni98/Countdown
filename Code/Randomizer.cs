using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomizer : MonoBehaviour {
	public GameObject TextBox;

	public void RandomGeneratorConsonant() {
		string Consonants = "BCDFGHJKLMNPQRSTVWXYZ";
		char c = Consonants [Random.Range (1, Consonants.Length)];
		TextBox.GetComponent<Text> ().text = "" + c;
	}

	public void RandomGeneratorVowel() {
		string Vowel = "AEIOU";
		char v = Vowel [Random.Range (1, Vowel.Length)];
		TextBox.GetComponent<Text> ().text = "" + v;
	}
}
