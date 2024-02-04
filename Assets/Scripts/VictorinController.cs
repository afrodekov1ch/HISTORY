using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VictorinController : MonoBehaviour
{
    public int power = 1;

    public string textQuestion;
    public Text QuestionTextMain;

    public Button Answer;
    public Button Answer1;
    public Button Answer2;
    public Button Answer3;

    public GameObject[] Panels;

    private int health;

   
    private void Start()
    {
        Question();
    }
    private void FixedUpdate()
    {
        health = PlayerPrefs.GetInt("health");
        if (PlayerPrefs.GetInt("health") == 0)
        {
            SceneManager.LoadScene("Restart");
        }
    }
    public void Question()
    {
        QuestionTextMain.text = textQuestion;
    }
    public void AnswerTrue()
    {
        Panels[0].SetActive(true);
        Invoke("NextLvl", 1);
    }
    public void AnswerFalse()
    {
        health -= power;
        PlayerPrefs.SetInt("health", 0 + health);
        Panels[1].SetActive(true);
        Invoke("NextLvl", 1);
    }
    private void NextLvl()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
    
}