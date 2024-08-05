using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.2f;
        void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            Debug.Log("Ouch, hit my head");
            Invoke("reloadScene",loadDelay);
            
        }   
    }
    void reloadScene(){
        SceneManager.LoadScene(0);
    }


}
