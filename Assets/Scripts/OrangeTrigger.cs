using UnityEngine;

public class OrangeTrigger : MonoBehaviour
{
    public  FirstPersonMovement FPM;


    private void Start()
    {
        FPM = FindObjectOfType<FirstPersonMovement>();
    }
    private void OnTriggerEnter(Collider other) //���� � �������
    {
        if (other.CompareTag("Player") && FPM.rigidbody.drag == 2) //��������, ���� ���� 2, �� ����� �������
        {
            Destroy(FPM.gameObject);
        }
    }
}