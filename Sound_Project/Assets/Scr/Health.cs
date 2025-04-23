using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public TextMeshProUGUI health;
    public GameObject Game;
    public GameObject SP;
    public GameObject End;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            health.SetText(Convert.ToString(Convert.ToInt32(health.text) - 1));
            if (health.text == "0")
            {
                Game.SetActive(false);
                SP.SetActive(false);
                End.SetActive(true);
            }
        }
    }
}
