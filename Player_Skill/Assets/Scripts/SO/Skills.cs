using System.Collections.Generic;
using UnityEngine;

namespace Crew7Studio
{
    [CreateAssetMenu(menuName = "RPG Generator/Player/Create Skill")]
    public class Skills : ScriptableObject
    {
        public string description;
        public Sprite icon;
        public int levelNeeded;
        public int XPNeeded;

        public List<PlayerAttributes> affectedAttributes = new List<PlayerAttributes>();
    }
}

