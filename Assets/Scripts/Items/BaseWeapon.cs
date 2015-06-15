using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes{
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHEILD,
		POLEARM
	}
	private WeaponTypes weaponType;
	private int spellEffectID;

	public WeaponTypes WeaponType{get;set;}
	public int SpellEffectID{get;set;}
}
