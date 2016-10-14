using UnityEngine;
using System.Collections;

public class SpriteMovement : MonoBehaviour
{
    public int speed;
    public int jPower;
    public GameObject attackerW;
    private bool attW = false;
    public GameObject attackerA;
    private bool attA = false;
    public GameObject attackerD;
    private bool attD = false;

    void Start ()
    {
        
    }

	void Update ()
    {
        attackerW.SetActive(attW);
        attackerA.SetActive(attA);
        attackerD.SetActive(attD);
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.E))
            {
                attD = !attD;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.E))
            {
                attA = !attA;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                attW = !attW;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jPower * Time.deltaTime;
        }
        if (!(Input.GetKey(KeyCode.E)) && (attD == true || attW == true || attA == true))
        {
            attW = false;
            attA = false;
            attD = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "spike")
        {
            speed = 0;
            jPower = 0;
        }
    }
}
