using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour
{
    public CharacterController characterController;
    public AudioSource boingAudioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //characterController.Move(10 * Time.deltaTime * new Vector3(0, 10, 0));
            //Debug.Log("Virker det??" + Time.time);
            PlayerController.verticalSpeed = 15f;
            boingAudioSource.Play();
        }
    }
}
