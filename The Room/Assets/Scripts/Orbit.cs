using UnityEngine;

public class Orbit : MonoBehaviour
{
    // public Transform transform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // transform = GetComponent<Transform>();
        
        //Actually, no need to define "transform" like this ourselves, since every MonoBehaviour already has a "transform" property built in that's defined exactly as we did above.

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 20);
    }
}
