using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.IO;
namespace baiToanXuatTapHop
{
    // n = 3
    //000
    //001
    //010
    //011
    //100
    //101
    //110
    //111
    // - Cau hinh dau tien
    // - Cau hinh cuoi cùng
    // - Phuong phap sinh
    // Vi du: n = 5 10111
    //              11000
    //              11001
    //              11010
    // Thuât toán sinh n bit
    // Neu gap bit 1 chuyên thanh 0 va dich sang trai
    // Neu gap bit 0 chuyen thanh 1 và copy phan con lai

    // Cong 2 so nhi phan 0 + 0 = 0; 0 + 1 = 1 + 0 = 1; 1 + 1 = 0, nhớ 1
    // Ví du: 
    // 0001110 // 14
    //  +    1
    //--------
    // 0001111 //15
    class Program
    {
        static int n, final;
        static string FileName = "E:\\test.txt";
        static int[] a = new int[100];
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vào gia tri cho n < 20.");
            n = int.Parse(Console.ReadLine());
            final = 1;
            khoitao();
            XuatTatcaTapCon();
            Console.ReadLine();
        }
        static void XuatTatcaTapCon()
        {
            File.Delete(FileName);// Xoa nội dung trên file cũ
            while (final == 1)
            {
                // Khởi tạo một tập hợp
                set C = new set(ToanCuc.nrobjs);
                // Khởi tạo chuỗi kết quả k
                int k = 0;
                for (int i = 1; i < n; i++)
                {
                    if (a[i] != 0)
                    {
                        C.o.Insert(k, i);
                        k++;
                    }
                }
                if (a[n] != 0)
                {
                    C.o.Insert(k, n);
                    k++;
                }
                C.nmember = k;
                C.display();
                // Chèn tập hợp vào File thông qua hàm Ctostring()
                File.AppendAllText(FileName, C.Ctostring() + "\r\n");
                Console.WriteLine();
                // Sinh mảng nhị phân tiếp theo
                Sinh();
            }
        }
        static void khoitao()
        {
            for (int i = 1; i <= n; i++)
                a[i] = 0;

        }

        static void Sinh()
        {
            int i = n;

            while (i >= 1 && a[i] == 1) // Duyệt các phần tử từ n tới 1. Neu gap bit 1 chuyên thanh 0 va dich sang trai. Neu gap bit 0 chuyen thanh 1 và copy phan con lai
            {
                a[i] = 0;
                --i;

            }
            if (i == 0) final = 0; // Cau hinh cuoi cung --> Xuất 111
            else
            {
                a[i] = 1;

            }
        }
    }
}
