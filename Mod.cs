using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace ImprovsharkFoiled
{
    public class Foiled : Mod
    {
        public override void Ready()
        {
            Logger.Log("Ready!");
            Harmony.CreateAndPatchAll(typeof(Foiled));
        }

        [HarmonyPatch(typeof(CardData), "Awake"), HarmonyPostfix]
        static void setFoil(CardData __instance)
        {
            __instance.IsFoil = true;
        }
    }
}