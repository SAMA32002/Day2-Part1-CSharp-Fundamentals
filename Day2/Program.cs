namespace Day2
{

    

    // ==========================================
    // ENUM DEFINITIONS
    // ==========================================

    enum Gender
    {
        Male = 0,
        Female = 1
    }

    enum Days
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday
    }

    enum OrderStatus
    {
        Pending = 10,
        Approved = 20,
        Rejected = 30
    }

    enum PaymentStatus
    {
        Pending,
        Paid,
        Failed
    }

    enum UserRole
    {
        Admin,
        Customer,
        Employee
    }

    enum Level : byte
    {
        Easy = 1,
        Medium = 2,
        Hard = 3
    }

    // ==========================================
    // CLASS DEFINITIONS
    // ==========================================

    class Person
    {
        public int Id;
        public string Name = "";
        public int Age;
        public Gender Gender;
        public AccountStatus Status;
    }

    enum AccountStatus
    {
        Active,
        Inactive,
        Suspended
    }

    // ==========================================
    // MAIN PROGRAM
    // ==========================================

    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== C# FUNDAMENTALS =====");

            // Uncomment the example you want to run.

            // ValueTypesExample();
            // ValueTypeMethodExample();
            // RefValueTypeExample();
            // NullableExample();

            // CreatingObjectExample();
            // CopyReferenceExample();
            // NewObjectAfterAssignmentExample();
            // MultipleReferencesExample();

            // ModifyObjectInMethodExample();
            // ReassignReferenceExample();
            // RefReferenceExample();

            // GarbageCollectorExample();

            // EnumExample();
            // EnumDefaultValuesExample();
            // EnumCustomValuesExample();
            // EnumIfExample();
            // EnumSwitchExample();
            // EnumByteExample();
            // EnumCastingExample();
            // EnumParsingExample();

            // FinalApplicationExample();

            Console.WriteLine("Program completed.");
        }

        // ==========================================
        // PART 1: VALUE TYPES
        // ==========================================

        // 1. Copying Value Types
        static void ValueTypesExample()
        {
            int x = 10;
            int y = x;

            y = 50;

            Console.WriteLine(x); // 10
            Console.WriteLine(y); // 50
        }

        // 2. Passing Value Type to Method
        static void ChangeNumber(int number)
        {
            number = 100;
        }

        static void ValueTypeMethodExample()
        {
            int x = 10;

            ChangeNumber(x);

            Console.WriteLine(x); // 10
        }

        // 3. Using ref with Value Type
        static void ChangeNumberUsingRef(ref int number)
        {
            number = 100;
        }

        static void RefValueTypeExample()
        {
            int x = 10;

            ChangeNumberUsingRef(ref x);

            Console.WriteLine(x); // 100
        }

        // 4. Nullable Value Types
        static void NullableExample()
        {
            int? age = null;

            Console.WriteLine(age.HasValue); // False

            age = 24;

            Console.WriteLine(age); // 24
        }

        // ==========================================
        // PART 2: REFERENCE TYPES
        // ==========================================

        // 5. Creating an Object
        static void CreatingObjectExample()
        {
            Person p = new Person();

            p.Name = "Sama";
            p.Age = 24;

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
        }

        // 6. Copying a Reference
        static void CopyReferenceExample()
        {
            Person p1 = new Person();

            p1.Name = "Ali";

            Person p2 = p1;

            p2.Name = "Mona";

            Console.WriteLine(p1.Name); // Mona
            Console.WriteLine(p2.Name); // Mona
        }

        // 7. Creating a New Object after Assignment
        static void NewObjectAfterAssignmentExample()
        {
            Person p1 = new Person();

            p1.Name = "Ali";

            Person p2 = p1;

            p2 = new Person();

            p2.Name = "Mona";

            Console.WriteLine(p1.Name); // Ali
            Console.WriteLine(p2.Name); // Mona
        }

        // 8. Multiple References to One Object
        static void MultipleReferencesExample()
        {
            Person p1 = new Person();

            p1.Name = "Ahmed";

            Person p2 = p1;
            Person p3 = p1;

            p3.Name = "Omar";

            Console.WriteLine(p1.Name); // Omar
            Console.WriteLine(p2.Name); // Omar
            Console.WriteLine(p3.Name); // Omar
        }

        // ==========================================
        // PART 3: PASSING REFERENCE TYPES TO METHODS
        // ==========================================

        // 9. Modifying Object Properties inside a Method
        static void ChangePersonId(Person obj)
        {
            obj.Id = 100;
        }

        static void ModifyObjectInMethodExample()
        {
            Person p = new Person();

            p.Id = 10;

            ChangePersonId(p);

            Console.WriteLine(p.Id); // 100
        }

        // 10. Reassigning Reference inside a Method
        static void ReassignPerson(Person obj)
        {
            obj = new Person();

            obj.Id = 100;
        }

        static void ReassignReferenceExample()
        {
            Person p = new Person();

            p.Id = 10;

            ReassignPerson(p);

            Console.WriteLine(p.Id); // 10
        }

        // 11. Reassigning Reference using ref
        static void ReassignPersonUsingRef(ref Person obj)
        {
            obj = new Person();

            obj.Id = 100;
        }

        static void RefReferenceExample()
        {
            Person p = new Person();

            p.Id = 10;

            ReassignPersonUsingRef(ref p);

            Console.WriteLine(p.Id); // 100
        }

        // ==========================================
        // PART 4: GARBAGE COLLECTOR
        // ==========================================

        // 12. Object without References
        static void GarbageCollectorExample()
        {
            Person p1 = new Person();

            p1.Name = "Ali";

            Person p2 = new Person();

            p2.Name = "Mona";

            // p2 now points to the same object as p1.
            p2 = p1;

            Console.WriteLine(p2.Name); // Ali

            // The original Mona object is now unreachable.
            // The Garbage Collector may collect it later.
        }

        // ==========================================
        // PART 5: ENUM
        // ==========================================

        // 13. Creating and Using an Enum
        static void EnumExample()
        {
            Gender personGender = Gender.Female;

            Console.WriteLine(personGender); // Female
        }

        // 14. Enum Default Values
        static void EnumDefaultValuesExample()
        {
            Days day = Days.Saturday;

            Console.WriteLine((int)day);       // 0
            Console.WriteLine((int)Days.Monday); // 2
        }

        // 15. Enum with Custom Values
        static void EnumCustomValuesExample()
        {
            OrderStatus status = OrderStatus.Approved;

            Console.WriteLine(status);        // Approved
            Console.WriteLine((int)status);   // 20
        }

        // 16. Enum with if / else
        static void EnumIfExample()
        {
            PaymentStatus status = PaymentStatus.Paid;

            if (status == PaymentStatus.Paid)
            {
                Console.WriteLine("Payment completed");
            }
            else if (status == PaymentStatus.Pending)
            {
                Console.WriteLine("Waiting for payment");
            }
            else
            {
                Console.WriteLine("Payment failed");
            }
        }

        // 17. Enum with switch
        static void EnumSwitchExample()
        {
            UserRole role = UserRole.Admin;

            switch (role)
            {
                case UserRole.Admin:
                    Console.WriteLine("Full access");
                    break;

                case UserRole.Customer:
                    Console.WriteLine("Customer access");
                    break;

                case UserRole.Employee:
                    Console.WriteLine("Employee access");
                    break;
            }
        }

        // 18. Enum with byte
        static void EnumByteExample()
        {
            Level level = Level.Hard;

            Console.WriteLine(level);       // Hard
            Console.WriteLine((byte)level); // 3
        }

        // 19. Casting between int and Enum
        static void EnumCastingExample()
        {
            int number = 1;

            Gender gender = (Gender)number;

            Console.WriteLine(gender); // Female

            int result = (int)gender;

            Console.WriteLine(result); // 1
        }

        // 20. Enum.TryParse and Validation
        static void EnumParsingExample()
        {
            Console.Write("Enter Gender: ");

            string input = Console.ReadLine() ?? "";

            if (Enum.TryParse<Gender>(
                input,
                true,
                out Gender result)
                && Enum.IsDefined(typeof(Gender), result))
            {
                Console.WriteLine($"Gender: {result}");
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
        }

        // ==========================================
        // PART 6: FINAL APPLICATION
        // ==========================================

        static void ChangeStatus(Person person)
        {
            person.Status = AccountStatus.Suspended;
        }

        static void ReplacePerson(Person person)
        {
            person = new Person();

            person.Name = "New Person";
        }

        static void ReplacePersonUsingRef(ref Person person)
        {
            person = new Person();

            person.Name = "New Person";
        }

        static void FinalApplicationExample()
        {
            Person p1 = new Person();

            p1.Id = 1;
            p1.Name = "Sama";
            p1.Gender = Gender.Female;
            p1.Status = AccountStatus.Active;

            Console.WriteLine("Original Data:");
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Gender);
            Console.WriteLine(p1.Status);

            Console.WriteLine("\nChanging Status:");

            ChangeStatus(p1);

            Console.WriteLine(p1.Status);

            Console.WriteLine("\nWithout ref:");

            ReplacePerson(p1);

            Console.WriteLine(p1.Name);

            Console.WriteLine("\nWith ref:");

            ReplacePersonUsingRef(ref p1);

            Console.WriteLine(p1.Name);
        }
    }

}
