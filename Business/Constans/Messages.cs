using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public class Messages
    {
        public static string ApartmentAdded = "Apartman başarıyla eklendi";
        public static string AparmentDeleted = "Apartman başarıyla silindi";
        public static string ApartmentUpdated = "Apartman başarıyla güncellendi";

        public static string BillAdded = "Fatura Eklendi";
        public static string BillDeleted = "Fatura Silindi";
        public static string BillUpdated = "Fatura Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string DuesAdded = "Fatura Eklendi";
        public static string DuesDeleted = "Fatura Silindi";
        public static string DuesUpdated = "Fatura Güncellendi";

        public static string MessageAdded = "Mesaj Eklendi";
        public static string MessageDeleted = "Mesaj Silindi";
        public static string MessageUpdate = "Mesaj Düzenlendi";

        public static string PaymentAdded = "Ödeme Eklendi";
        public static string PaymentUpdate = "Ödeme Güncellendi";
        public static string PaymentDeleted = "Ödeme Silindi ! ";

        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string AccessTokenCreated = "Token olusturuldu";
        public static string UserRegistered = "User successfuly registered ";
        public static string UserNotFound = "User has not found";
        public static string PasswordError = "invalid password";

        public static string SuccessfullLogin = "successful login";
        public static string UserAlreadyExists = "Kullanici mevcut";

        public static string UserCardDeleted = "Card is deleted ";
        public static string UserCardAdded = " Card is Added";
        public static string UserCardUpdated = "Card is updated";

        public static string BillDetailEmpty = "BillDetail is empty";
    }
}
