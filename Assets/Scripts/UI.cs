using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private int health;
    [SerializeField] private GameObject stop;

    private void Update()
    {
        health = PlayerPrefs.GetInt("health");
        if(PlayerPrefs.GetInt("stop") == 1)
        {
            stop.SetActive(true);
        }
    }
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void End()
    {
        health -= 1;
        PlayerPrefs.SetInt("health", health);
    }
    public void ContinueGame()
    {
        PlayerPrefs.SetInt("stop", 0);
        stop.SetActive(false);
    }
}
