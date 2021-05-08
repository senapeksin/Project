using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride maksimum 10 ürün bulunabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var.";
        public  static string CategoryLimitExceded="Kategori Limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered ="Kullanıcı Kayıt Oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı Mevcut.";
        public static string AccessTokenCreated="Erişim Anahtarı olusturuldu.";
    }
}
