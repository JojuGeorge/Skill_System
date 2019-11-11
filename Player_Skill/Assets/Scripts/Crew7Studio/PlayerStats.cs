 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crew7Studio
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Main Player Stats")]
        public string playerName;
        public int playerLevel = 1;
        public int playerXP = 0;
        public int playerHP = 50;   // base = 50; +10 each level

        [Header("Player Attributes")]
        public List<PlayerAttributes> attributes = new List<PlayerAttributes>();

        void Start()
        {

        }

        void Update()
        {

        }
    }
}
