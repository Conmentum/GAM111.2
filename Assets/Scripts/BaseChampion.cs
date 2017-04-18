using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseChampion : MonoBehaviour {

    public int uniqueIndentification_Number;
    public GameObject attackEffect;
    public string ChampName;
    public float baseHealth;
    public float currentHealth;
    public float baseDamage;
    public float currentDamage;
    public float baseDeffence;
    public float currentDeffence;
    
    public enum ClassType
    {
        Conjuror,
        Elementalist,
        Enhancer,
        Faeber,
        Manipulator
    }
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Ancient
    }

    public ClassType champType;
    public Rarity champRarity;

    public void setAttack()
    {
        //find the MagicSpot game object that is a child of this object,
        //find the attackPrefab attached to that objects MagicSlot Script,
        //attckEffect == attackPrefab
        //if in the attacking phase (instantiate(attackEffect, transfrom.position, transform.rotation)
        //then destroy the prefab once it has completed animating.
    }
}
