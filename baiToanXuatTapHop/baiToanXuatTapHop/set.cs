using baiToanXuatTapHop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baiToanXuatTapHop
{
    public class set
    {
        //ArrayList tam = new ArrayList();
        /// <summary>
        /// Số phần tử của tập hợp
        /// </summary>
        public int nmember = 0;
        /// <summary>
        /// Mảng các phần tử của tập hợp
        /// </summary>
        /// 
        public List<int> o = new List<int>();
        //= new List<int>();
        //int[ToanCuc.nobjs];
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public set()
        {
            this.nmember = 0;
            o = new List<int>();
            //int[ToanCuc.nobjs];
            //this.o = null;
        }
        /// <summary>
        /// Hàm khởi tạo tập hợp có n là tham số
        /// </summary>
        /// <param name="n"></param>
        public set(int n)
        {
            this.nmember = n;
            this.o = new List<int>(this.nmember);
            //for (int i = 0; i < n; i++)
            //    this.o[i] = 0;

        }
        public set(int n, List<byte> a)
        {
            this.nmember = n;
            //this.o = new List<int>(this.nmember);
            for (int i = 0; i < n; i++)
                this.o.Add(a[i]);

        }
        public void sort()
        {
            this.o.Sort();
        }
        /// <summary>
        /// Hàm hủy một tập hợp
        /// </summary>
        ~set()
        {
            this.nmember = 0;
            this.o = null;
        }
        /// <summary>
        /// Hàm khởi tạo một tập hợp
        /// </summary>
        /// <param name="s"></param>
        public set(set s)
        {
            this.nmember = s.nmember;
            this.o = new List<int>(nmember);
            for (int i = 0; i < s.nmember; i++)
                this.o.Add(s.o[i]);
        }
        /// <summary>
        /// Hàm quá tải toán tử gán của hai tập hợp
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //public static set operator + (set s)
        //{
        //    this.

        //}
        /// <summary>
        /// Hàm giao của 2 tập hợp có kích thước
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        /// <summary>
        /// Hàm xuất các phần tử của tập hợp
        /// </summary>
        public void display()
        {
            if (nmember > 0)
            {
                Console.Write("{");
                for (int i = 0; i < nmember - 1; i++)
                    Console.Write("{0},", o[i]);
                Console.Write("{0}", o[nmember - 1]);
                Console.Write("}");
            }
            else
                Console.WriteLine("{}");

        }
        public string Ctostring()
        {
            string str = "";
            if (nmember > 0)
            {
                str = str + "{";
                for (int i = 0; i < nmember - 1; i++)
                    str = str + o[i].ToString() + ",";
                str = str + o[nmember - 1];
                str = str + "}";
            }
            else
                str = str + "{}";
            return str;
        }
        ///
        /// 
        /// <summary>
        /// Hàm hiển thị bằng tên 
        /// </summary>
        public void display_name()
        {
            if (nmember > 0)
            {
                Console.Write("{");
                for (int i = 0; i < nmember - 1; i++)
                    Console.Write("{0},", ToanCuc.animals[o[i]]);
                Console.Write("{0}", ToanCuc.animals[o[nmember - 1]]);
                Console.Write("}");
            }
            else
                Console.WriteLine("{}");
        }



    }
}
