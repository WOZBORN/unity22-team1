using UnityEngine;

public class BlueTrigger : MonoBehaviour
{
    private FirstPersonMovement FPM;
    private DeathTrigger DeathT;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Зашел");
        Debug.Log(FPM.rigidbody.drag);
        if (CompareTag("Player") && FPM.rigidbody.drag == 0)
        {
            Debug.Log("If Работает");

            Destroy(DeathT.Player);
        }
    }
}