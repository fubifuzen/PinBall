using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;
    public GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ScoreText: " + ScoreText);
    }

    // Update is called once per frame
    void Update()
    {

        this.ScoreText.GetComponent<Text>().text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision occurred!");
        if (collision.gameObject.tag == "LargeStarTag") 
        {
            score += 10;
        }
        else if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 20;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 50;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 40;
        }
        Debug.Log("Current Score: " + score);
    }
}
