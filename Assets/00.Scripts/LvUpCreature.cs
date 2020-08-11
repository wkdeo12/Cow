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
            currentExp += 5;
            collision.transform.gameObject.SetActive(false);
            if (currentExp > nextExp)
            {
                lv++;
                transform.localScale *= 1.2f;
                currentExp = 0;
            }
        }
    }
}