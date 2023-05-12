using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button[] lvlButtonList;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < lvlButtonList.Length; i++)
        {
            if(i + 2 > levelAt)
                lvlButtonList[i].interactable = false;
        }
    }

    public void LevelSelect(string name) 
    {
        SceneManager.LoadScene(name);
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
