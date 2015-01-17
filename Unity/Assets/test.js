#pragma strict

function Start () {
	MasterServer.RequestHostList("ProjectDragonite");
	var data : HostData[] = MasterServer.PollHostList();
    // Go through all the hosts in the host list
    Debug.Log(MasterServer.PollHostList().Length);
    for (var element in data)
    {
        GUILayout.BeginHorizontal();    
        var name = element.gameName + " " + element.connectedPlayers + " / " + element.playerLimit;
        GUILayout.Label(name);  
        GUILayout.Space(5);
        var hostInfo;
        hostInfo = "[";
        for (var host in element.ip)
            hostInfo = hostInfo + host + ":" + element.port + " ";
        hostInfo = hostInfo + "]";
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("Connect"))
        {
            // Connect to HostData struct, internally the correct method is used (GUID when using NAT).
            Network.Connect(element);           
        }
        GUILayout.EndHorizontal();  
    }
    Debug.Log("hello");
}
