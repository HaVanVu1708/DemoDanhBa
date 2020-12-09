using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using DemoDanhBa.Models;
using Xamarin.Forms;
using DemoDanhBa.Views;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;


namespace DemoDanhBa.ViewModel
{

    public class AddContactListViewModel : INotifyPropertyChanged 
    {
        public ObservableCollection<Person> _person;

        public ObservableCollection<Person> Persons { 
            get{ return _person; }
                private set
            {
                if(_person != value)
                {
                    _person = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        //public string Name { get; set; }
        //public string Initials => new string(Name.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
        //            .Select(item => item.FirstOrDefault()).ToArray());
        public AddContactListViewModel()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person
            { 
                PersonId = 1,
                Name = "nguyễn hoàng nam",
                PersonPhone = "0972985339"
            }) ;
          
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddContact(Person person)
        {
            Persons.Add(person);

            //if (person.PersonId == 0)
            //{
            //    person.PersonId = Persons.Count + 1;
            //}

            
            //}
            //else
            //{
            //    Person personToEdit = Persons.Where(pre => pre.PersonId == person.PersonId).FirstOrDefault();

            //    int newIdex = Persons.IndexOf(personToEdit);
            //    Persons.Remove(personToEdit);

            //    Persons.Add(person);
            //    int oldIndex = Persons.IndexOf(person);

            //    Persons.Move(oldIndex, newIdex);
            //}
        }

        public void Removeperson(int preid, string prephone, string name)
        {
            //Person myperson = Persons[preid]; //If an object is removed, the OnPropertyChanged() method will be run from 'Items's setter
            //Persons.Remove(myperson);

            for(int i=0; i<Persons.Count; ++i)
            {
                if(Persons[i].PersonId == preid)
                {
                    Persons.RemoveAt(i);
                    //Persons.Remove(Persons[i]);
                    break;
                }
            }

            

        }
        
        

    }
}
