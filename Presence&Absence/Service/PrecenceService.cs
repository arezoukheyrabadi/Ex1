using Presence_Absence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presence_Absence.Service
{
    internal class PrecenceService
    {
        public static List<Person> PersonList = new List<Person>();
        public static List<Person> PersonListSelect = new List<Person>();

        // Save List
        public void SaveList(int Id, string Name, string LastName, DateTime Arrival, DateTime Departure, bool Absence)
        {
            Person person = new Person();
            if (Absence == false)
            {
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
                person.Arrival = Arrival;
                person.Departure = Departure;
                person.Absence = Absence;

                PersonList.Add(person);
                MessageBox.Show("Saved");
            }
            else
            {
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
                person.Absence = Absence;

                PersonList.Add(person);
                MessageBox.Show("Saved");
            }


        }
        public void saveList(Person p)
        {
            PersonList.Add(p);
        }
        public void selectList(Person p)
        {
            PersonListSelect.Clear();
            PersonListSelect.Add(p);
            
        }

        // Show List
        public List<Person> GetList()
        {
            return PersonList;
        }
        public List<Person> getList()
        {
            return PersonListSelect;
        }

        public void EditList(int Id, DateTime newArrival, DateTime newDeparture, bool newAbsence)
        {
            for (int i = 0; i < PersonList.Count; i++)
            {
                if (PersonList[i].Id == Id)
                {
                    if (newAbsence == true)
                    {
                        PersonList[i].Arrival = Convert.ToDateTime(null);
                        PersonList[i].Departure = Convert.ToDateTime(null);
                        PersonList[i].Absence = newAbsence;
                    }
                    else
                    {
                        PersonList[i].Arrival = newArrival;
                        PersonList[i].Departure = newDeparture;
                        PersonList[i].Absence = newAbsence;
                    }

                }

            }
        }

        public void DeleteList(int Id)
        {
            for (int i = 0; i < PersonList.Count; i++)
            {
                if (PersonList[i].Id == Id)
                {
                    PersonList.Remove((PersonList[i]));
                }

            }
        }

        public Person Select(int Id)
        {
            //return PersonList.Where(x => x.Id == Id).FirstOrDefault();
             
            for (int i = 0; i < PersonList.Count; i++)
            {
                if (PersonList[i].Id == Id)
                {
                    return PersonList[i];

                }

            }

            return null;


        }


    }
}
