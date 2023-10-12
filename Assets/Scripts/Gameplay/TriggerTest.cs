using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTest : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "SpeedCoin")
        {
            gameObject.GetComponent<Player>().moveSpeed = gameObject.GetComponent<Player>().moveSpeed + 2.5f;
        }
        else if (collision.gameObject.tag == "DmgCoin")
        {
            gameObject.GetComponent<Player>().lives = gameObject.GetComponent<Player>().lives - 1.0f;
            Debug.Log("Lives: " + gameObject.GetComponent<Player>().lives);
            if (gameObject.GetComponent<Player>().lives == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        else if (collision.gameObject.tag == "Coin")
        {
            gameObject.GetComponent<Player>().points = gameObject.GetComponent<Player>().points + 1.0f;
            Debug.Log("Points: " + gameObject.GetComponent<Player>().points);
        }
        
        
    }
}
