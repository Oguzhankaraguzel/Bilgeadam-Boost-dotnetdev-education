using Dietary.BLL.Exceptions;
using Dietary.DAL.Context;
using Dietary.Entities.Entities.UserEntities;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Dietary.BLL.Services
{
    public class SecurityService
    {
        DietaryDbContext _db = new DietaryDbContext();
       
        private string _Code { get; set; }
        /// <summary>
        /// Kullanıcı girişini kontrol eder.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Eğer kullanıcı veri tabanında kayıtlı ise true, yoksa false döner</returns>
        public bool UserLogin(string eMailOrUserName, string password)
        {
            User user = _db.Users.FirstOrDefault(u => (u.Email == eMailOrUserName && u.Password == sha256_hash(password)) || (u.UserName == eMailOrUserName && u.Password == sha256_hash(password)));
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Yeni bir kullanıcı oluşturulur ve veritabanına kayıt edilir.
        /// Gerekli tüm parametreler kontrol edilir. Gereken hatalar fırlatılır.
        /// Parola şifrelenerek veritabanına kaydedilir.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password1"></param>
        /// <param name="password2"></param>
        /// <returns></returns>
        /// <exception cref="UserEmptyEmailException"></exception>
        /// <exception cref="AlreadyExistEmailException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// 
        public static User usr;
        public bool CreateNewUser(string email, string password1, string password2, string userName)
        {
            #region DoubleCheck
            CheckThePassword(password1, password2);
            CheckTheEmail(email);
            CheckTheUsername(userName);
            #endregion
            bool check = false;
            try
            {
                usr = new User();
                usr.Email = email;
                usr.UserName = userName;
                usr.Password = sha256_hash(password1);
                usr.CreateDate = DateTime.Now;
                _db.Users.Add(usr);
                _db.SaveChanges();
                check = true;
                return check;
            }
            catch (Exception)
            {
                return check;
            }
        }

        /// <summary>
        /// Kullanıcının Şifresini kontrol eder
        /// Şartlar = (password1 == password2) && (password1.Lenth >= 8) && (password1.Contain(A-Z)) || (password1.Contain(Special Character))
        /// </summary>
        /// <param name="password1">şifre</param>
        /// <param name="password2">şifre tekrar</param>
        /// <returns>Eğer geçerli bir şifre girilir ise true döner</returns>
        /// <exception cref="ArgumentException">Şifre belirtilen şartlara uymazsa hata verir</exception>
        public bool CheckThePassword(string password1, string password2)
        {
            if (password1 != password2)
            {
                throw new ArgumentException("The passwords do not match");
            }

            if (string.IsNullOrEmpty(password1))
            {
                throw new ArgumentException("The passwords can not be empty");
            }

            if (string.IsNullOrEmpty(password2))
            {
                throw new ArgumentException("The verification passwords can not be empty");
            }

            if (password1.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters long");
            }
            bool hasUppercase = false;
            bool hasNumberOrSpecialChar = false;
            foreach (char c in password1)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (char.IsDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    hasNumberOrSpecialChar = true;
                }
            }
            if (hasUppercase && hasNumberOrSpecialChar)
            {
                return true;
            }
            throw new ArgumentException("Password must contain at least one uppercase letter and special character");
        }

        /// <summary>
        /// Kullanıcının girdiği Email'i kontrol eder
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="AlreadyExistEmailException">Eğer bu Email adresine sahip kullanıcısı varsa</exception>
        /// <exception cref="UserEmptyEmailException">Email == "" veya Email == null ise</exception>
        public bool CheckTheEmail(string email)
        {
            User user = _db.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                throw new AlreadyExistEmailException();
            }
            if (string.IsNullOrEmpty(email)) throw new UserEmptyEmailException();
            return true;
        }

        /// <summary>
        /// Kullanıcı ismini kontrol eder;
        /// Şartlar ; En az 6 karakter uzunluğunda olmalı ve 1 sayı içermeli.
        /// Veri tabanında kayıtlı olmamalı
        /// </summary>
        /// <param name="username"></param>
        /// <exception cref="UserNameException">Şartlar sağlanmazsa hata verir</exception>
        public void CheckTheUsername(string username)
        {
            if (username == string.Empty || username == null) throw new UserNameException("User name cannot be empty");

            User user = _db.Users.FirstOrDefault(u => u.UserName == username);
            if (user != null) throw new UserNameException();

            if (username.Length < 6) throw new UserNameException("Your username must be at least 6 characters long and contain at least one number.");

            bool hasNumber = false;

            foreach (char c in username)
            {
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
            }
            // if (hasNumber) throw new UserNameException("Your username must be at least 6 characters long and contain at least one number.");

        }
        /// <summary>
        /// Yeni kayıt olan kullanıcıya aktivasyon kodu içeren bir e-mail gönderir;
        /// </summary>
        /// <param name="Email"></param>
        /// <returns>Eğer kod gönderme işlemi başarılı olursa true döner</returns>
        /// <exception cref="SendCodeException">Kon gönderme işlemi başarısız olunca hata verir</exception>
        public bool SendTheActivationCode(string email)
        {
            _Code = "";
            string to = email;
            string from = "REMEMBER ME FAMILY";
            string subject = "Remember Me Activation Code";
            string activationCode = string.Empty;
            Random rnd = new Random();
            while (true)
            {
                char c = (char)rnd.Next(48, 122);
                if ((c >= '0' && c <= '9') || (c <= 'A' && c >= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    activationCode += c;
                }
                if (activationCode.Length == 8)
                {
                    break;
                }
            }
            string body = "Welcome to the Remember me family, here is your activation code ;\n\n\n\t\t" + activationCode;
            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("RMDP.01.69@gmail.com", "RMDP0169!");
            try
            {
                client.Send(message);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Kullanıcının girmiş olduğu aktivasyon kodunu kontrol eder.
        /// </summary>
        /// <param name="ActivationCode">Kullanıcının gireceği aktivasyon kodu</param>
        /// <returns>Eğer kullanıcı kodu doğru girerse true, yoksa false döner</returns>
        public bool CheckTheActivationCode(string ActivationCode)
        {
            if (_Code == ActivationCode.Trim())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kullanıcının girdiği parolayı şifreler
        /// </summary>
        /// <param name="password">Girilen henhangi bir şifre</param>
        /// <returns>şifrelenmiş parolayı geri döndürür</returns>
        public string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2"))); }
        }



        public void UserNameControl(string userName)
        {
            var control = _db.Users.Where(u => u.UserName.Equals(userName)).FirstOrDefault();

            if (control != null)
            {
                throw new UserNameException();
            }



        }

    }
}