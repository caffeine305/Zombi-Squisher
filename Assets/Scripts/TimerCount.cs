using UnityEngine;
using System.Collections;

public class TimerCount : MonoBehaviour {

    public static int time = 0;

    public static int getTime(){
        return time;
    }


    void Update() {
        time++;
        //Debug.Log(timer);
    }

}
