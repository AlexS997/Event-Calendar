using Microsoft.Ajax.Utilities;
using System;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            vLogin vLogin = new vLogin();
            vLogin.Show();
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}