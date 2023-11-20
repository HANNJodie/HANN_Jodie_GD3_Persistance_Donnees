using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemeDialogue : MonoBehaviour
{
    [SerializeField] private DatasDialogues _DialogDatas;
    [SerializeField] private UIDialoguesLong _UIDialog;
    [SerializeField] private UIDialoguesReponses _UIDialogAnswer;
    private int actualSentence;

    public void StartTalking(int DialogueSentenceNumber)
    {

        actualSentence = DialogueSentenceNumber;

        _UIDialog.ShowLongDialog(_DialogDatas.Sentences[actualSentence].LongSentence);

        int[] answerNumbers = new int[2];
        answerNumbers[0] = _DialogDatas.Sentences[actualSentence].Answer1;
        answerNumbers[1] = _DialogDatas.Sentences[actualSentence].Answer2;

        string[] answers = new string[2];

        for (int i = 0; i < answerNumbers.Length;i++)
        {
            if (answerNumbers[i] != -1)
            {
                answers[i] = _DialogDatas.Sentences[answerNumbers[i]].ShortSentence;
            }
            else
            {
                answers[i] = "";
            }
        }



        _UIDialogAnswer.ShowAnswers(answers);

    }

    public void SelectAnswer(int answerNumber)
    {
        if(answerNumber == 0)
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].Answer1);
        }
        else
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].Answer2);
        }
    }

}
