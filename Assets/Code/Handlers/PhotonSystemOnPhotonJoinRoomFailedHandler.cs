// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace DireDungeons {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using uFrame.Kernel;
    
    
    public class PhotonSystemOnPhotonJoinRoomFailedHandler {
        
        public LobbyButton Source;
        
        private uFrame.ECS.OnPhotonJoinRoomFailedDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private string ActionNode10_RoomId = default( System.String );
        
        private int ActionNode10_MaxPlayers = default( System.Int32 );
        
        private DireDungeons.JoinRoomFailed ActionNode10 = new DireDungeons.JoinRoomFailed();
        
        public uFrame.ECS.OnPhotonJoinRoomFailedDispatcher Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode10_RoomId = Source.RoomId;
            ActionNode10_MaxPlayers = Source.MaxPlayers;
            // ActionNode
            while (this.DebugInfo("e03f68f8-7483-40e8-a4ed-d2243c3a140d","1b6e480f-e9a4-4548-a35a-e44cae0f45d9", this) == 1) yield return null;
            // Visit DireDungeons.JoinRoomFailed
            ActionNode10.RoomId = ActionNode10_RoomId;
            ActionNode10.MaxPlayers = ActionNode10_MaxPlayers;
            ActionNode10.System = System;
            ActionNode10.Execute();
            yield break;
        }
    }
}