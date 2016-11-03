using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int m_PlayerNumber;
    public float m_Speed;

    private Rigidbody2D m_rb2d;
    private string m_HorizontalAxis;
    private string m_VerticalAxis;

	void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        m_HorizontalAxis = "Horizontal" + m_PlayerNumber;
        m_VerticalAxis = "Vertical" + m_PlayerNumber;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis(m_HorizontalAxis);
        float moveVertical = Input.GetAxis(m_VerticalAxis);
        Vector2 movement = new Vector2(moveHorizontal, moveVertical) * m_Speed * Time.deltaTime;

        m_rb2d.MovePosition(m_rb2d.position + movement);
    }
}
