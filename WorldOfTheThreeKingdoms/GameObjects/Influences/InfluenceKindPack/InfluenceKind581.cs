﻿using GameObjects;
using GameObjects.Influences;
using System;


using System.Runtime.Serialization;namespace GameObjects.Influences.InfluenceKindPack
{

    [DataContract]public class InfluenceKind581 : InfluenceKind
    {

        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.InevitableRaoluanOnLowerIntelligence = true;
        }

        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.InevitableRaoluanOnLowerIntelligence = false;
        }
    }
}

