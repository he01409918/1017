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
        Vector3 position = new Vector3(Random.Range(3f,18f), Random.Range(0f,3f), Random.Range(23f,33f));
        GameObject _balloon = Instantiate(balloon[Random.Range(0, balloon.Length)], position, this.transform.rotation);
        Destroy(_balloon, Random.Range(5f, 10f));
        Invoke(nameof(InitBalloon), Random.Range(0.5f, 2));
    }

    public void OnAddScore(int value)
    {
        currentScore += value;
        scoreText.text = currentScore.ToString();
    }


}
