using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiroJogo : MonoBehaviour
{
    public GameObject m_BulletPrefab;
    public float m_Force = 20.0f;
    private int m_BulletAmount = 10;
    public Text m_BulletTextUI;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && m_BulletAmount>0) {

           GameObject bullet = Instantiate(m_BulletPrefab, transform.position, transform.rotation);
           Rigidbody body = bullet.GetComponent<Rigidbody>();
           body.AddForce(transform.forward * m_Force);

            m_BulletAmount--;

        }

        m_BulletTextUI.text = "Ammo: " + m_BulletAmount;

    }
}

