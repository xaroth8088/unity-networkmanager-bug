using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MenuManager : MonoBehaviour
{
    public void OnBecomeHostClicked()
    {
        Debug.Log("Becoming a host now...");
        bool result = NetworkManager.Singleton.StartHost();
        Debug.Log("StartHost returned: " + result);
    }

    public void OnBecomeClientClicked()
    {
        Debug.Log("Becoming a client now...");
        bool result = NetworkManager.Singleton.StartClient();
        Debug.Log("StartClient returned: " + result);
    }

    public void OnShutdownClicked()
    {
        Debug.Log("Shutting down...");
        NetworkManager.Singleton.Shutdown();
        Debug.Log("Shutdown did not throw.");
    }
}
