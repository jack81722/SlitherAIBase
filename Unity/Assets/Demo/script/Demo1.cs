using ConsoleApp1;
using GameServer;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo1 : MonoBehaviour
{
    private const string agentServerIP = "http://35.187.146.144:30001"; //slither dev
    GamerEntity ai;
    // Start is called before the first frame update
    void Start()
    {
        ai = new GamerEntity(Guid.NewGuid().ToString());
        ai.Start(agentServerIP, new ConsoleBotProxy());
        ai.onReceiveGamerInfo += Ai_onReceiveGamerInfo;
    }

    private void Ai_onReceiveGamerInfo(GamingRoom.Gaming.Packet.GamersPacket obj)
    {
        Debug.Log("Ai_onReceiveGamerInfo" + obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        ai.Dispose();
    }
}
