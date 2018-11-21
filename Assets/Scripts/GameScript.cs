using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public Questions[] question;

    public Text questionText;
    public Text answer1Text;
    public Text answer2Text;
    public Text answer3Text;

    private int questionCount = 0;

	// Use this for initialization
	void Start ()
    {
        questionText.text = question[questionCount].question;
        answer1Text.text = question[questionCount].answers[0];
        answer2Text.text = question[questionCount].answers[1];
        answer3Text.text = question[questionCount].answers[2];
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            questionCount++;
            NextQuestion();
        }
    }

    private void NextQuestion()
    {
        questionText.text = question[questionCount].question;
        answer1Text.text = question[questionCount].answers[0];
        answer2Text.text = question[questionCount].answers[1];
        answer3Text.text = question[questionCount].answers[2];
    }
}
