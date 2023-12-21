using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBai7
{
    public class XuLyTen
    {
        public class A
        {
            public void HienThiTen(string ten)
            {
                Console.WriteLine("Hien thi ten: {0}", ten);
            }
            private void HienThiTuoi(int tuoi)
            {
                Console.WriteLine("Hien thi tuoi: {0}", tuoi);
            }
        }

        public class DemoClass : IDemoInterface
        {
            public void HienThiTen(string ten)
            {
                Console.WriteLine("Hien thi ten: {0}", ten);
            }

            public void HienThiTuoi(int tuoi)
            {
                Console.WriteLine("Hien thi tuoi: {0}", tuoi);
            }
        }
        public interface IDemoInterface
        {
            void HienThiTen(string ten);
            void HienThiTuoi(int tuoi);
        }

        public abstract class DemoAbstract
        {
            public abstract void HienThiTen(string ten);
            public abstract void HienThiTuoi(int tuoi);
        }

        public class XuLyHienThi1 : DemoAbstract
        {
            public override void HienThiTen(string ten) 
            {
                Console.WriteLine("Hien thi ten: {0}", ten);
            }

            public override void HienThiTuoi(int tuoi)
            {
                Console.WriteLine("Hien thi tuoi: {0}", tuoi);
            }
        }
        public class XuLyHienThi2 : DemoAbstract
        {
            public override void HienThiTen(string ten)
            {
                Console.Write("Ten la: {0}", ten);
            }

            public override void HienThiTuoi(int tuoi)
            {
                Console.Write("Tuoi la: {0}", tuoi);
            }
        }


        public string tenbentrong { get; set; } //bien noi bo.
        //public string BienA { get; set; }
        public string TenBenNgoai //bien trung gian
        {
            get { return tenbentrong; }
            set { tenbentrong = value; }
        }
    }

    public class XuLyGia : XuLyTen
    {
        public static int HeSoLuong { get; set; }
        public int GiaCa { get; set; }
        public XuLyGia() //ham khoi tao - contructor mac dinh
        { 
            //this.GiaCa = 5;
        }
        
        public XuLyGia(int gia)
        {
            this.GiaCa = gia;
        }
        public XuLyGia(int gia, int gia2 = 1)
        {
            this.GiaCa = gia + gia2;
        }
        public XuLyGia(XuLyGia gia) //copy class
        {
            this.GiaCa = gia.GiaCa;
        }
    }

    class XuLyNgayThang : XuLyGia
    {
        public string NgayThang { get; set; }
    }
    internal class Program : XuLyNgayThang
    {
        static void Main(string[] args)
        {
            XuLyGia gia = new XuLyGia();
            gia.tenbentrong = "a";
            Console.WriteLine("Ten: {0}", gia.tenbentrong);
            Console.WriteLine("Gia: {0}", gia.GiaCa);

            var dtgia = new XuLyGia(1,2);
            dtgia.GiaCa = 5;

            XuLyGia.HeSoLuong = 4;

            Console.ReadKey();


            //Program pg = new Program();
            //pg.TenBenNgoai = "laptop";
            //pg.GiaCa = 10000;
            //pg.NgayThang = DateTime.Now.ToString();
        }
    }
}
