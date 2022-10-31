using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public int currentScore;

    public Text scoreText;

    public GameObject[] balloon;

    void Start()
    {
        Instance = this;
        GameObject _balloon = Instantiate(balloon[Random.Range(0 , balloon.Length)], this.transform.position, this.transform.rotation);
        OnAddScore(0);
    }
    public void OnAddScore(int value)
    {
        currentScore += value;
        scoreText.text = currentScore.ToString();
    }


}
