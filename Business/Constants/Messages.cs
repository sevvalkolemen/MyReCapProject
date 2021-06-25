﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarDeleted = "Araç Silindi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorUpdated = "Renk Güncellendi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandUpdated = "Marka Güncellendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalInvalid = "Kiralama Geçersiz";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalsListed = "Kiralamalar Listelendi";
        public static string RentalUpdated = "Kiralama Güncellendi";

        public static string ImageLimit = "Limit Aşıldı";
        public static string CarImageMustBeExists = "Araba Resmi Mevcut Olamlı";
        internal static string CarImageAdded = "Araba Resmi Eklendi";
        internal static string AuthorizationDenied = "Yekiniz yok";
        internal static string UserRegistered = "Kayıt Olundu";
        internal static string UserNotFound = "Kullanıcı Bulunamadı" ;
        internal static string PasswordError = "Şifre hatalı";
        internal static string SuccessfulLogin = "Başarılı giriş";
        internal static string UserAlreadyExists="Kullanıcı mevcut";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}
