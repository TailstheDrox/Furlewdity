using UnityEngine;
using System.Collections;

public class BaseCharacterBody {
    //Body Type Dependant
	private string bodyType;
	private int weight;
	private int health;
	private int defence;
	private int endurance;
	private int strength;
	private int intellect;

	public string BodyType{get;set;}
	public int Weight{get;set;}
	public int Health{get;set;}
	public int Defence{get;set;}
	public int Endurance{get;set;}
	public int Strength{get;set;}
	public int Intellect{get;set;}
}
