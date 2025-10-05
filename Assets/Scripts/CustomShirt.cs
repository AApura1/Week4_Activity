using UnityEngine;


public class CustomShirt : MonoBehaviour
{

    public GameObject[] Shirt;
    private int currentshirt;

    public void NewShirt()
    {
        if (currentshirt == Shirt.Length - 1)
        {
            currentshirt = 0;
        }
        else
        {
            currentshirt++;
        }


    }

    void Update()
    {
        for (int i = 0; i < Shirt.Length; i++)
        {
            if (i == currentshirt)
            {
                Shirt[i].SetActive(true);
            }
            else
            {
                Shirt[i].SetActive(false);
            }
        }
    }
}
