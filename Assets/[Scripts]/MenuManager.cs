using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            child.SetActive(false);
        }
    }

    public void OpenSection()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            if (child.activeInHierarchy) { child.SetActive(false); }

            else if (!child.activeInHierarchy) { child.SetActive(true); }
        }
    }
}
