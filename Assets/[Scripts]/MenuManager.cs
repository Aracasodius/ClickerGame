using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject[] Sections;

    void Start()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            child.SetActive(false);
        }
    }

    void CheckSectionStatus()
    {
        for (int i = 0; i < Sections.Length; i++)
        {
            if (Sections[i].activeInHierarchy)
            {
                Sections[i].SetActive(false);
            }
        }
    }

    public void OpenSection()
    {
        CheckSectionStatus();
        int children = transform.childCount;
        for (int i = 0; i < children; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            if (child.activeInHierarchy) { child.SetActive(false); }

            else if (!child.activeInHierarchy) { child.SetActive(true); }
        }
    }
}
