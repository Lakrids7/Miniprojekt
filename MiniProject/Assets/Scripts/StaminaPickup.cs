using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaPickup : MonoBehaviour
{
    public GameObject player;
    public Image staminaImage;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StaminaPickup"))
        {
            audioSource.Play();
            //Destroy(other.gameObject);
            PlayerController.stamina = PlayerController.maxStamina;
            staminaImage.fillAmount = 1;
            StartCoroutine(RespawnTime());
        }

        IEnumerator RespawnTime()
        {
            other.gameObject.SetActive(false);
            yield return new WaitForSeconds(5);
            other.gameObject.SetActive(true);
        }
    }
}
