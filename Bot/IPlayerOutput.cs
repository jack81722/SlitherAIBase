using FTServer.Projects.Slither.Packet;

namespace GameServer
{
    public interface IPlayerOutput
    {
        void SendInput(float angle);
        void SendInput(Skill.Category skill);
        void Rebirth(int type);

        void UseItem();

        void Broadcast(string data);
        void Send(string data);
    }
}