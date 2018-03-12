using System;

namespace OPP {
    class OPP {

        public abstract class Person {
            public int age;
           
            //    abstract class có thể khai báo biến 
            // và trong class abstract các phương thức có thể có phần thực thi; 
            public abstract void Read ();
            public abstract void Say ();
            public   void Run () {
                System.Console.WriteLine("nguoi chay");
             }
        }
        class Student : Person {
            //  class kế thừa abstract class thì phải có từ khóa override và bắt buộc thực thi tất cả các phương thúc của lớp cha
             
            public override void Read () {
                System.Console.WriteLine ("student read .. ");
            }
            // public override void Run(){
            //     System.Console.WriteLine("studen run");
            // }
            public override void Say () {
                System.Console.WriteLine ("say ...");
            }

        }
        public static void Main (string[] a) {
             Student student1 = new Student();
             student1.Run();
        }
    }
}

// using System;

// namespace OPP
// {
//     class OPP
//     {
//         interface Irun
//         {
//             //một interface thì không thể khai báo biến;
//             void run();
//         }
//         interface Ispeak
//         {
//             void Speak();
//         }
//         class Person:Irun,Ispeak
//         {
//             public void run()
//             {
//                 System.Console.WriteLine("person run ...");
//             }
//             public void Speak(){
//                 System.Console.WriteLine("person speak ... ");
//             }
//         }
//         public static void Main()
//         {
//             Person person1 = new Person();
//             person1.Speak();
//         }
//     }
// }