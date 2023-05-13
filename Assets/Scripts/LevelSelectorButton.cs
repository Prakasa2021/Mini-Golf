using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorButton : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Selector");
    }
}
