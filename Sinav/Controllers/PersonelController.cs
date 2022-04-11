﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sinav.Models.Entity;

namespace Sinav.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {

        private readonly IDbConnection _dbConnection;
        public ApiController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet("api/GetSecilenApi")]
        public async Task<PersonelEntity> GetAllPersonelAsync()
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<PersonelEntity>(
                PersonelQuery.GetPersonelAl);
        }

        [HttpGet("api/GetAll")]
        public async Task<PersonelEntity> GetSecilenDuyuruAsync(int Id)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<PersonelEntity>(
                PersonelQuery.GetSecilenPersonelSql, new { Id = Id });
        }

        [HttpGet("api/Inster")]
        public async Task<PersonelEntity> InsertPersonelAsync(String Adi, String Soyadi, String bolumAdi, String EmailAdresi, String KullaniciAdi, String Sifre)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<PersonelEntity>(
                PersonelQuery.InsertPersonelSql, new { Adi = Adi, Soyadi = Soyadi , bolumAdi = bolumAdi , EmailAdresi = EmailAdresi , KullaniciAdi = KullaniciAdi , Sifre  = Sifre });
        }

        [HttpGet("api/UpdatePersonel")]
        public async Task<PersonelEntity> UpdatePersonelAsync(int Id,String Adi, String Soyadi, String bolumAdi, String EmailAdresi, String KullaniciAdi, String Sifre)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<PersonelEntity>(
                PersonelQuery.UpdatePersonelSql, new { Id = Id, Adi = Adi, Soyadi = Soyadi, bolumAdi = bolumAdi, EmailAdresi = EmailAdresi, KullaniciAdi = KullaniciAdi, Sifre = Sifre });
        }
        [HttpGet("api/DeletePersonel")]
        public async Task<PersonelEntity> GetSecilenDuyuruAsync(int Id)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<PersonelEntity>(
                PersonelQuery.DeletePersonelSql, new { Id = Id });
        }


    }
}