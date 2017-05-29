using UnityEngine;
using System.Collections;

public class LoadWave : MonoBehaviour {

    public GameObject Zombi;
    public GameObject roundBanner;
    public int level = 5; 

    void Start()
    {
        StartCoroutine(RePositionWithDelay());
        //RePositionWithDelay();
    }

    IEnumerator RePositionWithDelay()
    {
        float spawnTime = 2.3f;
        
        
        //Load Round Banner
        Vector3 bannerPos = new Vector3(-1.0f, 0.0f, -3.0f);
        Instantiate(roundBanner, bannerPos, transform.rotation);
        //    yield return new WaitForSeconds(bannerTime);
        
        while (true)
        {
        
            yield return new WaitForSeconds(spawnTime);

            for (int i = 0; i < level; i++)
            {
                SetRandomPosition();
                Instantiate(Zombi, transform.position, transform.rotation);
            }
            // This routine repeats the spawning.
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