using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Answer : MonoBehaviour
{
    public bool isCorrect;

    //Reference to button to access its components
    private Image image;
    private Button button;
    //this get the Transitions of the Button as its pressed
    private ColorBlock theColor;

    Color32 green = new Color32(0, 255, 0, 125);
    Color32 red = new Color32(255, 0, 0, 125);

    // Use this for initialization
    void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();

    }


    /// <summary>
    /// Example
    /// just add this to your Button component On Click()
    /// </summary>
    public void ButtonTransitionColors(bool turn)
    {
        isCorrect = turn;
        if (isCorrect) image.color = green; else image.color = red;


    }
}
