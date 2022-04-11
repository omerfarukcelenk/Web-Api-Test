namespace Sinav.Query.Entity
{
    public class PersonelQuery
    {

        public const string GetPersonelAl =
        @"Select * from Personel";

        public const string GetSecilenPersonelSql =
        @"Select * from Personel personel WHERE Id=@Id";

        public const string InsertPersonelSql =
           @"INSERT INTO [dbo].[Personel]
           ([Adi]
           ,[Soyadi]
           ,[BolumAdi]
           ,[EmailAdresi]
           ,[KullaniciAdi],
            [Sifre]
            )
     VALUES
           (@Adi
           ,@Soyadi
           ,@BolumAdi
           ,@BolumAdi
           ,@EmailAdresi,
            @KullaniciAdi,
            @Sifre,
            )";

        public const string UpdatePersonelSql =
            @"UPDATE [dbo].[Personel]
                                       SET [Adi] = @Adi
                                          ,[Soyadi] = @Soyadi
                                          ,[BolumAdi] = @BolumAdi
                                          ,[EmailAdresi] = @EmailAdresi
                                          ,[KullaniciAdi] = @KullaniciAdi
                                          ,[Sifre] = @Sifre
                                     WHERE Id=@Id";

        public const string DeletePersonelSql =
            @"DELETE FROM [dbo].[Personel]
                                        WHERE Id=@Id";

        public const string GetSifreKontrolSql =
            @"Select * From [dbo].[Personel] WHERE ( [KullaniciAdi] == @KullaniciAdi && [Sifre] == @Sifre)";
    }
}
