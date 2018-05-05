using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PlayAdvertise : MonoBehaviour {

	void Awake ()
    {
        Advertisement.Initialize("1789890");
	}
	
    public void ShowAds()
    {
        Advertisement.Show();
    }
}
