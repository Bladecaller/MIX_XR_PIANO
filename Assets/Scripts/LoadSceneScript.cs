 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public string scene;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Tip"){
            SceneManager.LoadScene(scene);
        }
    }
}
