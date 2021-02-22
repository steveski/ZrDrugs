namespace ZrDrugs.Server
{
    using System;
    using CitizenFX.Core;
    using CitizenFX.Core.Native;

    public class ZrDrugsServer : BaseScript
    {
        public ZrDrugsServer()
        {
            EventHandlers["onResourceStart"] += new Action<string>(OnResourceStart);

        }

        private void OnResourceStart(string resourceName)
        {
            if (API.GetCurrentResourceName() != resourceName)
                return;

            Debug.WriteLine($"Resource {resourceName} loaded (server)");

        }

    }
}
