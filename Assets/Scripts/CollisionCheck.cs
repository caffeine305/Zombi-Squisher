using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

     void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Enemy") )
        {
            Destroy(this.gameObject);
            Debug.Log("Collision!!");
        }
    }

}
