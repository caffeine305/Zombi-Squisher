using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

    public float bannerTime = 1.3f;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Destroy(this.gameObject, bannerTime);
    }
}
