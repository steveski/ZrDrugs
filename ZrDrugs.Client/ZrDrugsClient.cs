namespace ZrDrugs.Client
{
    using System;
    using CitizenFX.Core;
    using CitizenFX.Core.Native;

    public class ZrDrugsClient : BaseScript
    {
        public ZrDrugsClient()
        {
            EventHandlers["onResourceStart"] += new Action<string>(OnResourceStart);

        }

        private void OnResourceStart(string resourceName)
        {
            if (API.GetCurrentResourceName() != resourceName)
                return;

            Debug.WriteLine($"Resource {resourceName} loaded (client)");


        }
    }
}
