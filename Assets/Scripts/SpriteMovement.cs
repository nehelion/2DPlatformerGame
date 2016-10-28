using UnityEngine;
using System.Collections;

public class SpriteMovement : MonoBehaviour
{
    public int speed;
    public int jPower;
    public bool hitJ;
    
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;   
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jPower * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "spike")
        {
            speed = 0;
            jPower = 0;
        }

        if (col.gameObject.tag == "jumper")
        {
            transform.position += Vector3.up * 200 * Time.deltaTime;
            hitJ = true;
        }
    }
}
