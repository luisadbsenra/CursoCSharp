using System;
using System.IO;


namespace CursoCSharp.API {

    public static class ExtensaoString {
        //substritui o ~ pela pasta home do usuario{
        
        public static string ParseHome(this string path) {
            string home =  (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME") : 
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);

        }
    }
    internal class First {
        public static void Exe() {
            // não interpetrar o /t
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é o");
                    sw.WriteLine("nosso ");
                    sw.WriteLine("grande");
                    sw.WriteLine("arquivo");
                }
            }

            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("linha");
                sw.WriteLine("nao linha");
                sw.WriteLine("poop");
            }
        }
    }
}