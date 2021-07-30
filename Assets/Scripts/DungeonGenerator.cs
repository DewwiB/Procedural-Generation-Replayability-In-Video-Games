using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public int openingDirection = 0;
    // 1 = top
    // 2 = right
    // 3 = bottom
    // 4 = left

    // Access Room Templates script/class
    private RoomTemplates templates;

    //rng for tiles/templates based on condition
    private int rand; // rand tile map 
    private int rng; // rng spawn room objects
    private int chance; // 50 50 chance to spawn an room object

    public bool spawned = false;

    //public float waitTime = 4f;

    private RoomObjects RoomObjects;
    public int anObject = 0;

    void Start()
    {
        // Set templates to all objects tagged with Rooms, in Room Templates.
        templates = GameObject.FindGameObjectWithTag("Room").GetComponent<RoomTemplates>();

        Invoke("Spawn", 0.1f);

        RoomObjects = GameObject.FindGameObjectWithTag("Object").GetComponent<RoomObjects>();
        Invoke("SpawnObjects", 0.1f);  
    }

     void Spawn()
    {
        if (spawned == false)
        {
            if (openingDirection == 1) // Spawn room with an bottom door
            {
                rand = Random.Range(0, templates.bottomRooms.Length); // rand 0 to length of all prefabs with top openings
                // instantiate rand template with bottom opening at current location 
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);           
            }

            else if (openingDirection == 2) // Spawn room with left door
            {
                rand = Random.Range(0, templates.leftRooms.Length); // rand 0 to length of all prefabs with north openings
                // instantiate rand template with left opening at current location 
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation); 
            }

            else if (openingDirection == 3) // spawn room with top door
            {
                rand = Random.Range(0, templates.topRooms.Length); // rand 0 to length of all prefabs with north openings
                // instantiate rand template with top opening at current location 
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation); 
            }
            
            else if (openingDirection == 4) // spawn room with right door
            {
                rand = Random.Range(0, templates.rightRooms.Length); // rand 0 to length of all prefabs with north openings
                // instantiate rand template with right opening at current location 
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation); 
            }
            spawned = true;
        }
    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spawnpoint"))
           {
            if (other.GetComponent<DungeonGenerator>().spawned == false & spawned == false)
            {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
            
        }
    }

    void SpawnObjects()
    {
            //public int spawnindex = 1;
            if (anObject == 1)
            {
                rng = Random.Range(0, RoomObjects.gameObjects.Length); // Create random number between zero and length of the array
                Instantiate(RoomObjects.gameObjects[rng], transform.position, RoomObjects.gameObjects[rng].transform.rotation);
            }
        

        chance = Random.Range(0, 2); // 0 or 1, 50 50 chance to spawn an item from RoomObjects.gameObjects
        if (chance == 1)
        {

            //public int spawnindex = 1;
            if (anObject == 2)
            {
                rng = Random.Range(0, RoomObjects.rocks.Length); // Create random number between zero and length of the array
                Instantiate(RoomObjects.rocks[rng], transform.position, RoomObjects.rocks[rng].transform.rotation);
            }
        }

       chance = Random.Range(0, 3); // 0 or 1, 50 50 chance to spawn an item from RoomObjects.gameObjects
        if (chance == 1)
        {

            //public int spawnindex = 1;
            if (anObject == 3)
            {
                rng = Random.Range(0, RoomObjects.loot.Length); // Create random number between zero and length of the array
                Instantiate(RoomObjects.loot[rng], transform.position, RoomObjects.loot[rng].transform.rotation);
            }
        }

        chance = Random.Range(0, 2); // 0 or 1, 50 50 chance to spawn an item from RoomObjects.gameObjects
        if (chance == 1)
        {

            //public int spawnindex = 1;
            if (anObject == 4)
            {
                rng = Random.Range(0, RoomObjects.trees.Length); // Create random number between zero and length of the array
                Instantiate(RoomObjects.trees[rng], transform.position, RoomObjects.trees[rng].transform.rotation);
            }
        }


        chance = Random.Range(0, 9); // 0 or 1, 50 50 chance to spawn an item from RoomObjects.gameObjects

        if (chance == 4)
        {

            //public int spawnindex = 1;
            if (anObject == 5)
            {
                rng = Random.Range(0, RoomObjects.chests.Length); // Create random number between zero and length of the array
                Instantiate(RoomObjects.chests[rng], transform.position, RoomObjects.chests[rng].transform.rotation);
            }
        }

        chance = Random.Range(0, 2); // 0 or 1, 50 50 chance to spawn an item from RoomObjects.gameObjects
        if (chance == 1)
        {

            //public int spawnindex = 1;
            if (anObject == 6)
            {
                rng = Random.Range(0, RoomObjects.bush.Length); // Create random number between zero and length of the array
                Instantiate(RoomObjects.bush[rng], transform.position, RoomObjects.bush[rng].transform.rotation);
            }
        }


        chance = Random.Range(0, 2); // 0 or 1, 50 50 chance to spawn an item from RoomObjects.gameObjects
        if (chance == 1)
        {

            //public int spawnindex = 1;
            if (anObject == 7)
            {
                rng = Random.Range(0, RoomObjects.fence.Length); // Create random number between zero and length of the array
                Instantiate(RoomObjects.fence[rng], transform.position, RoomObjects.fence[rng].transform.rotation);
            }
        }
    }
}
