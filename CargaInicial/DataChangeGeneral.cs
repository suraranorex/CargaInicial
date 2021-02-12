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
    ///The DataChangeGeneral recording.
    /// </summary>
    [TestModule("5dbd4375-d139-4ec0-8d49-9e0e3f528dd3", ModuleType.Recording, 1)]
    public partial class DataChangeGeneral : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RepoCargaInicial repository.
        /// </summary>
        public static RepoCargaInicial repo = RepoCargaInicial.Instance;

        static DataChangeGeneral instance = new DataChangeGeneral();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DataChangeGeneral()
        {
            bat_a_ejecutar = "";
            modulo = "";
            archivoSalida = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DataChangeGeneral Instance
        {
            get { return instance; }
        }

#region Variables

        string _bat_a_ejecutar;

        /// <summary>
        /// Gets or sets the value of variable bat_a_ejecutar.
        /// </summary>
        [TestVariable("2b0746ce-7809-4234-a927-07533d0c9d12")]
        public string bat_a_ejecutar
        {
            get { return _bat_a_ejecutar; }
            set { _bat_a_ejecutar = value; }
        }

        string _modulo;

        /// <summary>
        /// Gets or sets the value of variable modulo.
        /// </summary>
        [TestVariable("5183d622-4b52-45e9-86bb-a5d3040476b6")]
        public string modulo
        {
            get { return _modulo; }
            set { _modulo = value; }
        }

        string _archivoSalida;

        /// <summary>
        /// Gets or sets the value of variable archivoSalida.
        /// </summary>
        [TestVariable("e5d4d70a-6d8a-4ef1-9acd-82bffd6ff089")]
        public string archivoSalida
        {
            get { return _archivoSalida; }
            set { _archivoSalida = value; }
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

            LanzaCargaDataChangeCC(bat_a_ejecutar, archivoSalida, modulo);
            Delay.Milliseconds(0);
            
            VerificaFinalDataChangeCC(archivoSalida);
            Delay.Milliseconds(0);
            
            LanzadorCarga.RenombrarArchivo(archivoSalida);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}