namespace Sinav.Query.Entity
{
    public class OgrenciQuery
    {

        public const string GetOgrenciAl =
        @"Select * from Ogrenci";

        public const string GetSecilenOgrenciSql =
        @"Select * from Ogrenci WHERE Id=@Id";

        public const string InsertOgrenciSql =
           @"INSERT INTO [dbo].[Ogrenci]
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

        public const string UpdateOgrenciSql =
            @"UPDATE [dbo].[Ogrenci]
                                       SET [Adi] = @Adi
                                          ,[Soyadi] = @Soyadi
                                          ,[BolumAdi] = @BolumAdi
                                          ,[EmailAdresi] = @EmailAdresi
                                          ,[KullaniciAdi] = @KullaniciAdi
                                          ,[Sifre] = @Sifre
                                     WHERE Id=@Id";

        public const string DeleteOgrenciSql =
            @"DELETE FROM [dbo].[Ogrenci]
                                        WHERE Id=@Id";

        public const string GetSifreKontrolSql =
            @"Select * From [dbo].[Ogrenci] WHERE ( [KullaniciAdi] == @KullaniciAdi && [Sifre] == @Sifre)";
    }
}
