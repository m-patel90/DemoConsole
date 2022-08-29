using System;
using ConsoleApp1.Collections;
using ConsoleApp1.DecorativePattern;
using ConsoleApp1.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static SamplesViewModel vmobj;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            //Decorative pattern
            //CarAbstract car = new SmallCar();
            //Console.WriteLine($"Price of car {car.GetCarName()}:" + car.CarPrice());

            //var car1 = new AdvanceMusic(car);
            //Console.WriteLine($"Price of car {car1.GetCarName()} : " + car1.CarPrice());
            //Console.WriteLine($"Name of car {car1.GetCarName()} : " + car1.CarPrice());

            //var car2 = new SunRoof(car);

            //Console.WriteLine($"Price of car {car2.GetCarName()} : " + car2.CarPrice());

            // Encalpsulation
            ClassB objB = new ClassB();
            //ClassA objA = objB;
            //objA.getname();
            objB.getname(1);

            //ClassC objc = new ClassC();
            //objc.GetEmployeeName();
            //ClassB objb = new ClassB();
            //objb.getxyz();
            //objb.name = "Maulik";

            //Audting
            //IServiceCollection services = new ServiceCollection();
            //services.AddTransient(CreateAuditingClient);
            //var logger = serviceProvider.GetService<ILogger>();
            //var messageBusControlProcessor = serviceProvider.GetService<IMessageBusControlProcessor>();
            //var messageBusControl = messageBusControlProcessor.GetMessageBusControl();
            //AuditingClient auditingClient = new AuditingClient();
            //auditingClient.SendAsync()



            //AuditClient auditClient = new AuditClient();
            //auditClient.AuditingClient();

            //SingleTon class
            //Singleton singObj = Singleton.getSingleTon();
            //singObj.GetAPIcall();
            //Console.WriteLine(name);

            //Abstract metho implementation
            //ClassA objA = new ClassA("Hi");
            //objA.NonAbstractMethod();

            //LSP
            //var objCust = new GoldCustomer();
            //int discount = objCust.Discount(100);

            //var objCust1 = new SilverCustomer();
            //int discount1 = objCust1.Discount(100);

            //var objInquiry = new InQuiryCustomer();
            //int discount11 = objInquiry.Discount(100);

            //Extention Method
            //oldClass extention = new oldClass();
            //extention.C();

            //Collection
            //CollectionClass collectionObj = new CollectionClass();
            //collectionObj.checkCollection();

            //Interface

            //Interface1 obj1 = new xyz();
            //obj1.print();
            //Interface2 obj2 = new xyz();
            //obj2.print();
            //TryCatch objTry = new TryCatch();
            //objTry.print();



            //SamplesViewModel vmobj = new SamplesViewModel();
            //vmobj.FirstOrDefault();

            //foreach(var item in vmobj.products)
            //{
            //    Console.WriteLine(item.Name.ToString() + " "+ item.Color + " "+ item.ListPrice );
            //}

            //Console.WriteLine(vmobj.ResultText);
        }
    }
}
