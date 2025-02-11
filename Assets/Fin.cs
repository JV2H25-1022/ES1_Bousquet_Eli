using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       public void OnTriggerEnter()
    {
        StartCoroutine(LoadSceneWithDelay());
        Debug.Log("a");
    }

    IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("ES1-Demo");
        Debug.Log("b");
    }
}
