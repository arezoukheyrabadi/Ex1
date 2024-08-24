using Presence_Absence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presence_Absence.Service
{
    internal class PrecenceService
    {
        public static List<Person> PersonList = new List<Person>();

        // Save List
        public void SaveList(int Id, string Name, string LastName,DateTime Date,DateTime dateTime,bool Absence)
        {
            Person person = new Person();

            for (int i = 0; i < PersonList.Count; i++)
            {
                if (Id == PersonList[i].Id)
                {
                    MessageBox.Show("The product with this ID is available.");
                    return;
                }
            }

            person.Id = Id; 
            person.Name = Name;
            person.LastName = LastName;
            person.Date = Date;
            person.DateTime = dateTime;
            person.Absence = Absence;

            PersonList.Add(person);
            MessageBox.Show("Saved");
        }

        // Show List
        public List<Person> GetList()
        {
            return PersonList;
        }


    }
}
