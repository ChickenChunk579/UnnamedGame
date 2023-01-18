using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class LobbyCanvas : MonoBehaviour
{
    public TextMeshProUGUI codeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = PhotonNetwork.CurrentRoom.Name;
    }
}
