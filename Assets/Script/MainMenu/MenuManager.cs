using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject ContinuePanel;
    public GameObject NewGamePanel;
    public GameObject OptionsPanel;
    public GameObject CreditsPanel;
    public GameObject CloseApplicationPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        ContinuePanel.SetActive(false);
        NewGamePanel.SetActive(false);
        CreditsPanel.SetActive(false);
        CloseApplicationPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        QuitApplication();
    }


    public void ContinueButtonClicked()
    {
        MenuPanel.SetActive(true);
        ContinuePanel.SetActive(true);
        NewGamePanel.SetActive(false);
        CreditsPanel.SetActive(false);
        CloseApplicationPanel.SetActive(false);
    }
    
    public void NewGameButtonClicked()
    {
        MenuPanel.SetActive(true);
        ContinuePanel.SetActive(false);
        NewGamePanel.SetActive(true);
        CreditsPanel.SetActive(false);
        CloseApplicationPanel.SetActive(false);
    }

    // public void OptionsButtonClicked()
    // {
    //     MenuPanel.SetActive(false);
    //     OptionsPanel.SetActive(true);
    // }

    public void CreditsButtonClicked()
    {
        MenuPanel.SetActive(true);
        ContinuePanel.SetActive(false);
        NewGamePanel.SetActive(false);
        CreditsPanel.SetActive(true);
        CloseApplicationPanel.SetActive(false);
    }
    
    public void CloseButtonClicked()
    {
        MenuPanel.SetActive(true);
        ContinuePanel.SetActive(false);
        NewGamePanel.SetActive(false);
        CreditsPanel.SetActive(false);
        CloseApplicationPanel.SetActive(false);
    }

    public void YesButtonContinueClicked()
    {
        Application.LoadLevel("Level 1");
    }

    public void YesButtonNewGameClicked()
    {
        Application.LoadLevel("Level 2");
    }

    public void YesButtonQuitGameClicked()
    {
        Application.Quit();
    }
    
    // public void NoButtonClicked()
    // {
    //     MenuPanel.SetActive(true);
    //     ContinuePanel.SetActive(false);
    // }

    void QuitApplication()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MenuPanel.SetActive(true);
            ContinuePanel.SetActive(false);
            NewGamePanel.SetActive(false);
            CloseApplicationPanel.SetActive(true);
        }
    }

}
