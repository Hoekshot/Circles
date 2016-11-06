using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int m_PlayerNumber;
    public float m_MovementSpeed;
    public float m_RotationSpeed;

    private Rigidbody2D m_rb2d;
    private string m_HorizontalAxis;
    private string m_VerticalAxis;
    private string m_RotationAxis;

	void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        m_HorizontalAxis = "Horizontal" + m_PlayerNumber;
        m_VerticalAxis = "Vertical" + m_PlayerNumber;
        m_RotationAxis = "Rotation" + m_PlayerNumber;
    }

    void FixedUpdate()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis(m_HorizontalAxis);
        float verticalInput = Input.GetAxis(m_VerticalAxis);
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * m_MovementSpeed * Time.deltaTime;

        m_rb2d.MovePosition(m_rb2d.position + movement);
    }

    void Rotate()
    {
        float rotationInput = Input.GetAxis(m_RotationAxis);
        float rotation = rotationInput * m_RotationSpeed;

        m_rb2d.AddTorque(rotation);
    }
}
