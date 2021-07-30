using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * 
 * FIX THE STAGE NUMBER COUNTER DOENS'T WORK NULL REF EXPECTION LINE 27
 * 
 * 
 */
public class LoadNextLevel : MonoBehaviour
{
    public Player player;
    public UIManager ui;

    private int rand;

    void OnTriggerEnter2D(Collider2D other)
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (other.CompareTag("Player"))
        {
            //rand = Random.Range(1, 4);
            //Debug.Log("RAND IS: " + rand);
            SceneManager.LoadScene(1);

            //player.updateStageLevel();
            
                if (player != null)
                {
                    player.updateStageLevel();
                }   
        }
       
    }
}
