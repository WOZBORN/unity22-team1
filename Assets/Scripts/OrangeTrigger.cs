using UnityEngine;

public class OrangeTrigger : MonoBehaviour
{
    public  FirstPersonMovement FPM;
    private void OnTriggerEnter(Collider other) //Вход в триггер
    {
        if (other.CompareTag("Player") && FPM.rigidbody.drag == 2) //Проверка, если драг 2, то игрок умирает
        {
            Destroy(FPM.gameObject);
        }
    }
}