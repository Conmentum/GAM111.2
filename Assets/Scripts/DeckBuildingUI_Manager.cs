using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckBuildingUI_Manager : MonoBehaviour {
	public GameObject champ_SelectionUI;
	public GameObject spell_SelectionUI;
	public GameObject General_UI;

	public int curChampCards;
	public int maxChampCards;

	public int curSpell_Cards;
	public int maxSpell_Cards;
	public Text enhancerSpell_count;
	public Text elementalistSpell_count;
	public Text faeberSpell_count;
	public Text manipulatorSpell_count;
	public Text conjurerSpell_count;

	// Use this for initialization
	void Start () {
		champ_SelectionUI.SetActive(true);
		spell_SelectionUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (GameController.TurnStates == GameController.TurnStates.Start) {
		if (curSpell_Cards >= maxSpell_Cards)
		{
			//display done button
		}
		if (curChampCards >= maxChampCards) 
		{
			//display done button
		}
	}
	public void AddChampsToDeck()
	{
		//Takes the selected cards and adds them to the ChampDeck
		champ_SelectionUI.SetActive(false);
		spell_SelectionUI.SetActive (true);

	}
	public void AddSpellsToDeck()
	{
		//Takes the selected cards and adds them to the SpellDeck
		spell_SelectionUI.SetActive (false);
		General_UI.SetActive (true);
	} 
}