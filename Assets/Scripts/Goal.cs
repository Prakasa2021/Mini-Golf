using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public UnityEvent OnBallGoalEnter = new UnityEvent();

    public int nextLevelLoad;

    void Start() 
    {
        nextLevelLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other) 
    {        
       if(other.CompareTag("Ball"))
       {
            OnBallGoalEnter.Invoke();
            
            if(nextLevelLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextLevelLoad);
            }
       }
    }
}
