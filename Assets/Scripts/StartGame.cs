using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private int health;
    private void Awake()
    {
        health = PlayerPrefs.GetInt("health");
        if (health < 3 || health >= 4)
        {
            health = 3;
            PlayerPrefs.SetInt("health", health);
        }
        if(PlayerPrefs.GetInt("stop") == 1)
        {
            PlayerPrefs.SetInt("stop", 0);
        }
    }
}
