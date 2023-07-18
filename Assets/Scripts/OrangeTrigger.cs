using UnityEngine;

public class OrangeTrigger : MonoBehaviour
{
    private FirstPersonMovement FPM;
    private DeathTrigger DeathT;
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player") && FPM.rigidbody.drag == 2)
        {
            Destroy(DeathT.Player);
        }
    }
}