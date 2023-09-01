using Dietary.DAL.Context;
using Dietary.Entities.Entities;
using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using Dietary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Services
{
    public class UserDetailServis
    {
        DietaryDbContext _db = new DietaryDbContext();
        /// <summary>
        /// Oluşturulan kullanıcın detay bilgilerinin sistemde olup olmadığını kontroleder.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ControlDetail(User user)
        {
            User control = _db.Users.Where(u => u.Id == user.Id).FirstOrDefault(u => u.UserDetail != default && u.UserDetail.LastName != default && u.UserDetail.Height != default && u.UserDetail.Weigth != default);

            if (control == null)
            {
                return false;
            }

            else
            {
                return true;
            }

        }
        /// <summary>
        /// Sistemde kayıtlı olmayan kullanıcının detaylarını sisteme ekler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="height"></param>
        /// <param name="weigth"></param>
        /// <param name="gender"></param>
        /// <param name="goal"></param>
        public bool AddUserDetails(User user, string firstName, string lastName, decimal height, decimal weigth, DateTime date, int dietName, int genderName, int goalName, int ActivityLevel)
        {
            try
            {
                user.UserDetail = new UserDetail() { UserId = user.Id, FirstName = firstName, LastName = lastName, Height = height, Weigth = weigth, BirthDate = date, DietId = dietName, GenderId = genderName, GoalId = goalName, ActivityLevelId = ActivityLevel };
                user.UserDetail.PhotoPath = ".\\CatPhoto";
                try
                {
                    _db.UserDetails.Add(user.UserDetail);
                    _db.SaveChanges();
                }
                catch
                {
                    try
                    {
                        _db.UserDetails.Update(user.UserDetail);
                        _db.SaveChanges();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                return true;
            }

            catch (Exception)
            {
                return false;
                throw;
            }

        }

        /// <summary>
        /// Sistemde kayıtlı olan kullanıcıyı bulur.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User FindUser(string userNameOrEmail)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == userNameOrEmail || u.UserName == userNameOrEmail);
            return user;
        }

        public UserDetail FindUserDetail(User user)
        {

            var details = _db.UserDetails.FirstOrDefault(u => u.UserId == user.Id);

            return details;

        }

        /// <summary>
        /// Kullanıcının parolasını değiştiren metot
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password1"></param>
        /// <param name="password2"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool ChangePassword(User user, string password1, string password2)
        {
            SecurityService securityService = new SecurityService();
            securityService.CheckThePassword(password1, password2);
            try
            {
                string newPassword = securityService.sha256_hash(password2);
                var selectUser = _db.Users.FirstOrDefault(x => x.Id == user.Id);
                selectUser.Password = newPassword;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}