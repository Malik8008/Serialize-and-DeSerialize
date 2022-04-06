using FileStream_Serialize_DeSerialize_Practic.Model;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FileStream_Serialize_DeSerialize_Practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StreamFile
            //string filepath = Path.Combine(@"C:\Users\Admin\OneDrive\Desktop\AP_204Directory", "Waftali.txt");
            ////Console.WriteLine(filepath);
            ////string path = @"C:\Users\Admin\OneDrive\Desktop\AP_204Directory";
            //string folderpath1 = Path.Combine(@"C:\Users\Admin\OneDrive\Desktop\AP_204Directory","Ali935");

            //string PathFile= Path.Combine(@"C:\Users\Admin\OneDrive\Desktop\AP_204Directory", "Ali935","015.txt");
            //string PathFile1= Path.Combine(@"C:\Users\Admin\OneDrive\Desktop\AP_204Directory", "Ali935","Stolba.txt");
            //string PathFile2= Path.Combine(@"C:\Users\Admin\OneDrive\Desktop\AP_204Directory", "Ali935","Metallom.txt");
            //string PathFile3= Path.Combine(@"C:\Users\Admin\OneDrive\Desktop\AP_204Directory", "Malik666","072.txt");

            //StreamWriter streamWriter = new StreamWriter(PathFile,true);
            //streamWriter.WriteLine("Hello Aliwka");
            //streamWriter.WriteLine("AzTU ya xow geldin");
            //streamWriter.WriteLine("Veziyyet necedi");
            //streamWriter.WriteLine("Bye Aliwka");

            //streamWriter.Close();

            //StreamReader streamReader = new StreamReader(PathFile);
            //Console.WriteLine(streamReader.ReadToEnd());

            //streamReader.Close();

            //using (StreamReader streamReader = new StreamReader(PathFile))
            //{
            //    Console.WriteLine(streamReader.ReadToEnd());

            //}


            //Directory.CreateDirectory(folderpath1);
            //File.Create(PathFile1);
            //File.Create(PathFile2);
            //File.Create(PathFile3);
            //File.Create(filepath);
            //Directory.Delete(path,true);


            //if (File.Exists(filepath))
            //{
            //    File.Delete(filepath);  
            //}
            //else
            //{
            //    Console.WriteLine("Bele fayl yoxdu");
            //}


            //FileStream fileStream = new FileStream("path_example",FileMode.Create,FileAccess.Write,FileShare.Read);

            //string text = "ADAM KIWI OLAR A BALA";
            //byte[] byteArr= Encoding.UTF8.GetBytes(text);
            //foreach (var item in byteArr)
            //{
            //    Console.WriteLine(item);
            //}
            //fileStream.Write(byteArr, 0, byteArr.Length);
            #endregion


            Computer computer = new Computer {ID=1,Brand="ASUS",RAM="8GB",GraphicCard="RTX3050",Price=2200};
            Computer computer1 = new Computer {ID=2,Brand="MSI",RAM="16GB",GraphicCard="RTX1650",Price=1899.99};
            Computer computer2 = new Computer {ID=3,Brand="Lenova",RAM="32GB",GraphicCard="Ryzen 7",Price=3500};
            Computer computer3 = new Computer {ID=4,Brand="MacBook",RAM="16",GraphicCard="MAC AIR7",Price=6500};

            OrderItem orderItem = new OrderItem {ID=1,Computer=computer,Price=computer.Price };
            OrderItem orderItem1 = new OrderItem {ID=2,Computer=computer1,Price=computer1.Price };
            OrderItem orderItem2 = new OrderItem {ID=3,Computer=computer2,Price=computer2.Price };
            OrderItem orderItem3 = new OrderItem {ID=4,Computer=computer3,Price=computer3.Price };


            Order order = new Order
            {
                ID = 1,
                OrderItems = new List<OrderItem> { orderItem, orderItem1, orderItem2, orderItem3 },

                TotalPrice = 16200.99
            };
            
            var OrderAll= JsonConvert.SerializeObject(order);
            Console.WriteLine(OrderAll);

        }
    }
}
