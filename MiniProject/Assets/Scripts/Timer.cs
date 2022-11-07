using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public TextMeshProUGUI timer;
    public static int time;
    int minutesPassedinSeconds;
    public static int timePickups;



    void Update()
    {
        if(Win.playerHasWon == false)
        {
            time = (int)Time.time - minutesPassedinSeconds - timePickups;

            timer.text = "Time:" + time;
        }




    }

    public int getTime()
    {
        return time;
    }

}
