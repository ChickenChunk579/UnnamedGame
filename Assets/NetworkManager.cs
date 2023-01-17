using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField codeInput;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        PhotonNetwork.ConnectUsingSettings();
    }

    public void CreateOrJoinGame()
    {
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;

        PhotonNetwork.JoinOrCreateRoom(codeInput.text, options, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        print("Joined room");
        PhotonNetwork.LoadLevel("SampleScene");
    }
}
