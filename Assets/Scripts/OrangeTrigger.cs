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
    private void OnTriggerEnter(Collider other) //���� � �������
    {
        Debug.Log("�����");
       // Debug.Log();
        Controller.AddScore();

        if (other.CompareTag("Player") && FPM.rigidbody.drag == 2) //��������, ���� ���� 2, �� ����� �������
        {
            Destroy(FPM.gameObject);
        }
    }
}