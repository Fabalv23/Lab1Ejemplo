using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDA;
using EjemploLab1.Models;

namespace EjemploLab1.DBContext
{
    public class DefaultConnection
    {
        private static volatile DefaultConnection Instance;
        private static object syncRoot = new Object();

        public List<Persona> Personas = new List<Persona>();
        public int IDactual { get; set; }

        private DefaultConnection()
        {
            IDactual = 0;
        }

        public static DefaultConnection getInstance
        {
            get {
                if (Instance == null) {
                    lock (syncRoot) {
                        if (Instance == null) {
                            Instance = new DefaultConnection();
                        }
                    }
                }
                return Instance;
            }
        }
        
    }
}