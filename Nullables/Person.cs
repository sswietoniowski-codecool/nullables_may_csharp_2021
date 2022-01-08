#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Person
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        //public Nullable<int> Age { get; set; }
        public int? Age { get; set; }
        public Nullable<DateTime> BirthDateTime { get; set; }

        public Person()
        {
            Init();
        }

        [MemberNotNull(nameof(FirstName), nameof(LastName))]
        public void Init()
        {
            FirstName = "";
            LastName = "";
        }

        public Person(string firstName, string lastName)
        {
            //if (firstName == null)
            //{
            //    throw new ArgumentNullException(nameof(firstName));
            //}
            //FirstName = firstName;

            //FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));

            _ = firstName ?? throw new ArgumentNullException(nameof(firstName));
            FirstName = firstName;

            if (lastName is null) // C# 7.0, a != null => a is not null -> C# 8.0
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            LastName = lastName;
        }
    }
}
