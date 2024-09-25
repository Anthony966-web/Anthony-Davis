using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionUpdater : MonoBehaviour
{
	public GameObject versionText;
    // Start is called before the first frame update
    void Start()
    {
	    Debug.Log("Application Version : " + Application.version);
	    versionText.GetComponent<Text>().text = "Version : " + Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
