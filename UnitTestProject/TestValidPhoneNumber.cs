using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestValidPhoneNumber
    {
        [TestMethod]
        public void TestValidPhonenumber0()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result = quanlyhethong.CheckPhoneNumberValid("12345678");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidPhonenumber1()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("123456789");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber2()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("1234567890");
            Assert.AreEqual(true, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber3()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("12345678900");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber4()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("123456789000");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber5()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("aaaaaaaa");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber6()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("aaaaaaaab");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber7()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("aaaaaaaabb");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber8()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("aaaaaaaabbb");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber9()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("123456789a");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber10()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("");
            Assert.AreEqual(false, result1);
        }
        [TestMethod]
        public void TestValidPhonenumber11()
        {
            string a = "a";
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel(a);
            bool result1 = quanlyhethong.CheckPhoneNumberValid("12345678aa");
            Assert.AreEqual(false, result1);
        }
    }
    [TestClass]
    public class TestValildEmail
    {
        [TestMethod]
        public void TestValidEmail1()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            string email = null;
            bool result = quanlykhachhang.CheckEmailValid(email);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail2()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail3()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@gmail.com.vn");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail4()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@yahoo.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail5()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello-123@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail6()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello_123@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail7()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello.123@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail8()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("123456789@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail9()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello---@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestValidEmail10()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail11()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@gmail..com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail12()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello#@gmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail13()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("@gmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail14()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@hello@gmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail15()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello.gmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail16()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@gmail");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail17()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@-gmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail18()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello.@gmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail19()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello@gmail.web");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail20()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("hello/gmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidEmail21()
        {
            var quanlykhachhang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(1);
            bool result = quanlykhachhang.CheckEmailValid("");
            Assert.AreEqual(false, result);
        }
    }
    [TestClass]
    public class ValidateThemKhachHang
    {
        [TestMethod]
        public void ValidateThemKhachHang1()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang2()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang3()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang4()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang5()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang6()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang7()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang8()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang9()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang10()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang11()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang12()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang13()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang14()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang15()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang16()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang17()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang18()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang19()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang20()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang21()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang22()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang23()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang24()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang25()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang26()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang27()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang28()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang29()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang30()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "hello0012";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang31()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(true, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang32()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(true, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang33()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(true, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang34()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hello@gmail.com";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(true, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang35()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
        [TestMethod]
        public void ValidateThemKhachHang36()
        {
            var quanLyKhachHang = new BookStoreClone.ViewModel.QuanLyKhachHangViewModel(2);

            quanLyKhachHang.TextThemTen = "Nguyễn Nhật Ánh";
            quanLyKhachHang.TextThemDiaChi = "khối 4, hello";
            quanLyKhachHang.TextThemEmail = "hahaha";
            quanLyKhachHang.TextThemSDT = "1234567890";

            Assert.AreEqual(false, quanLyKhachHang.ValidateThemKhachHang());
        }
    }
    [TestClass]
    public class ValidateThemNhanVien
    {
        [TestMethod]
        public void ValidateThemNhanVien1()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = null;
            string sdt = null;
            string username = "";
            string pass = null;

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien2()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = null;
            string sdt = "";
            string username = null;
            string pass = "";

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien3()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = null;
            string sdt = "0987654321";
            string username = "user1";
            string pass = "123456";

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien4()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = "";
            string sdt = null;
            string username = null;
            string pass = "123456";

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien5()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = "";
            string sdt = "";
            string username = "user1";
            string pass = null;

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien6()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = "";
            string sdt = "0987654321";
            string username = "";
            string pass = "";

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien7()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = "Nguyễn Văn A";
            string sdt = null;
            string username = "user1";
            string pass = "";

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien8()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = "Nguyễn Văn A";
            string sdt = "";
            string username = "";
            string pass = "123456";

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
        [TestMethod]
        public void ValidateThemNhanVien9()
        {
            var quanlyhethong = new BookStoreClone.ViewModel.QuanLyHeThongViewModel("a");
            string tenND = "Nguyễn Văn A";
            string sdt = "0987654321";
            string username = null;
            string pass = null;

            Assert.AreEqual(false, quanlyhethong.ValidateThemNhanVien(tenND, sdt, username, pass));
        }
    }
}
