using System;
using System.Collections;
using System.Data;

namespace Basics
{
    public class _8th
    {
       public void FirstSecond()
        {
            // 1. Creating a DataTable object
            DataTable dataTable1 = new DataTable();

            // 2. Creating a DataTable object with a name using constructor
            DataTable dataTable2 = new DataTable("MyDataTable");

            Console.WriteLine("DataTable 1 Name: " + dataTable1.TableName);
            Console.WriteLine("DataTable 2 Name: " + dataTable2.TableName);
        }

        /* 
         * 
             DataTable.Rows
             DataTable.Columns
             DataTable.TableName
             DataTable.DataSet
             DataTable.CaseSensitive
             DataTable.MinimumCapacity
             DataTable.Namespace
             DataTable.Prefix
             DataTable.ParentRelations
             DataTable.ChildRelations
        */

        /*
         *
            DataRow newRow = dataTable.NewRow();
            dataTable.Load(dataReader);
            dataTable.ImportRow(existingRow);
            dataTable.Clear();
            DataTable clonedTable = dataTable.Clone();
            dataTable.AcceptChanges();
            dataTable.RejectChanges();
            DataRow[] selectedRows = dataTable.Select("ColumnName = 'Value'");
            object result = dataTable.Compute("SUM(ColumnName)", "FilterExpression");
            dataTable.WriteXml("data.xml");
        */

        public void FourthToEigth()
        {
            // Creating a new DataTable
            DataTable dataTable = new DataTable();

            // Adding columns to the DataTable using Columns.Add() method
            dataTable.Columns.Add("EmpId", typeof(int));
            dataTable.Columns.Add("EmpName", typeof(string));
            dataTable.Columns.Add("EmpSalary", typeof(double));
            dataTable.Columns.Add("Department", typeof(string));

            // Adding 5 records using Rows.Add() method
            dataTable.Rows.Add(1, "John Doe", 50000.0, "IT");
            dataTable.Rows.Add(2, "Alice Smith", 55000.0, "HR");
            dataTable.Rows.Add(3, "Bob Johnson", 48000.0, "Finance");
            dataTable.Rows.Add(4, "Eva Brown", 51000.0, "Marketing");
            dataTable.Rows.Add(5, "Michael Clark", 60000.0, "Sales");

            // Printing the EmpId column using for loop
            Console.WriteLine("EmpId Column:");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Console.WriteLine(dataTable.Rows[i]["EmpId"]);
            }

            // Printing the EmpId column using foreach loop
            Console.WriteLine("EmpId Column:");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["EmpId"]); // here datarow property used. So for questions 8 and 9 suffice
            }

        }

        public void Tenth()
        {
            // Creating a new DataTable with 5 columns
            DataTable productTable = new DataTable();
            productTable.Columns.Add("ProductID", typeof(int));
            productTable.Columns.Add("ProductName", typeof(string));
            productTable.Columns.Add("Price", typeof(double));
            productTable.Columns.Add("Category", typeof(string));
            productTable.Columns.Add("Stock", typeof(int));

            // Adding 4 records to the productTable
            productTable.Rows.Add(1, "Laptop", 800.0, "Electronics", 20);
            productTable.Rows.Add(2, "Book", 15.0, "Stationery", 50);
            productTable.Rows.Add(3, "Headphones", 50.0, "Electronics", 30);
            productTable.Rows.Add(4, "Backpack", 40.0, "Fashion", 25);
        }

        public void EleventhToThirteen()
        {
            // Create a DataSet object
            DataSet dataSet = new DataSet();

            DataSet myDataSet = new DataSet("MyDataSet");
            // Creating the first DataTable
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("EmpId", typeof(int));
            dataTable1.Columns.Add("EmpName", typeof(string));
            dataTable1.Columns.Add("EmpSalary", typeof(double));
            dataTable1.Columns.Add("Department", typeof(string));
            dataTable1.Rows.Add(1, "John Doe", 50000.0, "IT");
            dataTable1.Rows.Add(2, "Alice Smith", 55000.0, "HR");

            // Creating the second DataTable
            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("ProductID", typeof(int));
            dataTable2.Columns.Add("ProductName", typeof(string));
            dataTable2.Columns.Add("Price", typeof(double));
            dataTable2.Columns.Add("Category", typeof(string));
            dataTable2.Columns.Add("Stock", typeof(int));
            dataTable2.Rows.Add(1, "Laptop", 800.0, "Electronics", 20);
            dataTable2.Rows.Add(2, "Book", 15.0, "Stationery", 50);

            // Add DataTables to the DataSet using Tables.Add() method
            myDataSet.Tables.Add(dataTable1);
            myDataSet.Tables.Add(dataTable2);
        }

        /*
            Properties:

                Capacity: Gets or sets the number of elements that the ArrayList can contain.
                Count: Gets the number of elements actually contained in the ArrayList.
                IsReadOnly: Gets a value indicating whether the ArrayList is read-only.

            Methods:

                Add(object value): Adds an object to the end of the ArrayList.
                Remove(object obj): Removes the first occurrence of a specific object from the ArrayList.
                Clear(): Removes all elements from the ArrayList.
        */

        /*
            Array:

                Fixed Size: Arrays have a fixed size, which means you need to specify the size of the array when you create it.
                        Once the size is defined, it cannot be changed.
                Type-Specific: Arrays in C# are type-specific. If you create an array of integers,
                        you can only store integers in that array.
                Performance: Arrays offer better performance in terms of accessing elements because they are contiguous blocks of memory.
                        Accessing elements in an array is faster compared to other collection types.
                Static: Arrays are static data structures. Once created, their size cannot be changed,
                        and you need to create a new array if you want to resize it.
           ArrayList:

                Dynamic Size: ArrayLists are dynamic in size, which means they can grow or shrink in size dynamically. You don't need
                        to specify their size at the time of creation.
                Type Agnostic: ArrayLists can store elements of different data types. You can store integers, strings, objects, or
                        any other data type within the same ArrayList.
                Performance: ArrayLists offer slower performance for certain operations compared to arrays because they involve
                        boxing and unboxing operations for value types, leading to overhead.
                Dynamic: ArrayLists are dynamic data structures. They can grow or shrink in size dynamically without
                        the need for specifying the size during creation.
        */

        public void SeventeenthToTwentyFirst()
        {
            // Creating an ArrayList
            ArrayList arrayList = new ArrayList();

            // Adding string elements to the ArrayList using Add() method
            arrayList.Add("One");
            arrayList.Add("Two");
            arrayList.Add("Three");

            // Printing ArrayList elements using for loop
            Console.WriteLine("ArrayList Elements (Using for loop):");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            // Clearing all elements in the ArrayList using Clear() method
            arrayList.Clear();

            // Reversing the elements in the ArrayList using Reverse() method
            arrayList.Reverse();

            // Sorting the elements in the ArrayList using Sort() method
            arrayList.Sort();

        }
    }
}
