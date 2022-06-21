using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answer : MonoBehaviour
{
    public bool isCorrect = false;
    public quizmanager manager;

    public void anss()
    {
        if(isCorrect)
        {
            Debug.Log("Btul Cuy");
            manager.correct();
        }
        else
        {
            Debug.Log("Salah Cuy");
            manager.correct();
        }
    }
}
