using UnityEngine;
using System.Collections;

public class TouchDestroy : MonoBehaviour {

    public AudioClip pedo;
    private AudioSource culo;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    void Awake()
    {
        culo = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        culo.PlayOneShot(pedo,vol);
        Destroy(this.gameObject);
    }

    /*
    void Update()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        culo.PlayOneShot(pedo,vol);
    }
    */
}
