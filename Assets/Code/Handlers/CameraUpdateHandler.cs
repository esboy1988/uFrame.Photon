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
    using DireDungeons;
    
    
    public class CameraUpdateHandler {
        
        public FollowUser Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private DireDungeons.FollowUser ActionNode6_FollowUser = default( DireDungeons.FollowUser );
        
        private DireDungeons.UpdateFollowUser ActionNode6 = new DireDungeons.UpdateFollowUser();
        
        public uFrame.ECS.ISystemUpdate Event {
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
            ActionNode6_FollowUser = this.Group;
            // ActionNode
            while (this.DebugInfo("","7035a610-77c8-488e-bc6e-4576c1841565", this) == 1) yield return null;
            // Visit DireDungeons.UpdateFollowUser
            ActionNode6.FollowUser = ActionNode6_FollowUser;
            ActionNode6.System = System;
            ActionNode6.Execute();
            yield break;
        }
    }
}
