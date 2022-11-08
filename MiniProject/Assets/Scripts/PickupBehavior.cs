using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupBehavior : MonoBehaviour
{
    public GameObject player;
    public Image staminaImage;
    public AudioSource staminaAudioSource;
    public AudioSource watchAudioSource;
    private void OnTriggerEnter(Collider other)
    {
        //If the player collides with the StaminaPickup, the stamina of the player is reset to full and the couroutine RespawnTime() starts
        if (other.gameObject.CompareTag("StaminaPickup"))
        {
            staminaAudioSource.Play();
            PlayerController.stamina = PlayerController.maxStamina;
            staminaImage.fillAmount = 1;
            StartCoroutine(RespawnTime());
        }
        //If the player collides with the watch, the timepickup variable is added 5 (which ends up being detracted from the time spent by the player variable in the Timer script)
        if (other.gameObject.CompareTag("Watch"))
        {
            watchAudioSource.Play();
            Timer.timePickups += 5;
            other.gameObject.SetActive(false);
        }

        IEnumerator RespawnTime()
        {
            //The couroutine is used to respawn the staminasoda after 5 seconds. The watch does not use this as each is only meant to be picked up once. 
            other.gameObject.SetActive(false);
            yield return new WaitForSeconds(5);
            other.gameObject.SetActive(true);
        }




    }
}
