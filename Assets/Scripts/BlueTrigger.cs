using UnityEngine;

public class BlueTrigger : MonoBehaviour
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

        if (other.CompareTag("Player") && FPM.rigidbody.drag == 1) //Проверка, если драг 0, то игрок умирает
        {
            Destroy(FPM.gameObject);
        }
    }
}