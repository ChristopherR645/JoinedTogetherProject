using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox : MonoBehaviour
{
    public GameObject winScreen;

    private void Start() {
        winScreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.GetComponent<ParticleSystem>().Play();
        Debug.Log("Level Complete");
        winScreen.SetActive(true);

    }
}
