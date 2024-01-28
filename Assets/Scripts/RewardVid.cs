using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class RewardVid : MonoBehaviour
{
    [SerializeField] private Button RewardButton;
    private int health;

    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    private void Awake()
    {
        health = PlayerPrefs.GetInt("health");
        if (health < 3)
        {
            RewardButton.onClick.AddListener(delegate { ExampleOpenRewardAd(1); });
        }
    }
    private void Update()
    {
        health = PlayerPrefs.GetInt("health");
    }
    void Rewarded(int id)
    {
        if (id == 1)
        {
            Debug.LogWarning("Хп" + health);
        }
    }
    void ExampleOpenRewardAd(int id)
    {
        if (health < 3)
        {
            health += 1;
            PlayerPrefs.SetInt("health", health);
            YandexGame.RewVideoShow(id);
        }
        else
        {
            Debug.Log("У вас полное хп");
        }
    }
}