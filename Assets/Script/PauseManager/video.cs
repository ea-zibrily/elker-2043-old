using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class video : MonoBehaviour
{
    public GameObject lesgo;

    public void lesgoPlay()
    {
        SceneManager.LoadScene("Level 2");
    }
}
