using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public int currentScore;
    void Start()
    {
        Instance = this;
    }
    public void OnAddScore(int value)
    {
        currentScore += value;
    }
}
