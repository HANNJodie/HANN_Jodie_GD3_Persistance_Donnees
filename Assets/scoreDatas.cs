using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Score")]

public class scoreDatas : ScriptableObject
{
    public int scoreValue;

    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    public void UpdateScoreValue(int Value)
    {
        scoreValue = Mathf.Clamp(scoreValue + Value, 0, 999999999);
        UpdateScoreUI();
    }

    public void InitScoreValue(int initValue)
    {
        UpdateScoreValue(initValue);
    }

    private void UpdateScoreUI()
    {
        OnUpdate?.Invoke(scoreValue);
    }
}