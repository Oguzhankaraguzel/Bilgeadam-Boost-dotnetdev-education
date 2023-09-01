using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CemberSinifi
{
    
    internal class Cember
    {
        private double _merkezX;
        private double _merkezY;
        private double _yariCap;

        public Cember(double x, double y, double r)
        {
            _merkezX = x;
            _merkezY = y;
            if (r < 0)
            {
                throw new ArgumentOutOfRangeException("Sadece pozitif değerlere izin veriliyor");
            }
            else
            {
                _yariCap = r;
            }
            
        }

        public void Yaz()
        {
            Console.WriteLine($"Merkezin Koordinatları : x = {_merkezX}, y ={_merkezY}, ({_merkezX},{_merkezY}). Yarıçap : r = {_yariCap}");
        }

        public void SetMerkezXY(double x, double y) 
        {
            _merkezX = x;
            _merkezY = y;
        }

        public void SetYariCap(double r) 
        {
            if (r < 0)
            {
                throw new ArgumentOutOfRangeException("Sadece pozitif değerlere izin veriliyor");
            }
            else
            {
                _yariCap = r;
            }
        }

        public double GetAlan() 
        {
            return Math.Pow(_yariCap, 2)*Math.PI;
        }

        public double GetCevre()
        {
            return (_yariCap * 2 * Math.PI);
        }
        /// <summary>
        /// İki çemberi karşılaştırır
        /// </summary>
        /// <param name="other">Karşılaştırmak istediğiniz çember</param>
        /// <returns>Alanı daha büyük olan çemberi döndürür</returns>
        public Cember BuyukOlan(Cember other)
        {
            return GetAlan() > other.GetAlan() ? this : other;
        }

        /// <summary>
        /// İki çemberin birbirine en yakın olan noktaları arasındaki mesafeyi hesaplar.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Hesaplanan mesafeyi double olarak geri döndürür.Eğer çemberler teğetse 0 değeri döndürülür. Eğer çemberler kesişiyorsa negatif değer geri döner.</returns>
        public double Mesafe(Cember other) 
        {
            return Math.Sqrt(Math.Pow((_merkezX - other._merkezX), 2) + Math.Pow((_merkezY - other._merkezY), 2)) - (_yariCap + other._yariCap);
        }

        public bool İcindeMi(Cember other) 
        {
            if (other._yariCap >= (Math.Sqrt(Math.Pow((_merkezX - other._merkezX), 2) + Math.Pow((_merkezY - other._merkezY), 2)) + _yariCap) && (BuyukOlan(other) == this ? false : true))
            { 
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TegetYap(char eksen) 
        {
            if (eksen == 'x' || eksen == 'X')
            {
                _merkezY = _yariCap;
            }
            else if (eksen == 'y' || eksen == 'Y')
            {
                _merkezX = _yariCap;
            }
            else
            {
                throw new ArgumentException("Sadece 'x' ve 'y' eksenlerine izin veriliyor");
            }
        }

    }
}
