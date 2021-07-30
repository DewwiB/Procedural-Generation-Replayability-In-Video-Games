using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomList : MonoBehaviour
{
    public RoomTemplates templates;
    public object rooms;

    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Room").GetComponent<RoomTemplates>();
        templates.rooms.Add(this.gameObject);    
    }
}
