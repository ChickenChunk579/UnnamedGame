using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameStartManager : MonoBehaviourPun
{
    [PunRPC()]
    public void StartGame()
    {
        PhotonNetwork.LoadLevel("MainLevel");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            photonView.RPC("StartGame", RpcTarget.All);
        }
    }
}
