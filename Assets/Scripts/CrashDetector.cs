using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            Debug.Log("Ouch, hit my head");
            Invoke("reloadScene",0.2f);
            
        }   
    }
    void reloadScene(){
        SceneManager.LoadScene(0);
    }


}
