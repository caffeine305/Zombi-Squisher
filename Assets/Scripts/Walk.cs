using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {

    public Transform target;
    public float speed;

    private TouchDestroy touch;
    private LoadWave loadWave;
    private Animator animator;

    void Start ()
    {
        speed = 0.2f;
        animator = GetComponentInChildren<Animator>();

        GameObject LoadWaveObject = GameObject.FindWithTag("GameController");
        if (LoadWaveObject != null)
        {
            loadWave = LoadWaveObject.GetComponent<LoadWave>();
        }

        if (LoadWaveObject == null)
        {
            Debug.Log("No se puede encontrar el Script 'ZombiManager' ");
        }



    }

    void FixedUpdate()
    {
        speed = loadWave.velocidad;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);


        if (transform.position.x < 0)
        {
            //animator.SetBool ??
            animator.SetFloat("isFacingRight", 1.0f);
        }

        else if (transform.position.x > 0)
        {
            animator.SetFloat("isFacingLeft",1.0f);
        }

        else if (transform.position.y < 0)
        {
            animator.SetFloat("isFacingUp", 1.0f);
        }

        else if (transform.position.y > 0)
        {
            animator.SetFloat("isFacingDown", 1.0f);
        }
    }
}