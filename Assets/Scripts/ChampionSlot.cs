using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionSlot : MonoBehaviour {

    public GameObject champ;

    public void OnMouseUp()
    {
        Instantiate(champ, transform.position, transform.rotation);

    }
	// Use this for initialization
	void Start () {
        if (champ == null)
        {
            return;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
