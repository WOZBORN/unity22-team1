using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public FirstPersonMovement FPM;

    private void Start()
    {
        FPM = FindObjectOfType<FirstPersonMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Если игрок заходит в триггер, то умирает без шанса
        {
            FPM.enabled = false;
            FPM.DeathScreen.enabled = true;
            FPM.DeathScreenText.enabled = true;
            FPM.rigidbody.isKinematic = true;
        }
    }
}
