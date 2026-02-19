using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehavior : MonoBehaviour
{
    public int faeCollected = 0;
    public int runesUnlocked = 0;

    public List<ParticleSystem> victoryParticles;
    public GameObject victoryText;

    public void IncreaseFaeCollected(int numFae) {
        faeCollected += numFae;
    }

    public void IncreaseRunesUnlocked(int numRunes) {
        runesUnlocked += numRunes;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        GameObject target = hit.gameObject;
        FaeBehavior faeBehavior = target.GetComponent<FaeBehavior>();
        if (faeBehavior != null) {
            IncreaseFaeCollected(1);
            faeBehavior.SelfDestruct();
        }
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (runesUnlocked >= 3)
        {
            foreach (var victory in victoryParticles) {
                Instantiate(victory, this.transform);
            }
            Instantiate(victoryText, transform);
            
        }
        
        
    }
}
