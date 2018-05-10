using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharcter : MonoBehaviour {

    public bool isSelected;
    [HideInInspector]
    public bool reset;
    public int characterIndex;

    Animator anim;

    CharSelectManager manager;
	
	void Start ()
    {
        anim = GetComponent<Animator>();
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<CharSelectManager>();
        isSelected = false;
	}
	
	
	void FixedUpdate ()
    {
        if(characterIndex == PlayerPrefs.GetInt("Character"))
        {
            anim.SetBool("isSelected", isSelected); 
        }

        if (isSelected && reset)
        {
            isSelected = false;
            reset = false;
            anim.SetBool("isSelected", isSelected);
            return;
        }
	}

	private void OnMouseDown()
	{
        if(!isSelected)
        {
            isSelected = true;
            manager.ResetIcon();
            PlayerPrefs.SetInt("Character", characterIndex);
            return;
        }
	}
}
