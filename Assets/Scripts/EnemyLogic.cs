﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    float Health = 20;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerProjectile")
        {
            Destroy(collision.gameObject);

            --Health;
            if (Health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
