using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTrigger : MonoBehaviour
{
    public GameObject start;
    public GameObject checkpoint;

    public static float bestTime = 0f;
    public static int currentLap = 1;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            

            currentLap = currentLap + 1;
            if (currentLap == 4) {
                SceneManager.LoadScene(1);
            }



            start.SetActive(false);
            checkpoint.SetActive(true);
            TimeScript.time = 0;
        }
    }
}
