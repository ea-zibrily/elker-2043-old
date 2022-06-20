using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject PausePanel;
    // Start is called before the first frame update
    void Start()
    {
    	PausePanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        EscCLick();
    }

    public void EscCLick()
    {
    	if(Input.GetKeyDown(KeyCode.Escape))
    	{
    		PausePanel.SetActive(true);
    	}
    }

    public void Resume()
    {
    	PausePanel.SetActive(false);
    }

    public void Menu()
    {
    	SceneManager.LoadScene("Main Menu");
    }

}
