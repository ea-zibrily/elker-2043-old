using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoorAnimation : MonoBehaviour
{
    public GameObject lockpopup;
    public GameObject openLight;
    public GameObject closeLight;
    public GameObject leveldone;

    Animator myAnime;
    private void Awake()
    {
        myAnime = GetComponent<Animator>();
    }
    private void Update()
    {
        if(ele.isSafeOpened)
        {
            myAnime.SetTrigger("openlock");
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        lockpopup.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        lockpopup.SetActive(false);
    }

    void OpenDoorLight()
    {
        closeLight.SetActive(false);
        openLight.SetActive(true);
    }

    void levelDone()
    {
        Invoke("ezlevel", 1f);
    }

    void ezlevel()
    {
        leveldone.SetActive(true);
        Time.timeScale = 0;
    }
}
