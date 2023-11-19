using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Score")]

public class score : ScriptableObject
{
    public int scoreValue;

    public void UpdateScoreValue(int Value)
    {
        scoreValue = Mathf.Clamp(scoreValue + Value, 0, 999999999);
        UpdateScoreUI();
    }

    public void InitScoreValue(int initValue)
    {
        UpdateScoreValue(initValue);
    }

    public void UpdateScoreUI()
    {

    }
}