using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

    public int maxHP = 1000;
    public int actualHP;
    //public Slider healthSlider;
    private LoadWave loadWave;

    public bool isDead;
    bool damaged;

    void Start()
    {
        actualHP = maxHP;
        isDead = false;

        //healthSlider.value = actualHP;

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

    /*
	void Update () {
            if (damaged) // set flash colour
            else //clear transition colour

    damaged = flase;
    }
    */
      

    public void TakeDamage(int amount)
    {
        //Poner bandera de Damage para activar comportamiento de daño.
        damaged = true;

        //Restar energía una cantidad dictada por amount
        actualHP -= amount;
        Debug.Log(actualHP);

        //reducir el tamaño de la barra de energía
        loadWave.UpdateHealthBar(actualHP);

        //Si la energía llega a cero, Destruir personaje
        if (actualHP <= 0 && !isDead)
        {
            Death();
        }
        else { }

    }

    public void Death()
    {
        //Levantar indicador de muerte que permita generar comportamiento apropiado.
        isDead = true;

        Destroy(this.gameObject);

        }
}
