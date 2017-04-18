using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionSlot : MonoBehaviour {

    public GameObject champ;

    public void SpawnChamp()
    {
        Instantiate(champ, transform.position, transform.rotation);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
