using UnityEngine;
[CreateAssetMenu(fileName = "ServerConfig", menuName = "Configurations/ServerConfig")]
public class ServerConfig : ScriptableObject
{
    [Header("Server URL")]
    public static string hostUrl = "http://localhost:8080";
}