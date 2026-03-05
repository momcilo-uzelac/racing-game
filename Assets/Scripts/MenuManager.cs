using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    
    public void PlayAgain() {
        StartTrigger.currentLap = 1;
        SceneManager.LoadScene(0);
    }

    public void ExitGame() {
        Application.Quit();
    }
}
