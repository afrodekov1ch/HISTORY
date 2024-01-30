using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private int health;

    private void Update()
    {
        health = PlayerPrefs.GetInt("health");
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
}
