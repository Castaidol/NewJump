using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectManager : MonoBehaviour {

    public List<GameObject> charList = new List<GameObject>();

	void Start () 
    {

        foreach(GameObject character in GameObject.FindGameObjectsWithTag("CharIcon"))
        {
            charList.Add(character);
        }
        //Debug.Log(charList.Count);
	}
	
    public void ResetIcon()
    {
        foreach(GameObject character in charList)
        {
            var charact = character.GetComponent<SelectCharcter>();

            charact.reset = true;
        }
    }
}
