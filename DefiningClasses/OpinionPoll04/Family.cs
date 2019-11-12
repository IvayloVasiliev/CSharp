using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
      private List<Person> member;

        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members 
        {
            get => member;
            set { member = value; }
        }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public List<Person> GetOldestMember()
        {
            var oldestMembers = Members
                .OrderBy(x => x.Name)
                .Where(years => years.Age >=30)
                .ToList();
            return oldestMembers;
        }
    }
}
