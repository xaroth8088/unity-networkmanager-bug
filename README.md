# unity-networkmanager-bug
An example project for a state machine bug in NetworkManager

# Steps to reproduce
1. Stop the project (if running)
2. Run the project
3. Click 'Shutdown'
4. Click 'Become Host'

# Expected results
`NetworkManager` changes to host mode.  Also, a new `ConnectedClient` game object is inserted into the scene.

# Actual results
`NetworkManager` does not change to host mode.  Also, the `ConnectedClient` game object does not get created.

## Additional
5. Click `Become Host`

🙂 `NetworkManager` changes to host mode.  Also, a new `ConnectedClient` game object is inserted into the scene.

6. Click `Shutdown`
7. Click `Shutdown` again
8. Click `Become Host`

😢 `NetworkManager` does not change to host mode.  Also, the `ConnectedClient` game object does not get created.

9. Click `Become Host` again

🙂 `NetworkManager` changes to host mode.  Also, a new `ConnectedClient` game object is inserted into the scene.
