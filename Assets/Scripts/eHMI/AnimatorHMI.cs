using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Animator based HMI implementation
public class AnimatorHMI : HMI
{
    [SerializeField]
    MeshRenderer meshRenderer;
    Material material;
    [SerializeField]
    Animator animator;

    //Animator triggers
    [SerializeField]
    string stopTrigger = "merging";
    [SerializeField]
    string walkTrigger = "restart";
    [SerializeField]
    string disabledTrigger = "disabled";
    [SerializeField]
    string welcomeTrigger = "welcome";

    //texture to be set on certain state changes
    [SerializeField]
    Texture2D merging;
    [SerializeField]
    Texture2D walk;
    [SerializeField]
    Texture2D welcome;
    [SerializeField]
    Texture2D danger;
    [SerializeField]
    Texture2D disabled;

    private void Awake()
    {
        material = meshRenderer.material;
    }

    public override void Display(HMIState state)
    {
        base.Display(state);
        switch (state)
        {
            case HMIState.STOP:
                material.mainTexture = merging;
                animator.SetTrigger(stopTrigger);
                break;
            case HMIState.WALK:
                material.mainTexture = walk;
                animator.SetTrigger(walkTrigger);
                break;
            case HMIState.WELCOME:
                material.mainTexture = welcome;
                animator.SetTrigger(walkTrigger);
                break;
            case HMIState.DANGER:
                material.mainTexture = danger;
                animator.SetTrigger(walkTrigger);
                break;
            default:
                material.mainTexture = disabled;
                animator.SetTrigger(disabledTrigger);
                break;
        }
    }
}