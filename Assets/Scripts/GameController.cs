using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GameObject champ_SelectionUI;
    public GameObject spell_SelectionUI;
    public GameObject General_UI;
    public int summoner_StonesCount;
    public Text summoner_stonesText;

    public Text turnState_Text;

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
        summoner_StonesCount = 0;
        champ_SelectionUI.SetActive(true);
        spell_SelectionUI.SetActive(false);
        General_UI.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (curSpell_Cards >= maxSpell_Cards)
        {
            //display done button
        }
	}
    void AddChampsToDeck()
    {

    }
    void AddSpellsToDeck()
    {
        //Takes the selected cards and adds them to the SpellDeck
    } 
    public enum TurnStates
    {
        Start,
        Draw,
        Wait,
        Place,
        Battle,
        Place2,
        End
    }
    public TurnStates turnState;

    public void SetTurnState()
    {

    }
    void OnEndTurn()
    {

    }
    void OnNextPhase()
    {

    }
}
