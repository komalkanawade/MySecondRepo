using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPattern
{
    internal class Singleton
    {
        // declare private static field
        public static Singleton instance;

        private static ConnectionMultiplexer con;

        private static IDatabase db;

        // private constructor
        private Singleton()
        {
            con = ConnectionMultiplexer.Connect("localhost");
        }

        // GetInstance method which will be be accessed from outside scope

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Any business logic needed
       public IDatabase getDatabaseObject()
        {
            db = con.GetDatabase();
            return db;
        }
    }
}
