using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector1 : MonoBehaviour
{
    private int Coin = 0;

    
    private void OnTriggerEnter(Collider other)
    {
            if(other.transform.tag = "Coin")
        {
            Coin++;
            
        }
    }
}
