using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSteps : MonoBehaviour
{
    [SerializeField] AudioSource audio0;
    [SerializeField] AudioSource audio1;

    public void PlayerLeftStep()
    {
        audio0.Play();
    }

    public void PlayerRightStep()
    {
        audio1.Play();
    }
}
