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
    ///The DataChangeCCMov recording.
    /// </summary>
    [TestModule("47e45141-c195-49c9-a1dc-c37c6c3d9677", ModuleType.Recording, 1)]
    public partial class DataChangeCCMov : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RepoCargaInicial repository.
        /// </summary>
        public static RepoCargaInicial repo = RepoCargaInicial.Instance;

        static DataChangeCCMov instance = new DataChangeCCMov();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DataChangeCCMov()
        {
            bat_a_ejecutar = "";
            archivoSalida = "";
            modulo = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DataChangeCCMov Instance
        {
            get { return instance; }
        }

#region Variables

        string _bat_a_ejecutar;

        /// <summary>
        /// Gets or sets the value of variable bat_a_ejecutar.
        /// </summary>
        [TestVariable("9de7e461-15f1-45aa-88a2-93dddbc72fc0")]
        public string bat_a_ejecutar
        {
            get { return _bat_a_ejecutar; }
            set { _bat_a_ejecutar = value; }
        }

        string _archivoSalida;

        /// <summary>
        /// Gets or sets the value of variable archivoSalida.
        /// </summary>
        [TestVariable("bc35b015-206e-47c1-8bfd-760aeec77938")]
        public string archivoSalida
        {
            get { return _archivoSalida; }
            set { _archivoSalida = value; }
        }

        string _modulo;

        /// <summary>
        /// Gets or sets the value of variable modulo.
        /// </summary>
        [TestVariable("3213b7d6-b5e8-4fed-8170-f02cd424aec7")]
        public string modulo
        {
            get { return _modulo; }
            set { _modulo = value; }
        }

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

            LanzaCargaDataChangeCCMov(bat_a_ejecutar, archivoSalida, modulo);
            Delay.Milliseconds(0);
            
            VeridicaFinalDataChangeCCMOV(archivoSalida);
            Delay.Milliseconds(0);
            
            LanzadorCarga.RenombrarArchivo(archivoSalida);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
