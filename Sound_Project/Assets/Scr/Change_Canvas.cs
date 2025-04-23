using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Change_Canvas : MonoBehaviour
{
    public GameObject Start;
    public GameObject Game;
    public GameObject SP;
    public GameObject End;
    public int num;

    public void Button_Pressed()
    {
        if (num == 1)
        {
            Start.SetActive(true);
            Game.SetActive(false);
            SP.SetActive(false);
            End.SetActive(false);
        }
        else if (num == 2)
        {
            Start.SetActive(false);
            Game.SetActive(true);
            SP.SetActive(true);
            End.SetActive(false);
        }
        else if (num == 3)
        {
            Start.SetActive(false);
            Game.SetActive(false);
            SP.SetActive(false);
            End.SetActive(true);
        }
    }
}
