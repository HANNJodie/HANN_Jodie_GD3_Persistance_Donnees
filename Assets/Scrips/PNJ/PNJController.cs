using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour, ITalk
{
    private SystemeDialogue _dialogSystem;
    [SerializeField] private int _StartSentence;
    [SerializeField] private int _interSentence;
    [SerializeField] private int _endSentence;
    [SerializeField] private DatasQuest _questData;


    private void Start()
    {
        _dialogSystem= GetComponent<SystemeDialogue>();
    }

    public void Talk()
    {
        if (_questData.IsStarted)
        {
            if (_questData.IsFinished)
            {
                _dialogSystem.StartTalking(_endSentence);
            } else
            {
                _dialogSystem.StartTalking(_interSentence);
            }
        } else
        {
            _dialogSystem.StartTalking(_StartSentence);
        }
    }
}
