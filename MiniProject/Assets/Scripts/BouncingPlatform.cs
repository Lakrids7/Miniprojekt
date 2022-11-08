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
            //Increases the players vertical speed by 15 if they collide with the bouncing platform, and plays a sound
            PlayerController.verticalSpeed = 15f;
            boingAudioSource.Play();
        }
    }
}
