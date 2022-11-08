using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetLocation : MonoBehaviour
{
    public AudioSource waterSplash;
    public GameObject player;
    public GameObject startPoint;
    private Vector3 checkpointPosition;
    public Image staminaImage;


    private void Start()
    {
        //Sets the reset position to the start position
        checkpointPosition = startPoint.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        //If the player passed a checkpoint trigger, the position of that trigger is set as the new reset position
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            checkpointPosition = other.transform.position;
        }
        //If the player hits water or an obstacle, the players position is reset to the reset position, and the stamina is refilled
        if (other.gameObject.CompareTag("Water") || other.gameObject.CompareTag("Obstacle"))
        {
            player.transform.position = checkpointPosition;
            PlayerController.stamina = PlayerController.maxStamina;
            staminaImage.fillAmount = 1;
            if (other.gameObject.CompareTag("Water")) waterSplash.Play();
            FinalMovingPlatform.playerDied = true;
        }
        //If the player hits the WinTrigger, a static bool is set to true which is then used in the win script 
        if (other.gameObject.CompareTag("WinTrigger"))
        {
            player.GetComponent<PlayerController>().enabled = false;
            Win.playerHasWon = true;
        }

    }
}
