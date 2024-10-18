using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//simple sprite swapping implementation of HMI base class
public class SpriteHMI : HMI
{
    [SerializeField]
    SpriteRenderer _renderer;
    [SerializeField]
    Sprite stop;
	[SerializeField]
	Sprite walk;
	[SerializeField]
    Sprite welcome;
    [SerializeField]
    Sprite disabled;
    [SerializeField]
    Sprite danger;

    public override void Display(HMIState state)
    {
        base.Display(state);
        Sprite spr = null;
        switch (state)
        {
            case HMIState.STOP:
                spr = stop;
                break;
            case HMIState.WALK:
                spr = walk;
                break;
            case HMIState.WELCOME:
                spr = welcome;
                break;
            case HMIState.DANGER:
                spr = danger;
                break;
            default:
                spr = disabled;
                break;
        }
        _renderer.sprite = spr;
    }
}

