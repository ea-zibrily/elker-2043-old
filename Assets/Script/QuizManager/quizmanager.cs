using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class quizmanager : MonoBehaviour
{
    public List<questandansw> qna;
    public GameObject[] options;
    public int currentQuestion;

    public Text questiontext;
    public Text scoreUI;

    public int score;
    private int totQues;

    public GameObject information;
    public GameObject success;
    public GameObject eror;
    public GameObject quiz;

    private void Start()
    {
        totQues = qna.Count;
        generateQuestion();
    }
    private void Update()
    {
        scoreUI.text = score.ToString() + "/" + totQues;
    }

    public void correct()
    {
        score++;
        qna.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        //qna.RemoveAt(currentQuestion);
        //generateQuestion();
        eror.SetActive(true);
        quiz.SetActive(false);
    }

    void setAnswer()
    {
        int i;
        for(i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = qna[currentQuestion].answer[i];
            
            if(qna[currentQuestion].correctAnswer == i+1)
            {
                options[i].GetComponent<answer>().isCorrect = true;
            }
        }

    }

    void generateQuestion()
    {
        if(qna.Count > 0)
        {
            currentQuestion = Random.Range(0, qna.Count);

            questiontext.text = qna[currentQuestion].question;
            setAnswer();
        }
        else
        {
            Debug.Log("Kebanyakan");
            success.SetActive(true);
            Invoke("info", 2f);
        }
    }

    void info()
    {
        success.SetActive(false);
        information.SetActive(true);
        quiz.SetActive(false);
    }



}
