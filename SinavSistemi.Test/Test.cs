using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SinavSistemi.BusinessLogicLayer;
using SinavSistemi.Entity;

namespace SinavSistemi.Test
{
    public class Test
    {
        [Test]

        public void GirisTesti()
        {
            OgrenciBLL ogrenci = new OgrenciBLL();
            Assert.AreEqual(2, ogrenci.GirisKontrolu("cihancifci", "13579"));
        }

        [Test]

        public void SoruGetirmeTesti()
        {
            SoruBLL soru = new SoruBLL();
            List<SoruEntity> sorular = soru.SorularıGetir(2);
            Assert.IsNotNull(sorular);
        }

        [Test]

        public void SoruEklemeTesti()
        {
            SoruBLL soruBll = new SoruBLL();
            SoruEntity soru = new SoruEntity();
            soru.soruA = "1245";
            soru.soruB = "1246";
            soru.soruC = "1247";
            soru.soruD = "1248";
            soru.soruDogruCevap = "C";
            soru.soruIcerik = "işelminin sonucu kaçtır ?";
            soru.soruOnBilgi = "893 + 354";
            soru.soruKonuID = 1;
            soruBll.SoruEkle(soru);
            Assert.Pass();
        }


    }
}
