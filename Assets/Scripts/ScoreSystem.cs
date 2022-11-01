using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public AudioSource hit;
    public AudioSource over;

    public int RightScore;
    public int LeftScore;

    public Text ScoreLeftText;
    public Text ScoreRightText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreLeftText.text = LeftScore.ToString();
        ScoreRightText.text = RightScore.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        name = collision.gameObject.name;
       
        if(name == "TriggerLeft")
        {
            RightScore++;
            over.Play();

        }
        if (name == "TriggerRight")
        {
            LeftScore++;
            over.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hit.Play();
    }
}
