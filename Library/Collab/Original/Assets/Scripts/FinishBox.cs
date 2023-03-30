using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.GetComponent<ParticleSystem>().Play();
        Debug.Log("Level Complete");
    }
}
