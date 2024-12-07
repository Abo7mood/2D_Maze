using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Answers : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionTXT;
    [SerializeField] TextMeshProUGUI[] answersTXT;
    [SerializeField] Answer[] answersList;
    [SerializeField] string[] questions;

     string[,] answers;
    bool[,] answersCorrection;

    int questionNumber = 0;
    private void Awake()
    {
        answers =new string[5,3]{
            { "8x-7", "6x-5","7x-5" },
            { "4x+4", "4x+10","8x+10" },
            { "66x-6", "7x+3","9x-6" },
            { "12x+28", "15x+28","15x-28"},
            { "14x+12", "12x+12","17x+13"}
        };

        answersCorrection = new bool[5, 3]{
            { false, true ,false},
            { false, true ,false },
            { false, false, true },
            { false, false, true },
            { true, false , false}
        };
    }
    private void Start()
    {
        Next();
    }
    public void Next()
    {
        if (questionNumber >= 5)
        {
            return;
        }
        questionTXT.text = questions[questionNumber];

        for (int i = 0; i < answersTXT.Length; i++)
        {
            answersTXT[i].text = answers[questionNumber, i];
        }

        for (int i = 0; i < answersList.Length; i++)
        {
            answersList[i].GetComponent<Button>().interactable = true;
            answersList[i].ButtonTransitionColors(answersCorrection[questionNumber, i]);
          
        }
        
        questionNumber++;

    }
    public void End()
    {

    }
    public void NextButton() {
        Invoke(nameof(Next), 1);
        for (int i = 0; i < answersList.Length; i++) answersList[i].GetComponent<Button>().interactable = false;

    }
}
