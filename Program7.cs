static void Main(string[] args)
        {            
            int a, b, c,d, max, min;
            Console.Write("\n Nhap vao so thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so thu ba: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so thu tu: ");
            d = Convert.ToInt32(Console.ReadLine());
            max = ((a > b && a > c && a > d) ? a : (b > c && b > d) ? b : (c > d) ? c : d);
            min = ((a < b && a < c && a < d) ? a : (b < c && b < d) ? b : (c < d) ? c : d);
            Console.WriteLine("\nSo lon nhat trong 4 so: " +
                                a + ", " + b + ", " +
                                    c + " va " + d +
                                         " la " + max);
            Console.WriteLine("\nSo nho nhat trong 4 so: " +
                                a + ", " + b + ", " +
                                    c + " va " + d +
                                         " la " + min);
            Console.Read();
        }
