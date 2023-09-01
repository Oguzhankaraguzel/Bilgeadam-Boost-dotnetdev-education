using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonYonetim.Sınıflar
{
    internal static class TelefonListesi
    {
        public static List<Telefon> Telefonlar = new List<Telefon>();

        #region Metodlar
        /// <summary>
        /// Grekli özellikler girildikten sonra elefon bilgisi telefonlar listesine eklenir
        /// </summary>
        /// <param name="marka">Telefonun markası</param>
        /// <param name="model">Telefonun modeli</param>
        /// <param name="durum">Telefonun durumu</param>
        /// <param name="yil">Telefonun durumu</param>
        public static void AddList(string marka, string model, string durum, int yil, string dosyayolu)
        {
            Telefon telefon = new Telefon
            {
                Marka = marka,
                Model = model,
                Durumu = durum,
                Yil = yil,
                SesDosyasıYolu = dosyayolu,
            };
            Telefonlar.Add(telefon);
        }

        /// <summary>
        /// Listeden seçili indexteki telefonu siler.
        /// </summary>
        /// <param name="index">Listenin indexi</param>
        /// <exception cref="ArgumentOutOfRangeException">index 0 ile listenin eleman sayısı arasında olmalı</exception>
        public static void RemoveList(int index)
        {
            if ((index < 0) && (index >= Telefonlar.Count))
            {
                throw new ArgumentOutOfRangeException("İndex değeri listenin sınırları dışında olamaz");
            }
            else
            {
                Telefonlar.RemoveAt(index);
            }
        }

        /// <summary>
        /// Listedeki index'e sahip telefonu günceller
        /// </summary>
        /// <param name="index">Listenin ulaşımasının istendiği index</param>
        /// <param name="marka">Telefon markası</param>
        /// <param name="model">Telefon modeli</param>
        /// <param name="durum">Telefon durumu</param>
        /// <param name="yil">Telefon üretim yılı</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void UpdateList(int index, string marka, string model, string durum, int yil, string dosyaYolu)
        {
            if ((index < 0) && (index >= Telefonlar.Count))
            {
                throw new ArgumentOutOfRangeException("İndex değeri listenin sınırları dışında olamaz");
            }
            else
            {
                Telefonlar[index].Marka = marka;
                Telefonlar[index].Model = model;
                Telefonlar[index].Durumu = durum;
                Telefonlar[index].Yil = yil;
                Telefonlar[index].SesDosyasıYolu = dosyaYolu;
            }
        } 
        #endregion
    }
}
