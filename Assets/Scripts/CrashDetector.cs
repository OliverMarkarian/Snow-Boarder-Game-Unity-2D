using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 3f;
    [SerializeField] ParticleSystem finishEffect;
        void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            Debug.Log("Ouch, hit my head");
            finishEffect.Play();
            Invoke("reloadScene",loadDelay);
            
        }   
    }
    void reloadScene(){
        SceneManager.LoadScene(0);
    }


}
