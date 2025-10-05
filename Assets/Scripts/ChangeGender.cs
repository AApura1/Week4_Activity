using UnityEngine;

public class ChangeGender : MonoBehaviour
{
    public GameObject[] Charcter;
    private int currentchar;

    public void NewChar()
    {
        if (currentchar == Charcter.Length - 1)
        {
            currentchar = 0;
        }
        else
        {
            currentchar++;
        }


    }

    void Update()
    {
        for (int i = 0; i < Charcter.Length; i++)
        {
            if (i == currentchar)
            {
                Charcter[i].SetActive(true);
            }
            else
            {
                Charcter[i].SetActive(false);
            }
        }
    }
}
