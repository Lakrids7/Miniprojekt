using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaPickup : MonoBehaviour
{
    public GameObject player;
    public Image staminaImage;
    public AudioSource staminaAudioSource;
    public AudioSource watchAudioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StaminaPickup"))
        {
            staminaAudioSource.Play();
            //Destroy(other.gameObject);
            PlayerController.stamina = PlayerController.maxStamina;
            staminaImage.fillAmount = 1;
            StartCoroutine(RespawnTime());
        }
        if (other.gameObject.CompareTag("Watch"))
        {
            watchAudioSource.Play();
            Timer.timePickups += 5;
            other.gameObject.SetActive(false);


        }

        IEnumerator RespawnTime()
        {
            other.gameObject.SetActive(false);
            yield return new WaitForSeconds(5);
            other.gameObject.SetActive(true);
        }




    }
}
