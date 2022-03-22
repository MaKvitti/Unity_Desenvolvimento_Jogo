using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodaCamera : MonoBehaviour
{

    public float m_Sens = 1.0f;
    private Transform m_Player;


    private void Start()
    {

        m_Player = transform.parent;
    }

    private void Update()
    {
        float lookX = Input.GetAxis("Mouse X") * m_Sens;
        float lookY = Input.GetAxis("Mouse Y") * m_Sens;

        m_Player.Rotate(Vector3.up, lookX);
        transform.Rotate(Vector3.left, lookY);




    
    }




}
