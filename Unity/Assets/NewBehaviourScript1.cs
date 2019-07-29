using ConsoleApp1;
using GameServer;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    private const string agentServerIP = "http://35.187.146.144:30001"; //slither dev
    GamerEntity ai;
    // Start is called before the first frame update
    void Start()
    {
        ai = new GamerEntity(Guid.NewGuid().ToString());
        ai.Start(agentServerIP, new ConsoleBotProxy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
