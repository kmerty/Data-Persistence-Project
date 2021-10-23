using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public GameObject iField;

    public void SetPlayerName()
    {
        //DataManager.Instance.playerName = inputName;
        Debug.Log("Eingabe: " + iField.text);
    }
    private void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //MainManager.Instance.SaveColor();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SaveColorClicked()
    {
        //MainManager.Instance.SaveColor();
    }

    public void LoadColorClicked()
    {
        //MainManager.Instance.LoadColor();
        //ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }
}
