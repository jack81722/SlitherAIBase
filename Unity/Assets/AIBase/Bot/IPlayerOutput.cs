using FTServer.Projects.Slither.Packet;
using SlitherEvo.Synchronize;

namespace GameServer
{
    public interface IPlayerOutput
    {
        void SendInput(float angle);
        void SendInput(Skill.Category skill);
        void Rebirth(ERebirth type);

        void UseItem();

        void Broadcast(string data);
        void Send(string data);
    }
}