using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvUpCreature : MonoBehaviour
{
    public int lv = 0;
    public int nextExp = 5;
    public int currentExp = 0;

    public virtual void LvUp()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.localScale.x > transform.localScale.x)
        {
            return;
        }
        else
        {
            currentExp++;
            collision.transform.gameObject.SetActive(false);
        }
    }
}