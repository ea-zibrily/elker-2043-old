using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EleHealth : MonoBehaviour
{
    public GameObject GameOverScreen;
    private GameMaster gm;

    void Awake()
    {
        GameOverScreen.SetActive(false);
    }
    void Start()
    {
        /*
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
        */
        
    }
    void TakeDamage()
    {
        Time.timeScale = 0;
        GameOverScreen.SetActive(true);
        print("You Lose!");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage();
        }
    }
    public void Ulang()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         Time.timeScale = 1;
    }
}