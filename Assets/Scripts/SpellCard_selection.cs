using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCard_selection : MonoBehaviour {
	public GameObject uniqueSpell_Identifier;
    public Text spellCard_Name;
    public Text cardType_Text;
    public bool addTo_Deck;
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
        addTo_Deck = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void AddSpellTo_Deck()
    {
        //toggle addTo_deck;
    }
}
