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

        // Calcul de la vitesse verticale

        var vDeplacement = Input.GetAxis("Vertical") * vitesseDeplacement; 
        RigidbodyPerso.velocity = transform.forward * vDeplacement;

        // Calcul de la vitesse horizontale

        var hDeplacement = Input.GetAxis("Horizontal") * vitesseDeplacement;
        RigidbodyPerso.velocity = transform.forward * hDeplacement;

        // Applique la vitesses

        RigidbodyPerso.velocity = new Vector3(hDeplacement, 0, vDeplacement);


    }
}
