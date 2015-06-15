using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	private BaseCharacterSpecies class1 = new BaseCanineSpecies();
	private BaseCharacterBody class2 = new BaseCanineAverage();
	private BaseCharacterBody class3 = new BaseCanineMuscled();
	private BaseCharacterBody class4 = new BaseCanineChubby();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUILayout.Label(class1.CharacterSpecies);
		GUILayout.Label(class1.CharacterSpeciesDescription);
		GUILayout.Label(class2.BodyType);
		GUILayout.Label(class3.BodyType);
		GUILayout.Label(class4.BodyType);
	}
}
