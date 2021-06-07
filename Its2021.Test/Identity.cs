using System;
using System.Collections.Generic;
using System.Text;

namespace Its2021.Test
{
    public class Identity
    {
        private string name;
        public string Name
        {
            get => name.ToUpper();
            set { name = value.Trim(); }
        }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public void Show() => Console.WriteLine(ToString());
        public override string ToString() 
            => $"Nome: {Name} Cognome: {Surname} Data di nascita: {BirthDate}";
    }
}