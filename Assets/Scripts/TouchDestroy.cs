using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class TouchDestroy : MonoBehaviour {

    private LoadWave loadWave;
    private Walk walk;

    public int valorScore;
    public int eliminado;
    public float vel;

    void Start()
    {
        

        GameObject LoadWaveObject = GameObject.FindWithTag("GameController");
        if (LoadWaveObject != null)
        {
            loadWave = LoadWaveObject.GetComponent<LoadWave>();
        }

        if (LoadWaveObject == null)
        {
            Debug.Log("No se puede encontrar el Script 'ZombiManager' ");
        }

        GameObject LoadWalkObject = GameObject.FindWithTag("Enemy");
        if (LoadWalkObject != null)
        {
            walk = LoadWalkObject.GetComponent<Walk>();
        }

        if (LoadWalkObject == null)
        {
            Debug.Log("No se puede encontrar el Script 'Walk' ");
        }

    }


    void OnMouseDown()
    {
            valorScore = 100;
            eliminado = 1;
            vel = walk.speed;

        if (loadWave.Death() == false)
        {
            this.gameObject.SetActive(false);

            loadWave.Pedo();
            loadWave.SumarScore(valorScore);
            loadWave.UpdateEliminados(eliminado);
            loadWave.UpdateSpeed(vel);
            Destroy(this.gameObject, 2.0f);
            
        }
    }


}
