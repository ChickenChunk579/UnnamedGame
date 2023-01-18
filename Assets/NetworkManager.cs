using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public int codeLength = 6;
    public TMP_InputField code;
    public GameObject loadingScreen;

    public string GenerateCode(int length)
    {
        string output = "";
        for (int i = 0; i < length; i++)
        {
            char c = (char)Random.Range(65, 65 + 26);
            output += c;
        }

        return output;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        PhotonNetwork.ConnectUsingSettings();
    }

    public void CreateGame()
    {
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;

        PhotonNetwork.JoinOrCreateRoom(GenerateCode(codeLength), options, TypedLobby.Default);
    }

    public void JoinGame()
    {
        PhotonNetwork.JoinRoom(code.text);
    }

    public override void OnJoinedRoom()
    {
        print("Joined room");
        PhotonNetwork.LoadLevel("Lobby");
    }

    public override void OnConnectedToMaster()
    {
        loadingScreen.SetActive(false);
    }
}
