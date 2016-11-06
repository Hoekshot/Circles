using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public float m_BounceStrength;

    // private Rigidbody2D m_rb2d;

	// Use this for initialization
	void Start () {
        // rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * m_BounceStrength);
        }
    }
}
