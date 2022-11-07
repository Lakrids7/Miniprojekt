using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public TextMeshProUGUI timer;
    int seconds;
    int minutes;
    int minutesPassedinSeconds;
    public static int timePickups;



    void Update()
    {
        int time = (int)Time.time - minutesPassedinSeconds - timePickups;
        /*if (seconds == 60)
        {
            minutes++;
            minutesPassedinSeconds += 60;
        }
        */

        timer.text = "Time:" + time;


    }
}
