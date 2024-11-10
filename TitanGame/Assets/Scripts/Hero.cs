using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_rb;
    [SerializeField]
    private float m_maxSpeed;
    [SerializeField]
    private float m_acceleration;
    [SerializeField]
    private float m_deceleration;

    // Start is called before the first frame update
    void Start()
    {
        var height = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, Screen.height / 3.0f, 0.0f)).y;
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            m_rb.AddForce(new Vector2(-1 * m_acceleration, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            m_rb.AddForce(new Vector2(1 * m_acceleration, 0));
        }

        if (m_rb.linearVelocity.magnitude > m_maxSpeed)
        {
            m_rb.linearVelocity = m_rb.linearVelocity.normalized * m_maxSpeed;
        }

        if (Mathf.Abs(m_rb.linearVelocity.magnitude) < 0.5)
        {
            m_rb.linearVelocity = Vector2.zero;
        }
        else
        {
            ApplyDeceleration();
        }
    }

    private void ApplyDeceleration()
    {
        var direction = m_rb.linearVelocity.normalized;
        //Going left
        if (direction.x < 0.0f)
        {
            m_rb.AddForce(new Vector2(1 * m_deceleration, 0));
        }
        if (direction.x > 0.0f)
        {
            m_rb.AddForce(new Vector2(-1 * m_deceleration, 0));
        }
    }
}
