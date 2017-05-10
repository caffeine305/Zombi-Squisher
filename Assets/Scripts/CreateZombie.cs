using UnityEngine;
using System.Collections;

public class CreateZombie : MonoBehaviour {

    public GameObject Zombi;

    void Start()
    {
        StartCoroutine(RePositionWithDelay());
        //RePositionWithDelay();
    }

    IEnumerator RePositionWithDelay()
    {
        float spawnTime = 2.3f;
        while (true)
        {
            SetRandomPosition();
            Instantiate(Zombi, transform.position, transform.rotation);
            //spawnTime = 1 - Mathf.Exp(spawnTime) - spawnTime*Mathf.Exp(spawnTime);
            yield return new WaitForSeconds(spawnTime);
        }
    }

    void SetRandomPosition()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float y = Random.Range(-5.0f, 5.0f);
        Debug.Log("X,Z:" + x.ToString("F2") + " , " + y.ToString("F2"));
        transform.position = new Vector3(x, y, 0.0f);
    }

    
    void Update()
    {
        //Instantiate(Zombie, transform.position, transform.rotation);
        //new WaitForSeconds(10);
    }
    

}