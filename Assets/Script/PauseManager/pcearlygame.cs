using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcearlygame : MonoBehaviour
{
    public GameObject pcearly;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pcearly.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pcearly.SetActive(false);
        }
    }
}
