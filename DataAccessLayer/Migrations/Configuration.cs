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

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            ////Deniz Ürünleri
            //FoodInfo somon = new FoodInfo() { FoodName = "Somon", Kalori = 2.08f, Karbonhidrat = 0, Protein = 0.19f, Yag = 0.13f};
            //context.FoodInfos.Add(somon);



            //FoodInfo ahtapot = new FoodInfo() { FoodName = "Ahtapot", Kalori = 0.73f, Karbonhidrat = 0.01f, Protein = 0.15f, Yag = 0.08f };
            //context.FoodInfos.Add(ahtapot);



            //FoodInfo alabalik = new FoodInfo() { FoodName = "Alabalık", Kalori = 1.01m, Karbonhidrat = 0, Protein = 0.19m, Yag = 0.02m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(alabalik);



            //FoodInfo barbun = new FoodInfo() { FoodName = "Barbun", Kalori = 1.2m, Karbonhidrat = 0, Protein = 0.16m, Yag = 0.06m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(barbun);



            //FoodInfo cipura = new FoodInfo() { FoodName = "Çipura", Kalori = 1.2m, Karbonhidrat = 0, Protein = 0.16m, Yag = 0.06m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(cipura);



            //FoodInfo dilBaligi = new FoodInfo() { FoodName = "Dil Balığı", Kalori = 0.79m, Karbonhidrat = 0, Protein = 0.19m, Yag = 0, CreatedBy = "Admin" };
            //context.FoodInfos.Add(dilBaligi);



            //FoodInfo hamsiIzgara = new FoodInfo() { FoodName = "Izgara Hamsi", Kalori = 2m, Karbonhidrat = 0.05m, Protein = 0.19m, Yag = 0.1m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(hamsiIzgara);



            //FoodInfo hamsiKizartma = new FoodInfo() { FoodName = "Kızartma Hamsi", Kalori = 1.15m, Yag = 0.05m, Karbonhidrat = 0, Protein = 0.17m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(hamsiKizartma);



            //FoodInfo havyar = new FoodInfo() { FoodName = "Havyar", Kalori = 2.62m, Karbonhidrat = 0.03m, Protein = 0.26m, Yag = 0.15m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(havyar);



            //FoodInfo istakoz = new FoodInfo() { FoodName = "Istakoz", Kalori = 0.91m, Karbonhidrat = 0m, Protein = 0.17m, Yag = 0.02m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(istakoz);



            //FoodInfo istavrit = new FoodInfo() { FoodName = "İstavrit", Kalori = 0.81m, Karbonhidrat = 0m, Protein = 0.17m, Yag = 0.01m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(istavrit);



            //FoodInfo istiridye = new FoodInfo() { FoodName = "İstiridye", Kalori = 0.68m, Karbonhidrat = 0m, Protein = 0.09m, Yag = 0.01m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(istiridye);



            //FoodInfo izmarit = new FoodInfo() { FoodName = "İzmarit", Kalori = 1.53m, Karbonhidrat = 0m, Protein = 0.23m, Yag = 0.06m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(izmarit);



            //FoodInfo kalkan = new FoodInfo() { FoodName = "Kalkan Balığı", Kalori = 1.35m, Karbonhidrat = 0m, Protein = 0.20m, Yag = 0.06m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(kalkan);



            //FoodInfo karidesGuvec = new FoodInfo() { FoodName = "Karides Güveç", Kalori = 1.25m, Karbonhidrat = 0.02m, Protein = 0.16m, Yag = 0.07m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(karidesGuvec);



            //FoodInfo tereyagdaKarides = new FoodInfo() { FoodName = "Tereyağda Karides", Kalori = 3.19m, Karbonhidrat = 0m, Protein = 0.16m, Yag = 0.29m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(tereyagdaKarides);



            //FoodInfo kefal = new FoodInfo() { FoodName = "Kefal Balığı", Kalori = 1.73m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0, CreatedBy = "Admin" };
            //context.FoodInfos.Add(kefal);



            //FoodInfo kilic = new FoodInfo() { FoodName = "Kılıç Balığı", Kalori = 1.53m, Karbonhidrat = 0m, Protein = 0.23m, Yag = 0.06m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(kilic);



            //FoodInfo levrek = new FoodInfo() { FoodName = "İzmarit", Kalori = 0.86m, Karbonhidrat = 0m, Protein = 0.18m, Yag = 0, CreatedBy = "Admin" };
            //context.FoodInfos.Add(levrek);



            //FoodInfo lufer = new FoodInfo() { FoodName = "Lüfer", Kalori = 1.37m, Karbonhidrat = 0m, Protein = 0.16m, Yag = 0.09m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(lufer);



            //FoodInfo mezgit = new FoodInfo() { FoodName = "Mezgit", Kalori = 0.82m, Karbonhidrat = 0m, Protein = 0.18m, Yag = 0.06m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(mezgit);



            //FoodInfo midyeDolma = new FoodInfo() { FoodName = "Midye Dolma", Kalori = 26m, Karbonhidrat = 3.08m, Protein = 1.62m, Yag = 0.71m, GramKarsiligi = 100, CreatedBy = "Admin" };
            //context.FoodInfos.Add(midyeDolma);



            //FoodInfo midyeTava = new FoodInfo() { FoodName = "Midye Tava", Kalori = 2m, Karbonhidrat = 0.08m, Protein = 0.09m, Yag = 0.10m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(midyeTava);



            //FoodInfo palamut = new FoodInfo() { FoodName = "Palamut", Kalori = 1.51m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.07m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(palamut);



            //FoodInfo sardalya = new FoodInfo() { FoodName = "Sardalya", Kalori = 1.60m, Karbonhidrat = 0m, Protein = 0.15m, Yag = 0.09m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(sardalya);



            //FoodInfo sazan = new FoodInfo() { FoodName = "Sazan", Kalori = 1.45m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.07m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(sazan);



            //FoodInfo denizTaragi = new FoodInfo() { FoodName = "Deniz Tarağı", Kalori = 0.70m, Karbonhidrat = 0m, Protein = 0.10m, Yag = 0.01m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(denizTaragi);



            //FoodInfo tekir = new FoodInfo() { FoodName = "Tekir", Kalori = 1.51m, Yag = 0.04m, Karbonhidrat = 0m, Protein = 0.25m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(tekir);



            //FoodInfo ton = new FoodInfo() { FoodName = "Ton Balığı", Kalori = 2.90m, Karbonhidrat = 0m, Protein = 0.25m, Yag = 0.21m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(ton);



            //FoodInfo uskumru = new FoodInfo() { FoodName = "İzmarit", Kalori = 1.91m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.12m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(uskumru);



            //FoodInfo yengec = new FoodInfo() { FoodName = "İzmarit", Kalori = 1.01m, Karbonhidrat = 0m, Protein = 0.19m, Yag = 0.18m, CreatedBy = "Admin" };
            //context.FoodInfos.Add(yengec);



            FoodInfo susi = new FoodInfo() { FoodName = "Suşi", Kalori = 125f, Karbonhidrat = 12.42f, Protein = 3.04f, Yag = 7.15f};
            context.FoodInfos.Add(susi);
        }
    }
}
