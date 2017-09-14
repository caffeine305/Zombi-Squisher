using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour {

    // Use this for initialization

    void Start () {
           StartCoroutine(Blinker());
    }
    
        IEnumerator Blinker() { 
        

        
        while (true){

            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.6f);
            GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.6f);
            }
        }
}
