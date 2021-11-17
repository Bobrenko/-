using System.Windows;
using WpfApplDemo2018.Model;

namespace WpfApp1.Helper
{
    public class FindPerson
    {
        int id;
        public FindPerson(int id)
        {
            this.id = id;
        }
        public bool PersonPredicate(Person per)
        {
            return per.Id == id;
        }
    }
}
