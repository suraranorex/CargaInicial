﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////
using System.IO;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace PruebaConsola
{
    public partial class CargaPaisesBajos_AB
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void LanzaCargaInicial()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            Process p = new Process();
            ProcessStartInfo S = new ProcessStartInfo();
            
            p.StartInfo.FileName = "cmd.exe";
            //string cmd1 = "/C C:\\Carga_Inicial_QA\\Localidades\\install_zone_fileQA2AR.bat";
            //string cmd2 = "C:\\Carga_Inicial_QA\\Localidades -localdevMSSQL ab";
            
            //p.StartInfo.Arguments = cmd1 + "\"" + cmd2 + "\"" + " > C:\\TEMP\\SalidaComando.txt";            
            p.StartInfo.Arguments = @"/C .\Utilitarios\lanzador_paises_bajos_ab.bat";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            
            //p.StartInfo = S;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Report.Info("INFO: ",output);
            Report.Info("ERROR: ",error);
        }

        public void VerificaFinal()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            string aux = string.Empty;
            
           
            try{
            	
            	aux = File.ReadAllText(@".\Utilitarios\SalidaComando_Paises_Bajos_AB.txt");
            	
            	if (aux.Contains("Server in multiuser mode"))
            		Report.Info("Info: ","El proceso finalizó correctamente");
            	else
            		Report.Info("Info: ","El proceso finalizo incorrectamente");
            
            }
            catch(Exception e){
            	Report.Failure("I/O","Error: No se encontró el archivo\r\n" + e);
            
            }
        }

        public void RenombrarArchivo()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            
            bool existe = File.Exists(@".\Utilitarios\SalidaComando_Paises_Bajos_AB.txt");
			
			try {
				if (existe)
				{
					//File.Delete(@".\Utilitarios\SalidaComando_AB.txt");
					//File.Move(@"d:\temp\faf.txt",@"d:\temp\faf_"+ System.DateTime.Now.ToString("yyyyMMdd_hhMMss") +".txt");
					
					File.Move(@".\Utilitarios\SalidaComando_Paises_Bajos_AB.txt",@".\Utilitarios\SalidaComando_Paises_Bajos_AB_"+ System.DateTime.Now.ToString("yyyyMMdd_hhmmss") +".txt");
					Report.Success("I/O","Finalizado el proceso. Renombre Exitoso");
				}
				else{
					Report.Error("No existe el Archivo");
				}
				
			} catch (Exception e) {
				Report.Failure("I/O","No se pudo realizar la operacion\r\nError: " + e);
			}
        }

    }
}
