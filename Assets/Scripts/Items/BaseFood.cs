using UnityEngine;
using System.Collections;

public class BaseFood : BaseStatItem {

	public enum FoodTypes{
		BACON,
		CARROT,
		STEAK,
		PIZZA
	}
	private FoodTypes foodType;
	private int spellEffectID;
	
	public FoodTypes FoodType{get;set;}
	public int SpellEffectID{get;set;}
}
