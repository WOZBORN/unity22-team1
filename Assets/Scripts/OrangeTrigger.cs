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
       // Debug.Log();
        Controller.AddScore();

        if (other.CompareTag("Player") && FPM.rigidbody.drag == 2) //Проверка, если драг 2, то игрок умирает
        {
            Destroy(FPM.gameObject);
        }
    }
}