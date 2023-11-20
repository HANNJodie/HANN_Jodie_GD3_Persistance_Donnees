using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectible iCollect = other.GetComponent<ICollectible>();
        if (iCollect != null)
        {
            iCollect.Collect();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        ITalk talking = collision.gameObject.GetComponent<ITalk>();
        if (talking != null)
        {
            talking.Talk();
        }
    }
}
