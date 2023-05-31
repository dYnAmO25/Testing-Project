using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyLight : MonoBehaviour
{
    [SerializeField] Color[] colors;
    [SerializeField] float fIntervall;

    private int iCurrentColor;
    private float fWastedTime;
    private Light ligh;

    void Start()
    {
        ligh = GetComponent<Light>();
        ligh.color = colors[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(fWastedTime >= fIntervall)
        {
            fWastedTime = 0;
            ChangeLight();
        }

        fWastedTime += Time.deltaTime;
    }

    private void ChangeLight()
    {
        if (iCurrentColor < colors.Length - 1)
        {
            iCurrentColor++;
        }
        else
        {
            iCurrentColor = 0;
        }

        ligh.color = colors[iCurrentColor];
    }
}
