using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public GameObject start;
    public GameObject checkpoint;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            checkpoint.SetActive(false);
            start.SetActive(true);
        }
    }
}
