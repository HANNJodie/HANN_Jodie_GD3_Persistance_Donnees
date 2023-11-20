using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour, ICollectible
{
    [SerializeField] int _value;
    [SerializeField] scoreDatas _scoreData;
    [SerializeField] string _collectibleType;
    [SerializeField] DatasQuest _questData;

    public void Collect()
    {
        _questData.UpdateObjective(this);
        Destroy(gameObject);
    }

    public string GetCollectibleType()
    {
        return _collectibleType;
    }

    public int GetCollectibleValue()
    {
        return _value;
    }
}