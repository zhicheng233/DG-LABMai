using MelonLoader;

[assembly: MelonInfo(typeof(DG_LABMai.Core), "DG-LABMai", "1.0.0", "zhi_cheng233", null)]
[assembly: MelonGame("sega-interactive", "Sinmai")]

namespace DG_LABMai
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
    }
}