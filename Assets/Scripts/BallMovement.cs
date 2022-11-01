using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //decide which side it goes
        float rand = Random.Range(0, 10);
        if (rand < 5)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(7, -7);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-7, -7);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
