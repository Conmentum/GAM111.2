using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GameObject champ_SelectionUI;
    public GameObject spell_SelectionUI;
    public int summoner_StonesCount;
    public Text summoner_stonesText;
    public Text phaseText;

	// Use this for initialization
	void Start () {
        summoner_StonesCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void AddCardToDeck()
    {
        //onMouseClick set champ to enabled
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
