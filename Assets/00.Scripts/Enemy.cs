using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int num = 0;
    public Player player;

    private void Awake()
    {
        if (num == 0)
        {
            player = FindObjectOfType<Player>();
        }
        else
        {
        }
    }
}