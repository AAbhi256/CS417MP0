using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RuneBehavior : MonoBehaviour
{
    public RuneType runeType;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor sock;
    public PlayerBehavior player;
    void Start()
    {
        // same as sock = this.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>(); but "this" is implied
        sock = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();

        // sock.selectEntered is an event. The listener we add to it is the method that is called upon the event's occurence.
        sock.selectEntered.AddListener(OnInSocket);
        sock.selectExited.AddListener(OnOutSocket);
        
    }
    void OnInSocket(SelectEnterEventArgs args)
    {
        GameObject item = args.interactableObject.transform.gameObject;
        OrbBehavior orbBehavior = item.GetComponent<OrbBehavior>();
        
        if (orbBehavior.orbType == OrbType.Red && runeType == RuneType.Red) {
            player.IncreaseRunesUnlocked(1);
        }

        if (orbBehavior.orbType == OrbType.Blue && runeType == RuneType.Blue) {
            player.IncreaseRunesUnlocked(1);
        }

        if (orbBehavior.orbType == OrbType.Green && runeType == RuneType.Green) {
            player.IncreaseRunesUnlocked(1);
        }


    }

    void OnOutSocket(SelectExitEventArgs args)
    {
        GameObject item = args.interactableObject.transform.gameObject;
        OrbBehavior orbBehavior = item.GetComponent<OrbBehavior>();
        
        if (orbBehavior.orbType == OrbType.Red && runeType == RuneType.Red) {
            player.IncreaseRunesUnlocked(-1);
        }

        if (orbBehavior.orbType == OrbType.Blue && runeType == RuneType.Blue) {
            player.IncreaseRunesUnlocked(-1);
        }

        if (orbBehavior.orbType == OrbType.Green && runeType == RuneType.Green) {
            player.IncreaseRunesUnlocked(-1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public enum RuneType {  
    None,
    Red,
    Green,
    Blue
}
