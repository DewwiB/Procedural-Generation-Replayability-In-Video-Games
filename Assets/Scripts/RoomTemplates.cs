using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    // Array of different room types
    public GameObject[] topRooms;
    public GameObject[] rightRooms;
    public GameObject[] bottomRooms;
    public GameObject[] leftRooms;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    public float waitTime;

    private bool spawnedBoss;
    public GameObject boss;

    private bool exitSpawned;
    public GameObject exit;

    void Update()
    {
        if (waitTime <= 0 && spawnedBoss == false && exitSpawned == false)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == rooms.Count - 1)
                {
                    exit = Instantiate(exit, rooms[i].transform.position + new Vector3(0, 0, -0.1f), Quaternion.identity);

                    exitSpawned = true;
                }
                if (i == rooms.Count - 2)
                {
                    if (rooms[i] == closedRoom)
                    {
                        break;
                    }
                    boss = Instantiate(boss, rooms[i].transform.position + new Vector3(0,0,-0.1f), Quaternion.identity);
                    //boss.transform.localPosition = new Vector3 (0,0,-1);


                    //boss.transform.position = new Vector3(0, 0, -1);
                    spawnedBoss = true;
               
                }
                           
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
        }    
    }

}
