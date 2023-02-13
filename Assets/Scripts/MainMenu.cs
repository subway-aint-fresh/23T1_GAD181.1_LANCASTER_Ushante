using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // need a feature that loads X scene when button is clicked
    [SerializeField] private int sceneToLoad;
    public void PlayGame()
    {
        //LOAD THE SPECIFIED SCENE
        SceneManager.LoadScene(sceneToLoad);
    }
}
