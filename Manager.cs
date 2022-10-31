using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public int currentScore;

    public Text scoreText;

    void Start()
    {
        Instance = this;
        OnAddScore(0);
    }
    public void OnAddScore(int value)
    {
        currentScore += value;
        scoreText.text = currentScore.ToString();
    }
}
