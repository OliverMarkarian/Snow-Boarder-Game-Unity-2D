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
            StartCoroutine(LoadSceneAfterDelay(0.5f)); 
        }
        

    IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(0); 
    }
    }
}
