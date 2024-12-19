using HarmonyLib;
using StationeersMods.Interface;

namespace examplepatchmod
{
    [StationeersMod("ExamplePatchMod","ExamplePatchMod [StationeersMods]","0.2.4657.21547.1")]
    class ExamplePatchMod : ModBehaviour
    {
        // private ConfigEntry<bool> configBool;
        public override void OnLoaded(ContentHandler contentHandler)
        {
            //READ THE README FIRST! 
            
            //Config example
            // configBool = Config.Bind("Input",
            //     "Boolean",
            //     true,
            //     "Boolean description");
            
            // Harmony harmony = new Harmony("ExamplePatchMod");
            // harmony.PatchAll();
            UnityEngine.Debug.Log("ExamplePatchMod Loaded!");
        }
    }
}