using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accessComputer : MonoBehaviour
{
    public GameObject hackPanel;
    private bool inPC = false;

    private void Awake()
    {
        hackPanel.SetActive(false);
    }
    private void Update()
    {
        if(inPC)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                hackPanel.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            inPC = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inPC = false;
        }
    }
}
