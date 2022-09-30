using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace program
{
    internal class store
    {
        private int id;
        private string name;
        private int no_of_branches;
        private int no_of_employe;
        private int no_of_manager;
        private string location;
        public int Id
        {
            get { return id;}
            set {id = value;}
        }
        public string Name
        {
            get { return name;}
            set { name = value;}

            }
        public int Noofbrances
        {
            get {return no_of_branches;}
            set {no_of_branches = value; }
        }
        public int employe
        {
            get { return no_of_employe; }
            set { no_of_employe = value; }
        }
        public int Noofmanager
        {
            get { return no_of_manager;}
            set { no_of_manager = value;}
        }
        public string Location
        {
            get { return location;}
            set {location = value;}
        }
        public void totalemploye()
        {
            int total = no_of_manager + no_of_employe + no_of_branches;
            Console.WriteLine(total);
        }
    }
    }
