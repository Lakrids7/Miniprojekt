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
        //Updates the time ui text element with the amount of time passed - 5 for each clock the player has picked up
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
