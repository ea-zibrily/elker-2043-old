using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUI : MonoBehaviour
{
    public GameObject pc;
    public GameObject hack;
    public GameObject succes;
    public GameObject eror;
    public GameObject info;

    public void closePC()
    {
        pc.SetActive(false);
    }
    public void closehack()
    {
        hack.SetActive(false);
    }
    public void closeSuccess()
    {
        succes.SetActive(false);
    }
    public void closeEror()
    {
        eror.SetActive(false);
    }
    public void closeInfo()
    {
        info.SetActive(false);
    }

    public void openPrompt()
    {
        hack.SetActive(true);
    }
}
