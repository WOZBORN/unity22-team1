using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject Player;
  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Если игрок заходит в триггер, то умирает без шанса
        {
            Destroy(Player);
        }
    }
}
