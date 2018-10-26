using System;
using ControllerDI.Interfaces;

namespace MvcMovie
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}