using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadlevel : MonoBehaviour
{
    public void Awake()
    {
        Instantiate(Resources.Load(PlayerPrefs.GetString("nowlevel")));
    }
}
