using UnityEngine;

public class OrangeTrigger : MonoBehaviour
{
    public FirstPersonMovement FPM;
    public GameManager Controller;
    private void Start()
    {
        FPM = FindObjectOfType<FirstPersonMovement>();
        Controller = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other) //Вход в триггер
    {
        Debug.Log("Зашел");

        Controller.AddScore();

        if (other.CompareTag("Player") && FPM.rigidbody.drag == 2) //Проверка, если драг 2, то игрок умирает
        {
            FPM.enabled = false;
            FPM.DeathScreen.enabled = true;
            FPM.DeathScreenText.enabled = true;
            FPM.rigidbody.isKinematic = true;
        }
    }
}