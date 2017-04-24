using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCard_selection : MonoBehaviour {
	public List<GameObject> SelectedSpells;
	public GameObject uniqueSpell_Prefab;
    public Text spellCard_Name;
    public Text cardType_Text;
    public enum CardType
    {
        Enhancer,
        Elementalist,
        Faeber,
        Manipulator,
        Conjurer,
        Unknown
    }
    public CardType cardType;

	// Use this for initialization
	void Start () {
        spellCard_Name.text = gameObject.name.ToString();
        cardType_Text.text = cardType.ToString();
	}
	
    void AddSpellTo_Deck()
    {
		
    }
}
