using UnityEngine;

public class CustomPants : MonoBehaviour
{
    public GameObject[] Pants;
    private int currentpants;

    public void NewPants()
    {
        if (currentpants == Pants.Length - 1)
        {
            currentpants = 0;
        }
        else
        {
            currentpants++;
        }


    }

    void Update()
    {
        for (int i = 0; i < Pants.Length; i++)
        {
            if (i == currentpants)
            {
                Pants[i].SetActive(true);
            }
            else
            {
                Pants[i].SetActive(false);
            }
        }
    }
}
