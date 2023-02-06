namespace DataAccessLayer.Migrations
{
    using Enitities.Concrete;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Context.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.Context.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdateOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            ////Deniz Ürünleri
            





            FoodInfo susi = new FoodInfo() { FoodName = "Suşi", Kalori = 125f, Karbonhidrat = 12.42f, Protein = 3.04f, Yag = 7.15f};
            context.FoodInfos.AddOrUpdate(susi);



            //Beyaz Etler
            FoodInfo KizarmisKanat = new FoodInfo() { FoodName = "Kızarmış Tavuk Kanadı", Kalori = 69f, Karbonhidrat = 0.50f, Protein = 5.85f, Yag = 4.92f, Gram = 100};
            context.FoodInfos.AddOrUpdate(KizarmisKanat);



            FoodInfo KizarmisBut = new FoodInfo()
            {
                FoodName = "Kızarmış Tavuk But",
                Kalori = 300f,
                Karbonhidrat = 0.76f,
                Protein = 13.8f,
                Yag = 26.65f,
                Gram = 100,
                
            };



            context.FoodInfos.AddOrUpdate(KizarmisBut);



            FoodInfo HaslanmisBut = new FoodInfo() { FoodName = "Haşlanmış Tavuk But", Kalori = 117f, Karbonhidrat = 4.38f, Protein = 7.96f, Gram = 100, Yag = 7.17f };
            context.FoodInfos.AddOrUpdate(HaslanmisBut);



            FoodInfo TavukKoftesi = new FoodInfo() { FoodName = "Tavuk Köftesi", Kalori = 46f, Karbonhidrat = 2.25f, Protein = 4.13f, Gram = 100, Yag = 2.25f};
            context.FoodInfos.AddOrUpdate(TavukKoftesi);



            FoodInfo TavukCigeri = new FoodInfo() { FoodName = "Tavuk Ciğeri", Kalori = 1.72f, Karbonhidrat = 0.01f, Protein = 026f, Yag = 0.06f};
            context.FoodInfos.AddOrUpdate(TavukCigeri);



            FoodInfo TavukluPilav = new FoodInfo() { FoodName = "Tavuklu Pilav", Kalori = 336f, Karbonhidrat = 46.77f, Protein = 15.90f, Yag = 9.03f, Gram = 100};
            context.FoodInfos.AddOrUpdate(TavukluPilav);



            FoodInfo TavukNugget = new FoodInfo() { FoodName = "Tavuk Nugget", Kalori = 121f, Karbonhidrat = 2.7f, Protein = 7.2f, Yag = 9f, Gram = 100};
            context.FoodInfos.AddOrUpdate(TavukNugget);



            FoodInfo EkmekAraTavukDoner = new FoodInfo() { FoodName = "Ekmek Arası Tavuk Döner", Kalori = 309f, Karbonhidrat = 15.13f, Protein = 43.10f, Yag = 36.37f};
            context.FoodInfos.AddOrUpdate(EkmekAraTavukDoner);



            FoodInfo KoriSosluTavuk = new FoodInfo() { FoodName = "Ekmek Arası Tavuk Döner", Kalori = 243f, Karbonhidrat = 8.92f, Protein = 31.95f, Yag = 7.9f, Gram = 100};
            context.FoodInfos.AddOrUpdate(KoriSosluTavuk);



            FoodInfo TavukSote = new FoodInfo() { FoodName = "Tavuk Sote", Kalori = 309f, Karbonhidrat = 15.13f, Protein = 43.10f, Yag = 36.37f, Gram = 100};
            context.FoodInfos.AddOrUpdate(TavukSote);

            // SÜTLÜ TATLILAR



            FoodInfo Sutlac = new FoodInfo() { FoodName = "Sütlaç", Kalori = 133f, Karbonhidrat = 21.9f, Protein = 4f, Yag = 3f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Sutlac);



            FoodInfo Kazandibi = new FoodInfo() { FoodName = "Kazandibi", Kalori = 294f, Karbonhidrat = 47.9f, Protein = 5.7f, Yag = 8f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Kazandibi);



            FoodInfo Magnolia = new FoodInfo() { FoodName = "Magnolia", Kalori = 300f, Karbonhidrat = 50f, Protein = 3.5f, Yag = 7.2f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Magnolia);



            FoodInfo Tiramisu = new FoodInfo() { FoodName = "Tiramisu", Kalori = 380f, Karbonhidrat = 56.80f, Protein = 9.25f, Yag = 11.2f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Tiramisu);



            FoodInfo Cheesecake = new FoodInfo() { FoodName = "Cheesecake", Kalori = 510f, Karbonhidrat = 62f, Protein = 9.75f, Yag = 23.47f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Cheesecake);



            FoodInfo Gullac = new FoodInfo() { FoodName = "Güllaç", Kalori = 143f, Karbonhidrat = 21.7f, Protein = 2.55f, Yag = 4.83f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Gullac);



            FoodInfo TavukGogsuTatli = new FoodInfo() { FoodName = "Tavuk Göğsü Tatlısı", Kalori = 165f, Karbonhidrat = 31.1f, Protein = 6.25f, Yag = 0.2f, Gram = 100};
            context.FoodInfos.AddOrUpdate(TavukGogsuTatli);



            FoodInfo Muhallebi = new FoodInfo() { FoodName = "Muhallebi", Kalori = 233f, Karbonhidrat = 38.18f, Protein = 4.7f, Yag = 4.60f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Muhallebi);



            FoodInfo Puding = new FoodInfo() { FoodName = "Puding", Kalori = 132f, Karbonhidrat = 16.63f, Protein = 7.45f, Yag = 3.8f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Puding);



            FoodInfo Supangle = new FoodInfo() { FoodName = "Supangle", Kalori = 160f, Karbonhidrat = 19f, Protein = 4.52f, Yag = 6.63f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Supangle);



            FoodInfo Trilece = new FoodInfo() { FoodName = "Trileçe", Kalori = 301f, Karbonhidrat = 39f, Protein = 12.85f, Yag = 9.25f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Trilece);



            FoodInfo Hosmerim = new FoodInfo() { FoodName = "Höşmerim", Kalori = 343f, Karbonhidrat = 111f, Protein = 17f, Yag = 10.8f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Hosmerim);



            FoodInfo Keskul = new FoodInfo() { FoodName = "Keşkül", Kalori = 273f, Karbonhidrat = 42.55f, Protein = 7.3f, Yag = 7.7f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Keskul);



            FoodInfo Asure = new FoodInfo() { FoodName = "Aşure", Kalori = 344f, Karbonhidrat = 61.21f, Protein = 7.84f, Yag = 5.5f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Asure);



            FoodInfo Profiterol = new FoodInfo() { FoodName = "Profiterol", Kalori = 429f, Karbonhidrat = 55.8f, Protein = 5.8f, Yag = 19.3f, Gram = 100};
            context.FoodInfos.AddOrUpdate(Profiterol);



            FoodInfo MeyveliDondurma = new FoodInfo() { FoodName = "Meyveli Dondurma", Kalori = 99f, Karbonhidrat = 21.05f, Protein = 0.97f, Yag = 1.02f, Gram = 100};
            context.FoodInfos.AddOrUpdate(MeyveliDondurma);



            FoodInfo SutluDondurma = new FoodInfo() { FoodName = "Sütlü Dondurma", Kalori = 240f, Karbonhidrat = 30.75f, Protein = 9f, Yag = 9f, Gram = 100};
            context.FoodInfos.AddOrUpdate(SutluDondurma);



            FoodInfo CikolataliDondurma = new FoodInfo() { FoodName = "Çikolatalı Dondurma", Kalori = 216f, Karbonhidrat = 28.2f, Protein = 3.8f, Yag = 11f, Gram = 100};
            context.FoodInfos.AddOrUpdate(CikolataliDondurma);



            FoodInfo IrmikTatlisi = new FoodInfo() { FoodName = "Sütlü İrmik Tatlısı", Kalori = 262f, Karbonhidrat = 43.15f, Protein = 7f, Yag = 5f, Gram = 100};
            context.FoodInfos.AddOrUpdate(IrmikTatlisi);



            FoodInfo IrmikHelvasi = new FoodInfo() { FoodName = "İrmik Helvası", Kalori = 532f, Karbonhidrat = 64.9f, Protein = 7.77f, Yag = 25.20f, Gram = 100};
            context.FoodInfos.AddOrUpdate(IrmikHelvasi);



            FoodInfo UnHelvasi = new FoodInfo() { FoodName = "Un Helvası", Kalori = 294f, Karbonhidrat = 43.5f, Protein = 0.12f, Yag = 12.18f, Gram = 100};
            context.FoodInfos.AddOrUpdate(UnHelvasi);

            

            //ŞERBETLİ TATLILAR



            FoodInfo Baklava = new FoodInfo() { FoodName = "Baklava", Kalori = 660f, Karbonhidrat = 79f, Protein = 12.36f, Yag = 34.35f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Baklava);



            FoodInfo Kadayif = new FoodInfo() { FoodName = "Kadayıf", Kalori = 422f, Karbonhidrat = 51.75f, Protein = 6.85f, Yag = 22.55f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kadayif);



            FoodInfo SogukBaklava = new FoodInfo() { FoodName = "Soğuk Baklava", Kalori = 242f, Karbonhidrat = 34.45f, Protein = 3.3f, Yag = 14.75f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(SogukBaklava);



            FoodInfo Tulumba = new FoodInfo() { FoodName = "Tulumba", Kalori = 256f, Karbonhidrat = 40.7f, Protein = 2.51f, Yag = 7.25f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Tulumba);



            FoodInfo Kemalpasa = new FoodInfo() { FoodName = "Kemalpaşa", Kalori = 476f, Karbonhidrat = 84.4f, Protein = 16.6f, Yag = 13.55f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kemalpasa);



            FoodInfo HalkaTatlisi = new FoodInfo() { FoodName = "Halka Tatlısı", Kalori = 673f, Karbonhidrat = 66.75f, Protein = 5f, Yag = 40.6f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(HalkaTatlisi);



            FoodInfo SamTatlisi = new FoodInfo() { FoodName = "Şam Tatlısı", Kalori = 330f, Karbonhidrat = 150.75f, Protein = 18.88f, Yag = 0.94f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(SamTatlisi);



            FoodInfo Sobiyet = new FoodInfo() { FoodName = "Şöbiyet", Kalori = 522f, Karbonhidrat = 59.76f, Protein = 5.95f, Yag = 29.15f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Sobiyet);



            FoodInfo Kunefe = new FoodInfo() { FoodName = "Künefe", Kalori = 426f, Karbonhidrat = 55f, Protein = 7.36f, Yag = 20.52f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kunefe);



            FoodInfo Sekerpare = new FoodInfo() { FoodName = "Şekerpare", Kalori = 272f, Karbonhidrat = 45.95f, Protein = 2.65f, Yag = 8.95f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Sekerpare);



            FoodInfo Revani = new FoodInfo() { FoodName = "Revani", Kalori = 348f, Karbonhidrat = 55f, Protein = 5.82f, Yag = 9.4f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Revani);



            FoodInfo LokmaTatlisi = new FoodInfo() { FoodName = "Lokma Tatlısı", Kalori = 78f, Karbonhidrat = 7.52f, Protein = 0.35f, Yag = 4.82f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(LokmaTatlisi);



            FoodInfo Kalburabasti = new FoodInfo() { FoodName = "Kalburabastı", Kalori = 251f, Karbonhidrat = 34.38f, Protein = 4f, Yag = 11.33f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kalburabasti);



            FoodInfo FistikliSarma = new FoodInfo() { FoodName = "Fıstıklı Sarma Tatlısı", Kalori = 210f, Karbonhidrat = 20.95f, Protein = 3.71f, Yag = 12.08f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(FistikliSarma);



            FoodInfo DilberDudagi = new FoodInfo() { FoodName = "Un Helvası", Kalori = 99f, Karbonhidrat = 12.63f, Protein = 0.48f, Yag = 4.81f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(DilberDudagi);



            FoodInfo SanSebastian = new FoodInfo() { FoodName = "San Sebastian", Kalori = 480f, Karbonhidrat = 37.05f, Protein = 7.8f, Yag = 33.3f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(SanSebastian);


            //KAHVALTILI SICAKLARI

            FoodInfo HaslanmisYumurta = new FoodInfo() { FoodName = "Haşlanmış Yumurta", Kalori = 78f, Karbonhidrat = 0.56f, Protein = 6.3f, Yag = 5.31f, Gram = 100 };

            context.FoodInfos.AddOrUpdate(HaslanmisYumurta);

            FoodInfo Omlet = new FoodInfo() { FoodName = "Omlet", Kalori = 101f, Karbonhidrat = 1.27f, Protein = 6.7f, Yag = 7.94f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Omlet);

            FoodInfo PeynirliOmlet = new FoodInfo() { FoodName = "Peynirli Omlet", Kalori = 254f, Karbonhidrat = 2.05f, Protein = 15.3f, Yag = 15f, Gram = 100 }; context.FoodInfos.AddOrUpdate(PeynirliOmlet);

            FoodInfo MantarliOmlet = new FoodInfo() { FoodName = "Mantarlı Omlet", Kalori = 205f, Karbonhidrat = 3.7f, Protein = 12.45f, Yag = 10f, Gram = 100 }; context.FoodInfos.AddOrUpdate(MantarliOmlet);

            FoodInfo Menemen = new FoodInfo() { FoodName = "Menemen", Kalori = 205f, Karbonhidrat = 3.7f, Protein = 12.45f, Yag = 10f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Menemen);

            FoodInfo SucukluYumurta = new FoodInfo() { FoodName = "Sucuklu Yumurta", Kalori = 242f, Karbonhidrat = 3.4f, Protein = 13.5f, Yag = 19.5f, Gram = 100 }; context.FoodInfos.AddOrUpdate(SucukluYumurta);

            FoodInfo Kuymak = new FoodInfo() { FoodName = "Kuymak - Mıhlama", Kalori = 489f, Karbonhidrat = 3.95f, Protein = 19.1f, Yag = 44.4f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Kuymak);


            // Yemekler
            FoodInfo fasulye = new FoodInfo() { FoodName = "Etsiz Kuru Fasulye", Kalori = 322f, Karbonhidrat = 41.16f, Protein = 11.80f, Yag = 0.63f }; context.FoodInfos.AddOrUpdate(fasulye);
            FoodInfo merc = new FoodInfo() { FoodName = "Mercimnek Yemegi", Kalori = 164f, Karbonhidrat = 41.16f, Protein = 8.97f, Yag = 4.52f };
            context.FoodInfos.AddOrUpdate(merc);
            FoodInfo Barbunya = new FoodInfo() { FoodName = "Zeytinyaglı Barbunya", Kalori = 140f, Karbonhidrat = 42.83f, Protein = 15.99f, Yag = 14.14f }; context.FoodInfos.AddOrUpdate(Barbunya);
            FoodInfo Soya_Fasulyesi = new FoodInfo() { FoodName = "Soya Fasulyesi", Kalori = 164f, Karbonhidrat = 41.16f, Protein = 8.97f, Yag = 4.52f };
            context.FoodInfos.AddOrUpdate(Soya_Fasulyesi);
            FoodInfo Portakallı_Kek = new FoodInfo() { FoodName = "Portakallı Kek", Kalori = 188f, Karbonhidrat = 28.92f, Protein = 3.55f, Yag = 5.7f }; context.FoodInfos.AddOrUpdate(Portakallı_Kek);
            FoodInfo Kakaolu_Kek = new FoodInfo() { FoodName = "Kakaolu Kek", Kalori = 268f, Karbonhidrat = 31.2f, Protein = 3.94f, Yag = 13.11f };
            context.FoodInfos.AddOrUpdate(Kakaolu_Kek);
            FoodInfo Sade_Kek = new FoodInfo() { FoodName = "Sade Kek", Kalori = 241f, Karbonhidrat = 32.95f, Protein = 4.45f, Yag = 9.15f };
            context.FoodInfos.AddOrUpdate(Sade_Kek);
            FoodInfo Meyveli_Pasta = new FoodInfo() { FoodName = "Meyveli Pasta", Kalori = 164f, Karbonhidrat = 41.16f, Protein = 8.97f, Yag = 4.52f };
            context.FoodInfos.AddOrUpdate(Meyveli_Pasta);
            
            //börekler

            FoodInfo Peynirli_Börek = new FoodInfo() { FoodName = "Peynirli Börek", Kalori = 194f, Karbonhidrat = 25.11f, Protein = 7.58f, Yag = 6.85f };
            context.FoodInfos.AddOrUpdate(Peynirli_Börek);

            FoodInfo patatesliBorek = new FoodInfo() { FoodName = "Patatesli Börek", Kalori = 204, Karbonhidrat = 26.87f, Protein = 4.27f, Yag = 8.67f, Gram = 100, }; context.FoodInfos.AddOrUpdate(patatesliBorek);

            FoodInfo ispanakliBorek = new FoodInfo() { FoodName = "Ispanaklı Börek", Kalori = 116, Karbonhidrat = 21.39f, Protein = 4.29f, Yag = 2.35f, Gram = 100 }; context.FoodInfos.AddOrUpdate(ispanakliBorek);

            FoodInfo suBoregi = new FoodInfo() { FoodName = "Su Böreği", Kalori = 172, Karbonhidrat = 18.77f, Protein = 5.39f, Yag = 8.24f, Gram = 100 }; context.FoodInfos.AddOrUpdate(suBoregi);

            FoodInfo cigBorek = new FoodInfo() { FoodName = "Çiğ Börek", Kalori = 264, Karbonhidrat = 32.76f, Protein = 3.18f, Yag = 13.28f, Gram = 100 }; context.FoodInfos.AddOrUpdate(cigBorek);

            //Ekmek ve Tahıllar

            FoodInfo beyazEkmek = new FoodInfo() { FoodName = "Beyaz Ekmek", Kalori = 71, Karbonhidrat = 13.17f, Protein = 3.2f, Yag = 0.65f, Gram = 100 }; context.FoodInfos.AddOrUpdate(beyazEkmek);

            FoodInfo tamBugdayekmeği = new FoodInfo() { FoodName = "Tam Buğday Ekmeği", Kalori = 63, Karbonhidrat = 10.68f, Protein = 3.11f, Yag = 0.88f, Gram = 100 }; context.FoodInfos.AddOrUpdate(tamBugdayekmeği);

            FoodInfo cavdarEkmegi = new FoodInfo() { FoodName = "Cavdar Ekmeği", Kalori = 63, Karbonhidrat = 13.15f, Protein = 1.81f, Yag = 0.27f, Gram = 100 }; context.FoodInfos.AddOrUpdate(cavdarEkmegi);

            FoodInfo kepekliEkmegi = new FoodInfo() { FoodName = "Kepekli Ekmek", Kalori = 54, Karbonhidrat = 11.14f, Protein = 1.51f, Yag = 0.38f, Gram = 100 }; context.FoodInfos.AddOrUpdate(kepekliEkmegi);

            FoodInfo grisini = new FoodInfo() { FoodName = "Grissini", Kalori = 20, Karbonhidrat = 3.53f, Protein = 0.51f, Yag = 0.36f, Gram = 100 }; context.FoodInfos.AddOrUpdate(grisini);

            FoodInfo beyaztostEkmeği = new FoodInfo() { FoodName = "Beyaz Tost Ekmeği", Kalori = 76, Karbonhidrat = 14.31f, Protein = 2.21f, Yag = 1, Gram = 100 }; context.FoodInfos.AddOrUpdate(beyaztostEkmeği);

            FoodInfo cokTahilliTostEkmegi = new FoodInfo() { FoodName = "Çok Tahıllı Tost Ekmeği", Kalori = 67, Karbonhidrat = 11.65f, Protein = 3.33f, Yag = 0.79f, Gram = 100 }; context.FoodInfos.AddOrUpdate(cokTahilliTostEkmegi);
            FoodInfo sandvicEkmegi = new FoodInfo() { FoodName = "Sandviç Ekmeği", Kalori = 178, Karbonhidrat = 37.21f, Protein = 5.07f, Yag = 1.61f, Gram = 100 }; context.FoodInfos.AddOrUpdate(sandvicEkmegi);

            FoodInfo kepekliSandvicEkmegi = new FoodInfo() { FoodName = "Kepekli Sandviç Ekmeği", Kalori = 171, Karbonhidrat = 31.08f, Protein = 6.72f, Yag = 1.5f, Gram = 100 }; context.FoodInfos.AddOrUpdate(kepekliSandvicEkmegi);

            FoodInfo hamburgerEkmeği = new FoodInfo() { FoodName = "Hamburger Ekmeği", Kalori = 142, Karbonhidrat = 29.64f, Protein = 3.64f, Yag = 1.04f, Gram = 100 }; context.FoodInfos.AddOrUpdate(hamburgerEkmeği);

            FoodInfo yufka = new FoodInfo() { FoodName = "Yufka", Kalori = 387, Karbonhidrat = 80.18f, Protein = 10.94f, Yag = 1.41f, Gram = 100 }; context.FoodInfos.AddOrUpdate(yufka);

            FoodInfo irmik = new FoodInfo() { FoodName = "İrmik", Kalori = 36, Karbonhidrat = 7.28f, Protein = 1.27f, Yag = 0.11f, Gram = 100 }; context.FoodInfos.AddOrUpdate(irmik);

            FoodInfo misirNisastasi = new FoodInfo() { FoodName = "Mısır Nişastası", Kalori = 37, Karbonhidrat = 9.06f, Protein = 0.02f, Yag = 0.08f, Gram = 100 }; context.FoodInfos.AddOrUpdate(misirNisastasi);

            FoodInfo galetaUnu = new FoodInfo() { FoodName = "Galeta Unu", Kalori = 40, Karbonhidrat = 7.2f, Protein = 1.34f, Yag = 0.53f, Gram = 100 }; context.FoodInfos.AddOrUpdate(galetaUnu);

            FoodInfo un = new FoodInfo() { FoodName = "Beyaz Un", Kalori = 40, Karbonhidrat = 8.54f, Protein = 0.04f, Yag = 0.01f, Gram = 100 }; context.FoodInfos.AddOrUpdate(galetaUnu);

            // Meyveler

            FoodInfo Elma = new FoodInfo() { FoodName = "Elma", Kalori = 95f, Karbonhidrat = 25.13f, Protein = 0.47f, Yag = 0.31f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Elma);




            FoodInfo Armut = new FoodInfo() { FoodName = "Elma", Kalori = 101f, Karbonhidrat = 27.11f, Protein = 0.64f, Yag = 0.25f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Armut);



            FoodInfo Portakal = new FoodInfo() { FoodName = "Portakal", Kalori = 62f, Karbonhidrat = 15.40f, Protein = 1.25f, Yag = 0.16f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Portakal);



            FoodInfo Greyfurt = new FoodInfo() { FoodName = "Greyfurt", Kalori = 74f, Karbonhidrat = 18.45f, Protein = 1.35f, Yag = 0.25f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Greyfurt);



            FoodInfo Ayva = new FoodInfo() { FoodName = "Elma", Kalori = 57f, Karbonhidrat = 15.30f, Protein = 0.40f, Yag = 0.10f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Ayva);



            FoodInfo Mandalina = new FoodInfo() { FoodName = "Mandalina", Kalori = 40f, Karbonhidrat = 10.15f, Protein = 0.60f, Yag = 0.25f };
            context.FoodInfos.AddOrUpdate(Mandalina);



            FoodInfo Kivi = new FoodInfo() { FoodName = "Kivi", Kalori = 42f, Karbonhidrat = 10.10f, Protein = 0.62f, Yag = 0.25f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kivi);



            FoodInfo Muz = new FoodInfo() { FoodName = "Muz", Kalori = 105f, Karbonhidrat = 27f, Protein = 1.30f, Yag = 0.40f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Muz);



            FoodInfo Kayisi = new FoodInfo() { FoodName = "Kayısı", Kalori = 17f, Karbonhidrat = 3.90f, Protein = 0.50f, Yag = 0.15f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kayisi);



            FoodInfo Cilek = new FoodInfo() { FoodName = "Çilek", Kalori = 46f, Karbonhidrat = 11f, Protein = 0.95f, Yag = 0.45f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Cilek);



            FoodInfo TrabzonHurmasi = new FoodInfo() { FoodName = "Trabzon Hurması", Kalori = 60f, Karbonhidrat = 16f, Protein = 0.50f, Yag = 0.17f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(TrabzonHurmasi);



            FoodInfo Kiraz = new FoodInfo() { FoodName = "Kiraz", Kalori = 87f, Karbonhidrat = 22.10f, Protein = 1.45f, Yag = 0.30f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kiraz);



            FoodInfo Visne = new FoodInfo() { FoodName = "Vişne", Kalori = 52f, Karbonhidrat = 13f, Protein = 1.03f, Yag = 0.30f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Visne);



            FoodInfo Kavun = new FoodInfo() { FoodName = "Kavun", Kalori = 54f, Karbonhidrat = 13.05f, Protein = 1.35f, Yag = 0.30f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Kavun);



            FoodInfo Karpuz = new FoodInfo() { FoodName = "Karpuz", Kalori = 46f, Karbonhidrat = 15.13f, Protein = 43.10f, Yag = 36.37f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Karpuz);



            FoodInfo Ananas = new FoodInfo() { FoodName = "Ananas", Kalori = 28f, Karbonhidrat = 7.35f, Protein = 0.30f, Yag = 0.07f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Ananas);




            FoodInfo Avakado = new FoodInfo() { FoodName = "Avakado", Kalori = 160f, Karbonhidrat = 8.5f, Protein = 2.0f, Yag = 14.7f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Avakado);



            FoodInfo Mango = new FoodInfo() { FoodName = "Mango", Kalori = 100f, Karbonhidrat = 24.70f, Protein = 1.35f, Yag = 0.63f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Mango);



            FoodInfo Ahududu = new FoodInfo() { FoodName = "Ahududu", Kalori = 64f, Karbonhidrat = 14.70f, Protein = 1.5f, Yag = 0.80f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Ahududu);



            FoodInfo Bogurtlen = new FoodInfo() { FoodName = "Böğürtlen", Kalori = 62f, Karbonhidrat = 13.80f, Protein = 1.5f, Yag = 0.80f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Bogurtlen);



            FoodInfo YesilErik = new FoodInfo() { FoodName = "Yeşil Erik", Kalori = 76f, Karbonhidrat = 18.85f, Protein = 1.15f, Yag = 0.5f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(YesilErik);



            FoodInfo Incir = new FoodInfo() { FoodName = "İncir", Kalori = 37f, Karbonhidrat = 9.35f, Protein = 0.4f, Yag = 0.15f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Incir);



            FoodInfo Dut = new FoodInfo() { FoodName = "Dut", Kalori = 60f, Karbonhidrat = 13.70f, Protein = 2f, Yag = 0.55f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Dut);



            FoodInfo Uzum = new FoodInfo() { FoodName = "Üzüm", Kalori = 104f, Karbonhidrat = 27.3f, Protein = 1.1f, Yag = 0.25f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Uzum);



            FoodInfo Nar = new FoodInfo() { FoodName = "Nar", Kalori = 145f, Karbonhidrat = 33f, Protein = 3f, Yag = 2f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Nar);



            FoodInfo Seftali = new FoodInfo() { FoodName = "Şeftali", Kalori = 60f, Karbonhidrat = 14.30f, Protein = 1.36f, Yag = 0.38f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Seftali);



            FoodInfo Limon = new FoodInfo() { FoodName = "Limon", Kalori = 17f, Karbonhidrat = 5.4f, Protein = 0.65f, Yag = 0.17f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(Limon);



            FoodInfo KirmiziErik = new FoodInfo() { FoodName = "Kırmızı Erik", Kalori = 80f, Karbonhidrat = 21f, Protein = 1f, Yag = 0.15f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(KirmiziErik);



            // MAKARNALAR           

            FoodInfo HaslanmisMakarna = new FoodInfo() { FoodName = "Haşlanmış Makarna", Kalori = 157f, Karbonhidrat = 30.59f, Protein = 5.8f, Yag = 0.93f, Gram = 100}; 
            context.FoodInfos.AddOrUpdate(HaslanmisMakarna);

            FoodInfo DomatesliMakarna = new FoodInfo() { FoodName = "Domatesli Makarna", Kalori = 178f, Karbonhidrat = 27.43f, Protein = 6.55f, Yag = 4.48f, Gram = 100}; 
            context.FoodInfos.AddOrUpdate(DomatesliMakarna);

            FoodInfo SpagettiBolonez = new FoodInfo() { FoodName = "Spagetti Bolonez", Kalori = 303f, Karbonhidrat = 20.9f, Protein = 15.83f, Yag = 17f, Gram = 100}; context.FoodInfos.AddOrUpdate(SpagettiBolonez);

            FoodInfo PenneArabiata = new FoodInfo() { FoodName = "Penne Arabiata", Kalori = 164f, Karbonhidrat = 31.18f, Protein = 26.5f, Yag = 4.43f, Gram = 100}; context.FoodInfos.AddOrUpdate(PenneArabiata);

            FoodInfo Fettucini = new FoodInfo() { FoodName = "Fettucini Alfredo", Kalori = 289f, Karbonhidrat = 50.1f, Protein = 10.4f, Yag = 3.8f, Gram = 100}; context.FoodInfos.AddOrUpdate(Fettucini);

            FoodInfo Lazanya = new FoodInfo() { FoodName = "Lazanya", Kalori = 272f, Karbonhidrat = 25f, Protein = 12.65f, Yag = 13.56f, Gram = 100}; context.FoodInfos.AddOrUpdate(Lazanya);

            FoodInfo FirinMakarna = new FoodInfo() { FoodName = "Fırında Makarna", Kalori = 382f, Karbonhidrat = 52.26f, Protein = 17.14f, Yag = 11.2f, Gram = 100}; context.FoodInfos.AddOrUpdate(FirinMakarna);

            FoodInfo MakarnaSalatasi = new FoodInfo() { FoodName = "Makarna Salatası", Kalori = 283f, Karbonhidrat = 53.75f, Protein = 8.52f, Yag = 4.04f, Gram = 100}; context.FoodInfos.AddOrUpdate(MakarnaSalatasi);


            // SOSLAR

            FoodInfo Ketçap = new FoodInfo() { FoodName = "Ketçap", Kalori = 22f, Karbonhidrat = 4.8f, Protein = 0.25f, Yag = 0f, Gram = 100}; context.FoodInfos.AddOrUpdate(Ketçap);

            FoodInfo Mayonez = new FoodInfo() { FoodName = "Mayonez", Kalori = 50f, Karbonhidrat = 3.11f, Protein = 0.12f, Yag = 4.34f, Gram = 100}; context.FoodInfos.AddOrUpdate(Mayonez);

            FoodInfo Hardal = new FoodInfo() { FoodName = "Hardal", Kalori = 6f, Karbonhidrat = 0.58f, Protein = 0.37f, Yag = 0.33f, Gram = 100}; context.FoodInfos.AddOrUpdate(Hardal);

            FoodInfo BarbekuSos = new FoodInfo() { FoodName = "Barbekü Sos", Kalori = 26f, Karbonhidrat = 6.38f, Protein = 0.12f, Yag = 0.06f, Gram = 100}; context.FoodInfos.AddOrUpdate(BarbekuSos);

            FoodInfo RanchSos = new FoodInfo() { FoodName = "Ranch Sos", Kalori = 24f, Karbonhidrat = 1.79f, Protein = 0.46f, Yag = 1.7f, Gram = 100}; context.FoodInfos.AddOrUpdate(RanchSos);

            FoodInfo BuffaloSos = new FoodInfo() { FoodName = "Buffalo Sos", Kalori = 56f, Karbonhidrat = 1.4f, Protein = 0.4f, Yag = 5.4f, Gram = 100}; context.FoodInfos.AddOrUpdate(BuffaloSos);

            FoodInfo PestoSos = new FoodInfo() { FoodName = "Pesto Sos", Kalori = 9f, Karbonhidrat = 0.54f, Protein = 3.47f, Yag = 4.86f, Gram = 100}; context.FoodInfos.AddOrUpdate(PestoSos);

            FoodInfo NarEkşisi = new FoodInfo() { FoodName = "Nar Ekşisi", Kalori = 15f, Karbonhidrat = 3.7f, Protein = 0.05f, Yag = 0f, Gram = 100}; context.FoodInfos.AddOrUpdate(NarEkşisi);

            FoodInfo KoriSos = new FoodInfo() { FoodName = "Köri Sos", Kalori = 22f, Karbonhidrat = 1.6f, Protein = 0.05f, Yag = 1.7f, Gram = 100}; context.FoodInfos.AddOrUpdate(KoriSos);

            FoodInfo SoyaSos = new FoodInfo() { FoodName = "Soya Sos", Kalori = 6f, Karbonhidrat = 0.56f, Protein = 1.05f, Yag = 0f, Gram = 100}; context.FoodInfos.AddOrUpdate(SoyaSos);

            //FASTFOODLAR           
             FoodInfo CitirTavuk = new FoodInfo() { FoodName = "Çıtır Tavuk", Kalori = 529f, Karbonhidrat = 38.05f, Protein = 34f, Yag = 26.65f, Gram = 100};            context.FoodInfos.AddOrUpdate(CitirTavuk);

            FoodInfo TavukBurger = new FoodInfo() { FoodName = "Tavuk Burger ", Kalori = 270f, Karbonhidrat = 33f, Protein = 13f, Yag = 10f, Gram = 100}; context.FoodInfos.AddOrUpdate(TavukBurger);

            FoodInfo Cheeseburger = new FoodInfo() { FoodName = "Cheeseburger", Kalori = 290f, Karbonhidrat = 30.96f, Protein = 16.95f, Yag = 12f, Gram = 100}; context.FoodInfos.AddOrUpdate(Cheeseburger);

            FoodInfo EtliEkmek = new FoodInfo() { FoodName = "Etli Ekmek", Kalori = 277f, Karbonhidrat = 31.07f, Protein = 15.28f, Yag = 9.56f, Gram = 100}; context.FoodInfos.AddOrUpdate(EtliEkmek);

            FoodInfo Lahmacun = new FoodInfo() { FoodName = "Lahmacun", Kalori = 221f, Karbonhidrat = 32.27f, Protein = 9.75f, Yag = 5.55f, Gram = 100}; context.FoodInfos.AddOrUpdate(Lahmacun);

            FoodInfo Tantuni = new FoodInfo() { FoodName = "Tantuni", Kalori = 380f, Karbonhidrat = 19.05f, Protein = 43.6f, Yag = 50.34f, Gram = 100}; context.FoodInfos.AddOrUpdate(Tantuni);

            FoodInfo PizzaKarisik = new FoodInfo() { FoodName = "Karışık Pizza", Kalori = 241f, Karbonhidrat = 40f, Protein = 7.8f, Yag = 5.63f, Gram = 100}; context.FoodInfos.AddOrUpdate(PizzaKarisik);

            FoodInfo PizzaSebzeli = new FoodInfo() { FoodName = "Sebzeli Pizza", Kalori = 266f, Karbonhidrat = 41.23f, Protein = 13.1f, Yag = 6.6f, Gram = 100}; context.FoodInfos.AddOrUpdate(PizzaSebzeli);

            FoodInfo Kokorec = new FoodInfo() { FoodName = "Kokoreç Yarım Ekmek", Kalori = 433f, Karbonhidrat = 68.77f, Protein = 28.1f, Yag = 3.93f, Gram = 100}; context.FoodInfos.AddOrUpdate(Kokorec);

            FoodInfo Cigkofte = new FoodInfo() { FoodName = "Çiğköfte Dürüm", Kalori = 361f, Karbonhidrat = 64.75f, Protein = 15.06f, Yag = 30.64f, Gram = 100}; context.FoodInfos.AddOrUpdate(Cigkofte);

            FoodInfo DurumTavukDoner = new FoodInfo() { FoodName = "Tavuk Döner Dürüm", Kalori = 309f, Karbonhidrat = 15.13f, Protein = 43.1f, Yag = 36.37f, Gram = 100}; context.FoodInfos.AddOrUpdate(DurumTavukDoner);

            FoodInfo DurumEtDoner = new FoodInfo() { FoodName = "Et Döner Dürüm", Kalori = 301f, Karbonhidrat = 19.7f, Protein = 29.65f, Yag = 45.6f, Gram = 100}; context.FoodInfos.AddOrUpdate(DurumEtDoner);

            FoodInfo Kumpir = new FoodInfo() { FoodName = "Kumpir", Kalori = 1296f, Karbonhidrat = 65.74f, Protein = 50f, Yag = 92.35f, Gram = 100}; context.FoodInfos.AddOrUpdate(Kumpir);

            FoodInfo AdanaDurum = new FoodInfo() { FoodName = "Adana Dürüm", Kalori = 325f, Karbonhidrat = 15.02f, Protein = 27.80f, Yag = 45.5f, Gram = 100}; context.FoodInfos.AddOrUpdate(AdanaDurum);

            FoodInfo UrfaDurum = new FoodInfo() { FoodName = "Urfa Dürüm", Kalori = 325f, Karbonhidrat = 15.02f, Protein = 27.80f, Yag = 45.5f, Gram = 100}; context.FoodInfos.AddOrUpdate(UrfaDurum);

            FoodInfo PatatesKizartmasi = new FoodInfo() { FoodName = "Patates Kızartması", Kalori = 250f, Karbonhidrat = 33.15f, Protein = 2.75f, Yag = 11.8f, Gram = 100}; context.FoodInfos.AddOrUpdate(PatatesKizartmasi);

            FoodInfo SoganHalkasi = new FoodInfo() { FoodName = "Soğan Halkası", Kalori = 97f, Karbonhidrat = 18.91f, Protein = 3.4f, Yag = 0.63f, Gram = 100}; context.FoodInfos.AddOrUpdate(SoganHalkasi);

            FoodInfo KiymaliPide = new FoodInfo() { FoodName = "Kıymalı Pide", Kalori = 628f, Karbonhidrat = 73.44f, Protein = 24.6f, Yag = 25.57f, Gram = 100}; context.FoodInfos.AddOrUpdate(KiymaliPide);

            FoodInfo KasarliPide = new FoodInfo() { FoodName = "Kaşarlı Pide", Kalori = 600f, Karbonhidrat = 69f, Protein = 19.75f, Yag = 26.83f, Gram = 100}; context.FoodInfos.AddOrUpdate(KasarliPide);

            FoodInfo KusbasiPide = new FoodInfo() { FoodName = "Kuşbaşılı pide", Kalori = 515f, Karbonhidrat = 73.2f, Protein = 28.3f, Yag = 11.5f, Gram = 100}; context.FoodInfos.AddOrUpdate(KusbasiPide);

            //ŞARKÜTERİ ÜRÜNLERİ

            FoodInfo Sucuk = new FoodInfo() { FoodName = "Sucuk", Kalori = 166f, Karbonhidrat = 2.57f, Protein = 7.1f, Yag = 14.2f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Sucuk);

            FoodInfo Sosis = new FoodInfo() { FoodName = "Sosis", Kalori = 60f, Karbonhidrat = 0.12f, Protein = 2.24f, Yag = 5.6f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Sosis);

            FoodInfo DanaSalam = new FoodInfo() { FoodName = "Dana Salam", Kalori = 45f, Karbonhidrat = 0.64f, Protein = 1.65f, Yag = 3.92f, Gram = 100 }; context.FoodInfos.AddOrUpdate(DanaSalam);

            FoodInfo HindiSalam = new FoodInfo() { FoodName = "Hindi Salam", Kalori = 17f, Karbonhidrat = 0.24f, Protein = 1.31f, Yag = 1.13f, Gram = 100 }; context.FoodInfos.AddOrUpdate(HindiSalam);

            FoodInfo DanaJambon = new FoodInfo() { FoodName = "Dana Jambon", Kalori = 32f, Karbonhidrat = 0.7f, Protein = 4.92f, Yag = 0f, Gram = 100 }; context.FoodInfos.AddOrUpdate(DanaJambon);

            FoodInfo HindiJambon = new FoodInfo() { FoodName = "Hindi Jambon", Kalori = 15f, Karbonhidrat = 0.35f, Protein = 2.35f, Yag = 0.46f, Gram = 100 }; context.FoodInfos.AddOrUpdate(HindiJambon);

            FoodInfo PilicJambon = new FoodInfo() { FoodName = "Piliç Jambon", Kalori = 11f, Karbonhidrat = 0.12f, Protein = 1.56f, Yag = 0.44f, Gram = 100 }; context.FoodInfos.AddOrUpdate(PilicJambon);
            FoodInfo HindiFume = new FoodInfo() { FoodName = "Hindi Füme", Kalori = 51f, Karbonhidrat = 0f, Protein = 8.8f, Yag = 1.5f, Gram = 100 }; context.FoodInfos.AddOrUpdate(HindiFume);

            FoodInfo PilicFume = new FoodInfo() { FoodName = "Pilic Füme", Kalori = 26f, Karbonhidrat = 0.3f, Protein = 3.9f, Yag = 0.9f, Gram = 100 }; context.FoodInfos.AddOrUpdate(PilicFume);

            FoodInfo Pastirma = new FoodInfo() { FoodName = "Pastırma", Kalori = 75f, Karbonhidrat = 0f, Protein = 8.85f, Yag = 4.17f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Pastirma);

            //EV Yemekleri 

            FoodInfo pilavUstuFasulye = new FoodInfo() { FoodName = "Pilav Üstü Kuru", Gram = 100, Kalori = 336, Karbonhidrat = 57.52f, Protein = 15.28f, Yag = 4.44f }; context.FoodInfos.AddOrUpdate(pilavUstuFasulye);

            FoodInfo hamsiliPilav = new FoodInfo() { FoodName = "Hamsili Pilav", Gram = 100, Kalori = 334, Karbonhidrat = 30.3f, Protein = 26.52f, Yag = 12.29f }; context.FoodInfos.AddOrUpdate(hamsiliPilav);

            FoodInfo sehriyeliPilav = new FoodInfo() { FoodName = "Şehriyeli Pilav", Gram = 100, Kalori = 462, Karbonhidrat = 82.85f, Protein = 8.53f, Yag = 10.01f }; context.FoodInfos.AddOrUpdate(sehriyeliPilav);

            FoodInfo nohutluPilav = new FoodInfo() { FoodName = "Nohutlu Pilav ", Gram = 100, Kalori = 169, Karbonhidrat = 31.29f, Protein = 4.15f, Yag = 2.94f }; context.FoodInfos.AddOrUpdate(nohutluPilav);

            FoodInfo icPilav = new FoodInfo() { FoodName = "İç Pilav", Gram = 100, Kalori = 139, Karbonhidrat = 25.99f, Protein = 2.59f, Yag = 2.53f }; context.FoodInfos.AddOrUpdate(icPilav);

            FoodInfo sadePilav = new FoodInfo() { FoodName = "Sade Pilav", Gram = 100, Kalori = 118, Karbonhidrat = 22.62f, Protein = 1.99f, Yag = 1.99f }; context.FoodInfos.AddOrUpdate(sadePilav);

            FoodInfo domatesliBulgurPilavi = new FoodInfo() { FoodName = "Domatesli Bulgur Pilavı", Gram = 100, Kalori = 169, Karbonhidrat = 31.13f, Protein = 4.56f, Yag = 2.61f }; context.FoodInfos.AddOrUpdate(domatesliBulgurPilavi);

            FoodInfo acemPilavi = new FoodInfo() { FoodName = "Acem Pilavı", Gram = 100, Kalori = 480, Karbonhidrat = 43.69f, Protein = 22.32f, Yag = 23.76f }; context.FoodInfos.AddOrUpdate(acemPilavi);

            FoodInfo ozbekPilavi = new FoodInfo() { FoodName = "Özbek Pilavı", Gram = 100, Kalori = 570, Karbonhidrat = 58.2f, Protein = 22.35f, Yag = 27.56f }; context.FoodInfos.AddOrUpdate(ozbekPilavi);

            FoodInfo basmatiPilavi = new FoodInfo() { FoodName = "Basmati Pilavı", Gram = 100, Kalori = 118, Karbonhidrat = 14.05f, Protein = 1.65f, Yag = 3.1f }; context.FoodInfos.AddOrUpdate(basmatiPilavi);

            FoodInfo kuskusPilavi = new FoodInfo() { FoodName = "Kuskus Pilavı", Gram = 100, Kalori = 380, Karbonhidrat = 72.76f, Protein = 11.79f, Yag = 3.75f }; context.FoodInfos.AddOrUpdate(kuskusPilavi);

            FoodInfo tereyaglıPrincPilavi = new FoodInfo() { FoodName = "Tereyağlı Pirinç Pilavı", Gram = 100, Kalori = 283, Karbonhidrat = 46.47f, Protein = 4.14f, Yag = 8.65f }; context.FoodInfos.AddOrUpdate(tereyaglıPrincPilavi);


            FoodInfo bezelyeCorbasi = new FoodInfo() { FoodName = "Bezelye Çorbası", Kalori = 31, Karbonhidrat = 3.06f, Protein = 1.05f, Yag = 1.6f, Gram = 100 }; context.FoodInfos.AddOrUpdate(bezelyeCorbasi);

            FoodInfo domatesCorbasi = new FoodInfo() { FoodName = "Domates Çorbası", Kalori = 47, Karbonhidrat = 6.53f, Protein = 1.36f, Yag = 1.66f, Gram = 100 }; context.FoodInfos.AddOrUpdate(domatesCorbasi);

            FoodInfo kasarliDomatesCorbasi = new FoodInfo() { FoodName = "Kaşarlı Domates Çorbası", Kalori = 31, Karbonhidrat = 2.07f, Protein = 1.68f, Yag = 1.73f, Gram = 100 }; context.FoodInfos.AddOrUpdate(kasarliDomatesCorbasi);

            FoodInfo ezogelinCorbasi = new FoodInfo() { FoodName = "Ezogelin Çorbası", Kalori = 68, Karbonhidrat = 8.92f, Protein = 2.83f, Yag = 1.76f, Gram = 100 }; context.FoodInfos.AddOrUpdate(ezogelinCorbasi);

            FoodInfo iskembeCorbasi = new FoodInfo() { FoodName = "İşkembe Çorbası", Kalori = 139, Karbonhidrat = 4.93f, Protein = 15.14f, Yag = 6.35f, Gram = 100 }; context.FoodInfos.AddOrUpdate(iskembeCorbasi);

            FoodInfo kirmiziMercimekCorbasi = new FoodInfo() { FoodName = "Kırmızı Mercimek Çorbası", Kalori = 68, Karbonhidrat = 12.42f, Protein = 3.69f, Yag = 0.29f, Gram = 100 }; context.FoodInfos.AddOrUpdate(kirmiziMercimekCorbasi);

            FoodInfo yesilMercimekCorbasi = new FoodInfo() { FoodName = "Yeşil Mercimek Çorbası", Kalori = 121, Karbonhidrat = 12.04f, Protein = 4.5f, Yag = 6.03f, Gram = 100 }; context.FoodInfos.AddOrUpdate(yesilMercimekCorbasi);

            FoodInfo sebzeCorbasi = new FoodInfo() { FoodName = "Sebze Çorbası", Kalori = 44, Karbonhidrat = 6.06f, Protein = 1, Yag = 1.68f, Gram = 100 }; context.FoodInfos.AddOrUpdate(sebzeCorbasi);

            FoodInfo tarhanaCorbasi = new FoodInfo() { FoodName = "Tarhana Çorbası", Kalori = 91, Karbonhidrat = 7.48f, Protein = 3.45f, Yag = 4.93f, Gram = 100 }; context.FoodInfos.AddOrUpdate(tarhanaCorbasi);

            FoodInfo yaylaCorbasi = new FoodInfo() { FoodName = "Yayla Çorbası", Kalori = 70, Karbonhidrat = 9.71f, Protein = 12.19f, Yag = 2.41f, Gram = 100 }; context.FoodInfos.AddOrUpdate(yaylaCorbasi);

            FoodInfo tavukCorbasi = new FoodInfo() { FoodName = "Tavuk Çorbası", Kalori = 83, Karbonhidrat = 5.17f, Protein = 5.96f, Yag = 2.95f, Gram = 100 }; context.FoodInfos.AddOrUpdate(tavukCorbasi);

            FoodInfo balkabagiCorbasi = new FoodInfo() { FoodName = "Balkabaği Çorbası", Kalori = 29, Karbonhidrat = 2.41f, Protein = 1.87f, Yag = 1.19f, Gram = 100 }; context.FoodInfos.AddOrUpdate(balkabagiCorbasi);

            FoodInfo mantarCorbasi = new FoodInfo() { FoodName = "Mantar Çorbası", Kalori = 99, Karbonhidrat = 7.36f, Protein = 3.06f, Yag = 6.37f, Gram = 100 }; context.FoodInfos.AddOrUpdate(mantarCorbasi);

            FoodInfo kremaliMantarCorbasi = new FoodInfo() { FoodName = "Kremalı Mantar Çorbası", Kalori = 120, Karbonhidrat = 5.21f, Protein = 1.92f, Yag = 11.27f, Gram = 100 }; context.FoodInfos.AddOrUpdate(kremaliMantarCorbasi);

            FoodInfo brokoliCorbasi = new FoodInfo() { FoodName = "Brokoli Çorbası", Kalori = 39, Karbonhidrat = 5.06f, Protein = 1.37f, Yag = 1.47f, Gram = 100 }; context.FoodInfos.AddOrUpdate(brokoliCorbasi);

            FoodInfo pacaCorbasi = new FoodInfo() { FoodName = "Paça Çorbası", Kalori = 117, Karbonhidrat = 0.86f, Protein = 18.81f, Yag = 4.29f, Gram = 100 }; context.FoodInfos.AddOrUpdate(pacaCorbasi);

            FoodInfo balikCorbasi = new FoodInfo() { FoodName = "Balik Çorbası", Kalori = 49, Karbonhidrat = 4.43f, Protein = 4.51f, Yag = 1.27f, Gram = 100 }; context.FoodInfos.AddOrUpdate(balikCorbasi);

            FoodInfo tutmacCorbasi = new FoodInfo() { FoodName = "Tutmac Çorbası", Kalori = 72, Karbonhidrat = 7.2f, Protein = 3.01f, Yag = 3.07f, Gram = 100 }; context.FoodInfos.AddOrUpdate(tutmacCorbasi);

            FoodInfo kerevizCorbasi = new FoodInfo() { FoodName = "Kereviz Çorbası", Kalori = 67, Karbonhidrat = 6.51f, Protein = 0.87f, Yag = 4.16f, Gram = 100 }; context.FoodInfos.AddOrUpdate(kerevizCorbasi);

            //KAHVALTILIKLAR

            FoodInfo SiyahZeytin = new FoodInfo() { FoodName = "Siyah Zeytin", Kalori = 5f, Karbonhidrat = 0.24f, Protein = 0.03f, Yag = 0.44f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(SiyahZeytin);

            FoodInfo YesilZeytin = new FoodInfo() { FoodName = "Yeşil Zeytin", Kalori = 6f, Karbonhidrat = 0.15f, Protein = 0.05f, Yag = 0.61f, Gram = 100 };
            context.FoodInfos.AddOrUpdate(YesilZeytin);

            FoodInfo Bal = new FoodInfo() { FoodName = "Bal", Kalori = 30f, Karbonhidrat = 8.25f, Protein = 0.04f, Yag = 0f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Bal);



            FoodInfo Kaymak = new FoodInfo() { FoodName = "Kaymak", Kalori = 29f, Karbonhidrat = 0.17f, Protein = 0.05f, Yag = 3.16f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Kaymak);

            FoodInfo TahinHelvasi = new FoodInfo() { FoodName = "Keçi Sütü", Kalori = 197f, Karbonhidrat = 15.8f, Protein = 5.11f, Yag = 12.53f, Gram = 100 }; context.FoodInfos.AddOrUpdate(TahinHelvasi);

            FoodInfo YazHelvasi = new FoodInfo() { FoodName = "Cevizli Yaz Helvası", Kalori = 169f, Karbonhidrat = 13.55f, Protein = 4.41f, Yag = 10f, Gram = 100 }; context.FoodInfos.AddOrUpdate(YazHelvasi);

            FoodInfo Tahin = new FoodInfo() { FoodName = "Tahin", Kalori = 87f, Karbonhidrat = 3.18f, Protein = 2.67f, Yag = 7.2f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Tahin);

            FoodInfo Pekmez = new FoodInfo() { FoodName = "Pekmez", Kalori = 29f, Karbonhidrat = 0f, Protein = 0f, Yag = 0.01f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Pekmez);



            FoodInfo Nutella = new FoodInfo() { FoodName = "Nutella", Kalori = 27f, Karbonhidrat = 2.88f, Protein = 0.32f, Yag = 1.55f, Gram = 100 }; context.FoodInfos.AddOrUpdate(Nutella);

            FoodInfo KakaoluFindikKremasi = new FoodInfo() { FoodName = "Kakaolu Fındık Kreması", Kalori = 25f, Karbonhidrat = 2.71f, Protein = 0.44f, Yag = 1.38f, Gram = 100 }; context.FoodInfos.AddOrUpdate(KakaoluFindikKremasi);

            FoodInfo FindikEzmesi = new FoodInfo() { FoodName = "Fındık Ezmesi", Kalori = 34f, Karbonhidrat = 3.08f, Protein = 0.55f, Yag = 2.23f, Gram = 100 }; context.FoodInfos.AddOrUpdate(FindikEzmesi);

            FoodInfo FistikEzmesi = new FoodInfo() { FoodName = "Fıstık Ezmesi ", Kalori = 35f, Karbonhidrat = 1.3f, Protein = 1.44f, Yag = 3f, Gram = 100 }; context.FoodInfos.AddOrUpdate(FistikEzmesi);

            FoodInfo SekersizFistikEzmesi = new FoodInfo() { FoodName = "Şekersiz Fıstık Ezmesi", Kalori = 36f, Karbonhidrat = 1.1f, Protein = 1.32f, Yag = 2.76f, Gram = 100 }; context.FoodInfos.AddOrUpdate(SekersizFistikEzmesi);



        }

    }
}
