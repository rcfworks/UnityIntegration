using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game.voData
{
    public class vORendererData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool HasTrophy { get; set; }

        public int Max { get; set; }
        public int Min { get; set; }

        public string ElapsedTime { get; set; }

        public int Index { get; set; }
        public int Collected { get; set; }
    }
}
