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
        checkpointPosition = startPoint.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            checkpointPosition = other.transform.position;
        }
        if (other.gameObject.CompareTag("Water") || other.gameObject.CompareTag("Obstacle"))
        {
            player.transform.position = checkpointPosition;
            PlayerController.stamina = PlayerController.maxStamina;
            staminaImage.fillAmount = 1;
            if (other.gameObject.CompareTag("Water")) waterSplash.Play();
            FinalMovingPlatform.playerDied = true;
        }
        if (other.gameObject.CompareTag("WinTrigger"))
        {
            player.GetComponent<PlayerController>().enabled = false;
            Win.playerHasWon = true;
        }

    }
}
