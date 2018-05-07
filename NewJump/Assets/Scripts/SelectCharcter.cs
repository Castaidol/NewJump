using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharcter : MonoBehaviour {

    public bool isSelected;

    Animator anim;
	
	void Start ()
    {
        anim = GetComponent<Animator>();
        isSelected = false;
	}
	
	
	void Update ()
    {
		
	}

	private void OnMouseDown()
	{
        if(!isSelected)
        {
            isSelected = true;
            anim.SetBool("isSelected", isSelected);
            return;
        }

        if(isSelected)
        {
            isSelected = false;
            anim.SetBool("isSelected", isSelected);
            return;
        }
       
	}
}
