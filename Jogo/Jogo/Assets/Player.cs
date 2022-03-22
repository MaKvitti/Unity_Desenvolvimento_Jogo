using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float m_SpeedMovement = 4.0f;

    private Rigidbody m_Body;

    private void Start()
    {
        m_Body = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        movement = movement.normalized * m_SpeedMovement * Time.deltaTime;
        movement = transform.TransformDirection(movement);

        m_Body.MovePosition(transform.position + movement);
    }
}
