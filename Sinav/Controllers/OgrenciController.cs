using Microsoft.AspNetCore.Mvc;
using System.Data;
using Sinav.Models.Entity;
using Sinav.Query.Entity;

namespace Sinav.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {

        private readonly IDbConnection _dbConnection;
        public OgrenciController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet("api/GetSecilenApi")]
        public async Task<OgrenciEntity> GetAllOgrenciAsync()
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<OgrenciEntity>(
                OgrenciQuery.GetOgrenciAl);
        }

        [HttpGet("api/GetAll")]
        public async Task<OgrenciEntity> GetSecilenOgrenciAsync(int Id)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<OgrenciEntity>(
                OgrenciQuery.GetSecilenOgrenciSql, new { Id = Id });
        }

        [HttpGet("api/Inster")]
        public async Task<OgrenciEntity> InsertOgrenciAsync(String Adi, String Soyadi, String bolumAdi, String EmailAdresi, String KullaniciAdi, String Sifre)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<OgrenciEntity>(
                OgrenciQuery.InsertOgrenciSql, new { Adi = Adi, Soyadi = Soyadi , bolumAdi = bolumAdi , EmailAdresi = EmailAdresi , KullaniciAdi = KullaniciAdi , Sifre  = Sifre });
        }

        [HttpGet("api/UpdatePersonel")]
        public async Task<OgrenciEntity> UpdateOgrenciAsync(int Id,String Adi, String Soyadi, String bolumAdi, String EmailAdresi, String KullaniciAdi, String Sifre)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<OgrenciEntity>(
                OgrenciQuery.UpdateOgrenciSql, new { Id = Id, Adi = Adi, Soyadi = Soyadi, bolumAdi = bolumAdi, EmailAdresi = EmailAdresi, KullaniciAdi = KullaniciAdi, Sifre = Sifre });
        }
        [HttpGet("api/DeletePersonel")]
        public async Task<OgrenciEntity> DeleteOgrenciAsync(int Id)
        {
            return await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<OgrenciEntity>(
                OgrenciQuery.DeleteOgrenciSql, new { Id = Id });
        }

        [HttpGet("api/GetSifreKontrol")]  
        public ActionResult<bool> GetSifreKontrolAsync(string KullaniciAdi, string Sifre)
        {
            var sonuc = new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<OgrenciEntity>(OgrenciQuery.GetSifreKontrolSql, new { KullaniciAdi = KullaniciAdi, Sifre = Sifre });
            if (sonuc == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
