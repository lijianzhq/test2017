using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.collectionTest
{
    class SetItem
    {
        public String Name;

        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode();
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    var u = obj as SetItem;
        //    if (u == null) return false;
        //    return u.Name == this.Name;
        //}
    }

    class TestHashSet
    {
        public static void Test()
        {
            Add();
            //Add2();
        }

        static void Add()
        {
            var set = new HashSet<String>();
            set.Add("lijian");
            set.Add("lijian");
            set.Add("zhq");
            Console.WriteLine(set.Count);
        }

        static void Add2()
        {
            var set = new HashSet<SetItem>();
            set.Add(new SetItem() { Name = "lijian" });
            set.Add(new SetItem() { Name = "lijian" });
            set.Add(new SetItem() { Name = "zhq" });
            Console.WriteLine(set.Count);
        }
    }
}
