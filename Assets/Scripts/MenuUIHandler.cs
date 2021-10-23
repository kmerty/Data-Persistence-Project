using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI iField, pHolder, hScore;

    public void SetPlayerName()
    {
        DataManager.Instance.playerName = iField.text;
        //Debug.Log("Eingabe: " + iField.text);
    }
    private void Start()
    {
        pHolder.text = DataManager.Instance.playerName;
        hScore.text = "Highscore: " + DataManager.Instance.highScore;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //DataManager.Instance.SaveAll();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    
}
