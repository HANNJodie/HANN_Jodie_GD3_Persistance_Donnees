using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacements : MonoBehaviour

{
    // Start is called before the first frame update

    public Rigidbody RigidbodyPerso;
    public float vitesseDeplacement = 100f;

    void Start()
    {
        RigidbodyPerso = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //var vDeplacement = Input.GetAxis("Vertical") * vitesseDeplacement;
        //RigidbodyPerso.velocity = transform.forward * vDeplacement;
        //RigidbodyPerso.velocity = (transform.forward * vDeplacement) + new Vector3(0, RigidbodyPerso.velocity.y, 0);
        //RigidbodyPerso.velocity = new Vector3(0, 0, vDeplacement);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            RigidbodyPerso.AddForce(0f, 0f, 1f * vitesseDeplacement);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            RigidbodyPerso.AddForce(0f, 0f, -1f * vitesseDeplacement);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RigidbodyPerso.AddForce(1f * vitesseDeplacement, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            RigidbodyPerso.AddForce(-1f * vitesseDeplacement, 0f, 0f);
        }


    }
}
