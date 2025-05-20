using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 3.0f; //Ȯ��

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
