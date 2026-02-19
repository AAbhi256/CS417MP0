using UnityEngine;

public class OrbBehavior : MonoBehaviour
{
    public OrbType orbType;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public enum OrbType {  
    None,
    Red,
    Green,
    Blue
}