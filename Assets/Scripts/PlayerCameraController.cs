using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerCameraController : NetworkBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject camera;
    public override void OnStartAuthority() 
    {
        base.OnStartAuthority();
        camera.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
