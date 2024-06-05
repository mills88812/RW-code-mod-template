using BepInEx;
using Fisobs.Core;
using Menu.Remix.MixedUI;
using MonoMod.RuntimeDetour;
using RWCustom;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using UnityEngine;
using Random = UnityEngine.Random;


#pragma warning disable CS0618 // Type or member is obsolete
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[module: UnverifiableCode]
#pragma warning restore CS0618 // Type or member is obsolete
namespace FriendlyLizard
{
    [BepInPlugin("thelost", "The Lost", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {

	/*Put plugins here
		Press CTRL+B to build project and all files will automaticly place themselves within the mod folder within the directory.*/
        public void OnEnable()
        {
            Content.Register(new FriendlyLizardcritob());
            
       
         
         

        }




     
 
    }   
}