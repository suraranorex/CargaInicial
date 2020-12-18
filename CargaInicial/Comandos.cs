﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace PruebaConsola
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Comandos recording.
    /// </summary>
    [TestModule("dab9acd5-7d10-4c99-bad0-b1461e64d1ad", ModuleType.Recording, 1)]
    public partial class Comandos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RepoCargaInicial repository.
        /// </summary>
        public static RepoCargaInicial repo = RepoCargaInicial.Instance;

        static Comandos instance = new Comandos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Comandos()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Comandos Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.ProcesadorDeComandosDeWindows1Ve' at 20;19.", repo.Explorer.ProcesadorDeComandosDeWindows1VeInfo, new RecordItemIndex(0));
            //repo.Explorer.ProcesadorDeComandosDeWindows1Ve.Click("20;19");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'cd ' with focus on 'CWindowsSystem32CmdExe'.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(1));
            repo.CWindowsSystem32CmdExe.Self.EnsureVisible();
            Keyboard.Press("cd ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{RMenu down}{OemOpenBrackets}{LControlKey up}{RMenu up}{LControlKey up}{Return}' with focus on 'CWindowsSystem32CmdExe'.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(3));
            repo.CWindowsSystem32CmdExe.Self.EnsureVisible();
            Keyboard.Press("{LControlKey down}{RMenu down}{OemOpenBrackets}{LControlKey up}{RMenu up}{LControlKey up}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'R{LShiftKey down}:{LShiftKey up}{Return}' with focus on 'CWindowsSystem32CmdExe'.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(5));
            repo.CWindowsSystem32CmdExe.Self.EnsureVisible();
            Keyboard.Press("R{LShiftKey down}:{LShiftKey up}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'dir{Return}'.", new RecordItemIndex(7));
            Keyboard.Press("dir{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
