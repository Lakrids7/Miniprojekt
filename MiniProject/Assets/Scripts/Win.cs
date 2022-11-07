using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public static bool playerHasWon;
    public GameObject winScreen;
    public TextMeshProUGUI finalTime;
    public Timer timerScript;
    void Start()
    {
        playerHasWon = false;

    }

    void Update()
    {
        if(playerHasWon == true)
        {
            winScreen.gameObject.SetActive(true);
            winScene();
            playerHasWon = false;
        }
        
    }

    public void winScene()
    {
        int time = timerScript.getTime();

        Debug.Log("WIN");
        finalTime.text = time.ToString();
        timerScript.enabled = false;
    }
}
