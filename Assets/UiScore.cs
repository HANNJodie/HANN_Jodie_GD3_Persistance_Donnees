using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void OnEnable()
    {
        scoreDatas.OnUpdate += MiseEnFormeScore;
    }

    private void OnDisable()
    {
        scoreDatas.OnUpdate -= MiseEnFormeScore;
    }

    public void MiseEnFormeScore(int scoreValue)
    {
        _scoreText.text = scoreValue.ToString();
    }
}
