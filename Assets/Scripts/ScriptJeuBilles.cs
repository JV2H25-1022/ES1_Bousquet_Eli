using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

   public void OnTriggerEnter()
    {
        StartCoroutine(LoadSceneWithDelay());
    }

    IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("ES1-Demo");
    }
    
}
