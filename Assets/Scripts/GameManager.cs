using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GameObject[] disable; // player and maze
    [SerializeField] GameObject[] enable; // canvas

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);
       
    }

    public void PlayQuestions()
    {
        Activator(true, enable);
        Activator(false, disable);

    }

    private void Activator(bool turn, GameObject[] list)
    {
        for (int i = 0; i < list.Length; i++) list[i].SetActive(turn);
    }
}
