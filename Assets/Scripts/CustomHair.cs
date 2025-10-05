using UnityEngine;


public class CustomHair : MonoBehaviour
{

    public GameObject[] Hair;
    private int currenthair;

    public void NewHair()
    {
        if (currenthair == Hair.Length - 1)
        {
            currenthair = 0;
        }
        else 
        { 
            currenthair++;
        }


    }

    void Update()
    {
        for (int i = 0; i < Hair.Length; i++)
        {
            if(i == currenthair)
            {
                Hair[i].SetActive(true);
            }
            else 
            {
                Hair[i].SetActive (false);
            }
        }
    }
}
