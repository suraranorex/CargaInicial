/*
 * Created by Ranorex
 * User: MaRuiz
 * Date: 5/10/2020
 * Time: 16:28
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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
using Ranorex.Core.Testing;

namespace PruebaConsola
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class LanzadorCarga
    {
    	// You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void LazaCargaInicial(string bat_lanzador, string bat_a_ejecutar)
    	{
    		
    		// TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            Report.Info("Info","Iniciando proceso");
            Process p = new Process();
            ProcessStartInfo S = new ProcessStartInfo();
            
            p.StartInfo.FileName = "cmd.exe";
            string cmd1 = @"/C .\Utilitarios\" + bat_lanzador + " ";
            string cmd2 = bat_a_ejecutar;
            
            //p.StartInfo.Arguments = cmd1 + "\"" + cmd2 + "\"" + " > C:\\TEMP\\SalidaComando.txt";            
            p.StartInfo.Arguments = cmd1 + cmd2;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            
            //p.StartInfo = S;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            //string error = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Report.Info("INFO: ",output);
            //Report.Info("ERROR: ",error);
    		
    	} 
    	
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void VerificaFinal(string Datos_Salida)
    	{
    		 // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            string aux = string.Empty;
            
           
            try{
            	
            	aux = File.ReadAllText(@".\Utilitarios\" + Datos_Salida);
            	
            	if (aux.Contains("Server in multiuser mode"))
            		Report.Success("Info: ","El proceso finalizó correctamente");
            	else
            		Report.Error("Info: ","El proceso finalizo incorrectamente");
            
            }
            catch(Exception e){
            	Report.Failure("I/O","Error: No se encontró el archivo\r\n" + e);
            
            }
    		
    	}
    	
    	
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void RenombrarArchivo(string Datos_Salida)
    	{
    		// TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            
            string nombrearchivo = Datos_Salida.Split('.')[0];
            //WinForms.MessageBox.Show(nombrearchivo);
          
            bool existe = File.Exists(@".\Utilitarios\" + Datos_Salida);
			
			try {
				if (existe)
				{
					//File.Delete(@".\Utilitarios\SalidaComando_AB.txt");
					//File.Move(@"d:\temp\faf.txt",@"d:\temp\faf_"+ System.DateTime.Now.ToString("yyyyMMdd_hhMMss") +".txt");
					
					File.Move(@".\Utilitarios\" + Datos_Salida,@".\Utilitarios\" + nombrearchivo + "_"+ System.DateTime.Now.ToString("yyyyMMdd_hhmmss") +".txt");
					Report.Success("I/O","Finalizado el proceso. Renombre Exitoso");
				}
				else{
					Report.Error("No existe el Archivo");
				}
				
			} catch (Exception e) {
				Report.Failure("I/O","No se pudo realizar la operacion\r\nError: " + e);
			}
    	}
    	
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void LanzaCargaInicial(String bat_a_ejecutar, String modulo, String archivoSalida)
    	{
    		// TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            Report.Info("Info","Ejecutando el proceso");
            Process p = new Process();
            ProcessStartInfo S = new ProcessStartInfo();
            
            p.StartInfo.FileName = "cmd.exe";
            string cmd1 = @"/C .\Utilitarios\lanzadorComun.bat ";
            string cmd2 = bat_a_ejecutar;
            string cmd3 = modulo;
            string cmd4 = archivoSalida;
            
            //p.StartInfo.Arguments = cmd1 + "\"" + cmd2 + "\"" + " > C:\\TEMP\\SalidaComando.txt";            
            p.StartInfo.Arguments = cmd1 +" "+ cmd2 +" "+ cmd3 +" "+ cmd4;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            
            //p.StartInfo = S;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            //string error = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Report.Info("INFO: ",output);
            //Report.Info("ERROR: ",error);
    		
    	}
    	
    }
}
