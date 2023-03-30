using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnPlatform : MonoBehaviour
{
    public GameObject gCube;
    public GameObject pCube;
    public GameObject bCube;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == gCube )
        {
            gCube.transform.parent.parent = transform.parent;
        }
        if(collision.gameObject == pCube)
        {
            pCube.transform.parent.parent = transform.parent;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == gCube)
        {
            gCube.transform.parent.parent = null;
        }
        if (collision.gameObject == pCube)
        {
            pCube.transform.parent.parent = null;
        }
        
    }
}
