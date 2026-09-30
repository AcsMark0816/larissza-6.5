
using System.Security.Cryptography.X509Certificates;

namespace larissza7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> smartphones = new List<Smartphone>()
{
    new Smartphone("Samsung", "Galaxy S24", 2024){ Rating = 9.1 },
    new Smartphone("Apple", "iPhone 15", 2023){ Rating = 9.3 },
    new Smartphone("Xiaomi", "Redmi Note 13", 2024){ Rating = 8.4 },
    new Smartphone("Google", "Pixel 8", 2023){ Rating = 9.0 },
    new Smartphone("Samsung", "Galaxy A55", 2024){ Rating = 8.6 },
    new Smartphone("OnePlus", "OnePlus 12", 2024){ Rating = 8.9 },
    new Smartphone("Apple", "iPhone 14", 2022){ Rating = 8.8 },
    new Smartphone("Xiaomi", "Xiaomi 14", 2024){ Rating = 9.2 }
};
            smartphones[0].SetPrice(329000);
            smartphones[1].SetPrice(399000);
            smartphones[2].SetPrice(199000);
            smartphones[3].SetPrice(299000);
            smartphones[4].SetPrice(249000);
            smartphones[5].SetPrice(349000);
            smartphones[6].SetPrice(299000);
            smartphones[7].SetPrice(399000);

            smartphones.Where(x => x.GetReleaseYear() == 2024).Select(x => x.Model).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine(smartphones.OrderByDescending(x => x.Rating).Select(x => x.Model).First());
            int C(string b)
            {
                return smartphones.Where(x => x.Brand == b).Count();
            }
            Console.WriteLine(C("Samsung"));

            List<Hotel> hotels = new List<Hotel>()
{
    new Hotel("Grand Palace", "Budapest", 5) {Rating = 9.4 },
    new Hotel("City Hotel", "Budapest", 3) {Rating = 5.5},
    new Hotel("Blue Sea Resort", "Split", 4) {Rating = 6.0},
    new Hotel("Royal Beach", "Barcelona", 5){ Rating = 7.0},
    new Hotel("Mountain View", "Salzburg", 4) {Rating = 8.0}



};

            hotels[0].SetPrice(6800);
            hotels[1].SetPrice(3200);
            hotels[2].SetPrice(54000);
            hotels[3].SetPrice(8200);
            hotels[4].SetPrice(4600);


            Console.WriteLine(hotels.OrderBy(x => x.SunP(1)).Select(x => x.Name).First());
            List<string> INCIty(string c)
            {
                return hotels.Where(x => x.Name == c).Select(x => x.Name).ToList();
            }
            INCIty("Budapest").ForEach(x => Console.WriteLine(x));

            List<Laptop> laptops = new List<Laptop>()
{
    new Laptop("Lenovo", "ThinkPad E14", "Intel i5"){Memory = 16},
    new Laptop("Apple", "MacBook Air M3", "Apple M3"){Memory = 16},
    new Laptop("Asus", "ROG Strix G16", "Intel i7"){Memory = 32},
    new Laptop("Acer", "Aspire 5", "AMD Ryzen 5"){Memory = 8},
    new Laptop("HP", "ProBook 450", "Intel i5"){Memory = 16},
    new Laptop("Dell", "Inspiron 15", "Intel i7"){Memory = 32},
    new Laptop("Lenovo", "IdeaPad Slim 3", "AMD Ryzen 5"){Memory = 8},
    new Laptop("Asus", "VivoBook 15", "Intel i5"){Memory = 16},
    new Laptop("Apple", "MacBook Pro M3", "Apple M3 Pro"){Memory = 36},
    new Laptop("Acer", "Nitro 5", "Intel i7"){Memory =32}




};
            laptops[0].LP(319000);
            laptops[1].LP(489000);
            laptops[2].LP(649000);
            laptops[3].LP(279000);
            laptops[4].LP(349000);
            laptops[5].LP(399000);
            laptops[6].LP(249000);

            double AP()
            {
                return laptops.Average(x => x.GP());
            }
            Console.WriteLine(AP());

            laptops.Where(x => x.GP() <= AP()).Select(x => x.GP());


            List <int> MAMiME(int min, int max)
            {
                    return laptops.Where(x => x.GP() >= min && x.GP() <= max).Select(x => x.GP()).ToList();
            }

            List<Restaurant> restaurants = new List<Restaurant>()
{
    new Restaurant("Bella Italia", "Budapest", "Italian"),
    new Restaurant("Burger House", "Budapest", "Burger"),
    new Restaurant("Sakura", "Budapest", "Japanese"),
    new Restaurant("Pasta Roma", "Rome", "Italian"),
    new Restaurant("Tokyo Garden", "Vienna", "Japanese"),
    new Restaurant("Steak Corner", "Budapest", "Steak"),
   

};
            restaurants[0].NAVG(9.1); 
            restaurants[1].NAVG(8.2);
            restaurants[2].NAVG(7.5);
            restaurants[3].NAVG(9.1);
            restaurants[4].NAVG(8.6);
            restaurants[5].NAVG(3.5);

            restaurants[0].PA(8500);
            restaurants[1].PA(5500);
            restaurants[2].PA(12000);
            restaurants[3].PA(13000);
            restaurants[4].PA(9500);
            restaurants[5].PA(13500);

           
            List<string> U(string n)
            {
                return restaurants.Where(x => x.category == n).Select(x => x.name).ToList();
            }

            Console.WriteLine(restaurants.Where(x => x.GTR() >= 9.0).Select(x => x.name).Count());
            restaurants.OrderByDescending(x => x.GTA()).Select(x => x.name).First();
            List<string> CS()
            {
               return  restaurants.Select(x => x.city).Distinct().ToList();
            }
            CS().ForEach(varos => Console.WriteLine(varos));

            List<Series> series = new List<Series>()
{
    new Series("Breaking Bad", "Drama", "AMC"),
    new Series("Stranger Things", "SciFi", "Netflix"),
    new Series("The Boys", "Action", "Amazon"),
    new Series("Dark", "SciFi", "Netflix"),
    new Series("The Crown", "Drama", "Netflix"),
            };

            series[0].EPS(62);
            series[1].EPS(34);
            series[2].EPS(32);
            series[3].EPS(26);
            series[4].EPS(60);
            series[0].R(9.5);
            series[1].R(8.7);
            series[2].R(8.7);
            series[3].R(8.8);
            series[4].R(8.6);



           List<string> STU(string s)
            {
                return series.Where(x => x.studio == s).Select(x => x.title).ToList();
            }
            series.OrderByDescending(x=> x.EPS())
        }

    }
}



  
