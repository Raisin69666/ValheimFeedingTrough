using System;
using System.Data.Common;
using BepInEx;
using HarmonyLib;

namespace ValheimFeedingTrough
{
    // BepInEx Attributes
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class ValheimFeedingTroughPlugin : BaseUnityPlugin
    {
        // Unique Mod ID (Reverse-Domain)
        private const string ModGUID = "com.raisin69666.valheimfeedingtrough";
        private const string ModName = "Valheim Feeding Trough";
        private const string ModVersion = "1.0.0";

        // Called only once by BepInEx when game starts
        private void Awake()
        {
            // Show message in BepInEx console
            Logger.LogInfo($"Congrats! The mod {ModName} version {ModVersion} has been succesfully loaded!");
        }
    }
}
