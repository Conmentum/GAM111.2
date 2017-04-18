using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TurnManager : MonoBehaviour {

    public enum TurnStates
    {
        Draw,
        Placement,
        Battle,
        DamageStep,
        SecondPlacement,
        End
    }

    public TurnStates turnState;

    public void SetState()
    {

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
