using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Message
    {
        public static string QuestionGetAllSuccess = "Sorular başarıyla getirildi";
        public static string QuestionCreated = "Sorunuz oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok !";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        internal static string ImageUploaded;
        internal static string ImageRemoved;
        internal static string ImagesListed;
        internal static string ImageLimit;
        internal static string UserUpdated;
    }
}
