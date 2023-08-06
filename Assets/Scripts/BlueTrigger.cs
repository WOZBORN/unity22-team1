using UnityEngine;

public class BlueTrigger : MonoBehaviour
{
    public FirstPersonMovement FPM;



    private void Start()
    {
        FPM = FindObjectOfType<FirstPersonMovement>();
    }
    private void OnTriggerEnter(Collider other) //Вход в триггер
    {
        if (other.CompareTag("Player") && FPM.rigidbody.drag == 0) //Проверка, если драг 0, то игрок умирает
        {
            Destroy(FPM.gameObject);
        }
    }
}