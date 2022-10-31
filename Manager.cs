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
        InitBalloon();
        OnAddScore(0);
    }

    private void InitBalloon()
    {
        Vector3 position = new Vector3(8.9f, -2.24f, 27.19f);
        GameObject _balloon = Instantiate(balloon[Random.Range(0, balloon.Length)], position, this.transform.rotation);
    }

    public void OnAddScore(int value)
    {
        currentScore += value;
        scoreText.text = currentScore.ToString();
    }


}
