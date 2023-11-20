using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemeDialogue : MonoBehaviour
{
    [SerializeField] private DatasDialogues _DialogDatas;
    [SerializeField] private UIDialoguesLong _UIDialog;
    [SerializeField] private UIDialoguesReponses _UIDialogAnswer;

    public void StartTalking(int DialogueSentenceNumber)
    {
        _UIDialog.ShowLongDialog(_DialogDatas.Sentences[DialogueSentenceNumber].LongSentence);
        string[] answers = new string[2];
        if (_DialogDatas.Sentences[DialogueSentenceNumber].Answer1 != -1)
        {
            answers[0] = _DialogDatas.Sentences[_DialogDatas.Sentences[DialogueSentenceNumber].Answer1].ShortSentence;
        } else
        {
            answers[0] = "";
        }

        if (_DialogDatas.Sentences[DialogueSentenceNumber].Answer2 != -1)
        {
            answers[0] = _DialogDatas.Sentences[_DialogDatas.Sentences[DialogueSentenceNumber].Answer2].ShortSentence;
        }
        else
        {
            answers[0] = "";
        }



        _UIDialogAnswer.ShowAnswers(answers);

    }



}
