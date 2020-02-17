using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;
using UnityEngine;
using System.Diagnostics;


namespace Utils
{
    
    static class outPut
    {
        static outPut()
        {

        }
        //[ConditionalAttribute("DEBUG")]
        public static void Log(String message)
        {
            Verse.Log.Message(message);
        }

    }
}
