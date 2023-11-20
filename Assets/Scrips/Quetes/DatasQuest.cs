
using UnityEngine;

[CreateAssetMenu(menuName = "New Quest")]

public class DatasQuest : ScriptableObject
{
    public DatasObjectif[] Objectifs;
    public bool IsStarted;
    public bool IsFinished;


    public void CheckQuest()         // On verifie si la quete est complet�e
    {
        bool result = true;
        for (int i = 0; i < Objectifs.Length; i++)
        {
            if (!Objectifs[i].IsFinished)
            {
                result = false;
                break;
            }
        }

        if (result)
        {
            EndQuest();
        }
    }

    public void StartQuest()         // La fonction qui dit que la quete est lanc�e
    {
        IsStarted= true;
    }

    public void EndQuest()         // La fonction qui dit que la quete est termin�e
    {
        IsFinished= true;
    }

    public void CheckObjective(int NumObject)     // On verifie si l'objectif est compl�t�e
    {

        if (Objectifs[NumObject].ActualValue >= Objectifs[NumObject].MaxValue)
        {
            Objectifs[NumObject].IsFinished= true;
            CheckQuest();
        }
    }

    public void UpdateObjective(Collectible collectible)   //Mise � jour de l'ojectif
    {
        for (int i = 0; i < Objectifs.Length;i++)
        {
            if (Objectifs[i].CollectibleType == collectible.GetCollectibleType())
            {
                Objectifs[i].ActualValue += collectible.GetCollectibleValue();

                CheckObjective(i);

                break;
            }
        }


    }
}
