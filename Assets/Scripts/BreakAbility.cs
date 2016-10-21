using UnityEngine;
using System.Collections;

public class BreakAbility : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) 
        {
            Destroy(gameObject);
        }
    }
}
