using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeScript : MonoBehaviour
{
    public TMP_Text lapTime;
    public TMP_Text coinCount;
    public TMP_Text lapCount;
    public static float time = 0f;

    void Update() {
        time = time + Time.deltaTime;
        lapTime.text = " Time: " + time.ToString("0.00");
        lapCount.text = "Lap: " + StartTrigger.currentLap + "/2 ";
        coinCount.Text = "Coins collected: " + Coin.ToString() + " /5";
    }
}
