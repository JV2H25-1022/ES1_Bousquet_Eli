using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptJeuBilles : MonoBehaviour{

    public GameObject debut;
    public GameObject bouton;

    private Animator ctrl;


    // Start is called before the first frame update
    void Start()
    { 
        ctrl = bouton.GetComponent<Animator>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DebutJeu(){

        debut.SetActive (false);
        ctrl.SetBool("Milieu", true);
        ctrl.SetBool("Debut", false);
        ctrl.SetBool("Fin", false);

    }

}
