using UnityEngine;
using System.Collections;

public class OnTouch : MonoBehaviour {

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                Destroy(this.transform.gameObject);
            }
        }
    } 


}
