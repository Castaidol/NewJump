using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public bool goToTitleScreen;
    public bool goToCharSelect;
    public bool goToWeaponSelect;
    public bool goToLevelSelect;
    public bool goToGame;

    private int sceneIndex;

	private void Start()
	{
        if (goToTitleScreen == true) sceneIndex = 0;
        else if (goToCharSelect == true) sceneIndex = 1;
        else if (goToWeaponSelect == true) sceneIndex = 2;
        else if (goToLevelSelect == true) sceneIndex = 3;
        else if (goToGame == true) sceneIndex = 4;
        else sceneIndex = 1;
	}

	public void GoToScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
