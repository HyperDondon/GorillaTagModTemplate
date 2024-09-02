using Photon.Pun;
using UnityEngine;
using Utilla;

public delegate void OnModdedJoin();
public delegate void OnModdedLeave();

namespace GorillaTagModTemplateProject
{
    public class RoomUtils : MonoBehaviour
    {
        public static event OnModdedJoin OnModdedJoinEvent;
        public static event OnModdedLeave OnModdedLeaveEvent;

        void Update()
        {
            if (Plugin.inModded)
                if (!PhotonNetwork.CurrentRoom.CustomProperties["gameMode"].ToString().Contains("MODDED_"))
                    OnModdedLeaveEvent.Invoke();
        }

        /* This attribute tells Utilla to call this method when a modded room is joined */
        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
            /* Activate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            Plugin.inModded = true;
            OnModdedJoinEvent.Invoke();
        }

        /* This attribute tells Utilla to call this method when a modded room is left */
        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
            /* Deactivate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            Plugin.inModded = false;
            OnModdedLeaveEvent.Invoke();
        }
    }
}
